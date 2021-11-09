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
    [Route("api/energyrecords")]
    [ApiController]
    [Authorize]
    public class EnergyRecordController : ControllerBase {
        private readonly EnergyRecordDbContext dbContext;
        private readonly IDistributedCache cache;

        public EnergyRecordController(EnergyRecordDbContext context, IDistributedCache cache) {
            dbContext = context;
            this.cache = cache;
        }

        [HttpGet]
        public async Task<IEnumerable<EnergyRecord>> GetEnergyGenerations([FromQuery] int? page, [FromQuery] EnergyRecordFilter filters) {

            // Need to log query
            var energyRecords = await cache.GetCacheAsync<List<EnergyRecord>>($"{page}{JsonSerializer.Serialize(filters)}");

            if(energyRecords != null) {
                return energyRecords;
            }

            energyRecords = await dbContext.EnergyRecord.AsNoTracking().FilterEnergyGeneration(filters).FilterPage(page).ToListAsync();
            await cache.SetCacheAsync($"{page}{JsonSerializer.Serialize(filters)}", energyRecords);

            return energyRecords;
        }

        [HttpGet("{id}")]
        public async Task<EnergyRecord> GetEnergyGeneration(int id) {

           var energyRecord = await cache.GetCacheAsync<EnergyRecord>($"{id}");
            // Need to log query
            if(energyRecord != null) {
                return energyRecord;
            }

            energyRecord = dbContext.EnergyRecord.Where(eg => eg.Id == id).Single();
            await cache.SetCacheAsync($"{id}", energyRecord);

            return energyRecord;
        }

        [HttpPost("add")]
        public async Task<EnergyRecord> AddEnergyGeneration([FromBody] EnergyRecord energyRecord) {
            await dbContext.EnergyRecord.AddAsync(energyRecord);
            await dbContext.SaveChangesAsync();

            return energyRecord;
        }

        [HttpPut("{id}/edit")]
        public async Task<EnergyRecord> EditEnergyGeneration(int id, [FromBody] EnergyRecord energyRecord) {
            var trackedEntity = dbContext.Entry(dbContext.EnergyRecord.FirstOrDefault(eg => eg.Id == id));
            energyRecord.Id = id;
            trackedEntity.CurrentValues.SetValues(energyRecord);
            await dbContext.SaveChangesAsync();

            return trackedEntity.Entity;
        }
    }
}
