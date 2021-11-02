using EnergyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EnergyAPI.Helpers {
    public static class EnergyGenerationHelpers {
        public static IEnumerable<EnergyGeneration> FilterEnergyGeneration(this DbSet<EnergyGeneration> energyGenerations, EnergyGenerationFilter filter) {
            return energyGenerations.FilterYear(filter.Year).FilterRegion(filter.Region).FilterWind2(filter.Wind2);

        }

        private static IQueryable<EnergyGeneration> FilterYear(this IQueryable<EnergyGeneration> source, int? year) {
            
            if(!year.HasValue)
                return source;

            return source.Where(eg => eg.Year == year);
        }

        private static IQueryable<EnergyGeneration> FilterRegion(this IQueryable<EnergyGeneration> source, string region) {

            if(region.Length == 0)
                return source;

            // Need to transform to normal text

            return source.Where(eg => eg.Region == region);
        }

        private static IQueryable<EnergyGeneration> FilterWind2(this IQueryable<EnergyGeneration> source, decimal? wind2) {

            if(!wind2.HasValue)
                return source;

            return source.Where(eg => eg.Wind2 == wind2);
        }
    }
}
