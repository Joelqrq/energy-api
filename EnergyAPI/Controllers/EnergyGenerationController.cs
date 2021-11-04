using EnergyAPI.DataContexts;
using EnergyAPI.Helpers;
using EnergyAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace EnergyAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EnergyGenerationController : ControllerBase {
        private readonly EnergyGenerationDbContext dbContext;
        private readonly IDistributedCache cache;

        public EnergyGenerationController(EnergyGenerationDbContext context, IDistributedCache cache) {
            dbContext = context;
            this.cache = cache;
        }

        [HttpGet]
        public async Task<string> GetEnergyGenerations([FromQuery] int? page, [FromQuery] EnergyGenerationFilter filters) {

            // Need to log query
            var energyGenerations = await cache.GetCacheAsync<IEnumerable<EnergyGeneration>>($"{page}{JsonSerializer.Serialize(filters)}");
            Console.WriteLine(energyGenerations);

            if(energyGenerations != null) {
                return JsonSerializer.Serialize(new { source = energyGenerations, message = "cache" });
            }

            energyGenerations = await dbContext.EnergyGeneration.AsNoTracking().FilterEnergyGeneration(filters).FilterPage(page).ToListAsync();
            await cache.SetCacheAsync($"{page}{JsonSerializer.Serialize(filters)}", energyGenerations);

            return JsonSerializer.Serialize(new { source = energyGenerations, message = "non-cache" });
        }

        [HttpGet("{id}")]
        public async Task<string> GetEnergyGeneration(int id) {

           var energyGeneration = await cache.GetCacheAsync<EnergyGeneration>($"{id}");
            // Need to log query
            if(energyGeneration != null) {
                return JsonSerializer.Serialize(new { source = energyGeneration, message = "cache" });
            }

            energyGeneration = dbContext.EnergyGeneration.Where(eg => eg.Id == id).Single();
            await cache.SetCacheAsync($"{id}", energyGeneration);

            return JsonSerializer.Serialize(new { source = energyGeneration, message = "non-cache" });
        }

        [HttpPost("add")]
        public EnergyGeneration AddEnergyGeneration([FromBody] EnergyGeneration energyGeneration) {
            var energyGenerationToBeAdded = dbContext.EnergyGeneration.Add(energyGeneration).Entity;
            dbContext.SaveChanges();

            return energyGenerationToBeAdded;
        }

        [HttpPut("{id}/edit")]
        public EnergyGeneration EditEnergyGeneration(int id, [FromBody] EnergyGeneration energyGeneration) {
            var trackedEntity = dbContext.Entry(dbContext.EnergyGeneration.FirstOrDefault(eg => eg.Id == id));
            trackedEntity.State = EntityState.Modified;
            energyGeneration.Id = id;
            trackedEntity.CurrentValues.SetValues(energyGeneration);
            dbContext.SaveChanges();

            return trackedEntity.Entity;
        }
    }
}
