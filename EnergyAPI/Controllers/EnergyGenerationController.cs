using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnergyAPI.DataContexts;
using EnergyAPI.Helpers;
using EnergyAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
        public IEnumerable<EnergyGeneration> GetEnergyGenerations(int? page, [FromQuery]EnergyGenerationFilter filters) {

            var ems = dbContext.EnergyGeneration.FilterEnergyGeneration(filters).ToList();

            return ems;
        }

        [HttpGet("{id}")]
        public EnergyGeneration GetEnergyGeneration(int id)
        {
            return new EnergyGeneration {
                Year = 2021,
                Region = "Test"
            };
        }
    }
}
