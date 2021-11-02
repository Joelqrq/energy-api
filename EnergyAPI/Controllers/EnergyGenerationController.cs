﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnergyAPI.DataContexts;
using EnergyAPI.Helpers;
using EnergyAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EnergyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnergyGenerationController : ControllerBase
    {
        private readonly EnergyGenerationDbContext dbContext;

        public EnergyGenerationController(EnergyGenerationDbContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        public IEnumerable<EnergyGeneration> GetEnergyGenerations([FromQuery]int? page, [FromQuery]EnergyGenerationFilter filters) {

            return dbContext.EnergyGeneration.AsNoTracking().FilterEnergyGeneration(filters).FilterPage(page).ToList();
        }

        [HttpGet("{id}")]
        public EnergyGeneration GetEnergyGeneration(int id)
        {
            return dbContext.EnergyGeneration.Where(eg => eg.Id == id).Single();
        }

        [HttpPost("add")]
        public EnergyGeneration AddEnergyGeneration([FromBody]EnergyGeneration energyGeneration) {
            var energyGenerationToBeAdded = dbContext.EnergyGeneration.Add(energyGeneration).Entity;
            dbContext.SaveChanges();

            return energyGenerationToBeAdded;
        }

        [HttpPut("{id}/edit")]
        public EnergyGeneration EditEnergyGeneration(int id, [FromBody]EnergyGeneration energyGeneration) {
            var trackedEntity = dbContext.Entry(dbContext.EnergyGeneration.FirstOrDefault(eg => eg.Id == id));
            trackedEntity.State = EntityState.Modified;
            energyGeneration.Id = id;
            trackedEntity.CurrentValues.SetValues(energyGeneration);
            dbContext.SaveChanges();

            return trackedEntity.Entity;
        }
    }
}
