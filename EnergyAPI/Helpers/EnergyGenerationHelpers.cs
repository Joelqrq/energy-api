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
            return energyGenerations
                .Filter("Year", filter.Year)
                .Filter("Region", System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(filter.Region.Replace('-', ' ')))
                .Filter("Wind2", filter.Wind2)
                .Filter("WaveAndTidal", filter.WaveAndTidal)
                .Filter("SolarPv", filter.SolarPv)
                .Filter("Hydro", filter.Hydro)
                .Filter("LandfillGas", filter.LandfillGas)
                .Filter("OtherBioEnergy", filter.OtherBioEnergy)
                .Filter("Total", filter.Total);

            // Need to create 
        }

        private static IQueryable<EnergyGeneration> Filter<T>(this IQueryable<EnergyGeneration> source, string property, T filter) {

            if(filter == null)
                return source;

            var parameter = Expression.Parameter(typeof(EnergyGeneration));
            var accessor = Expression.Property(parameter, property);
            var lambda = Expression.Lambda<Func<EnergyGeneration, bool>>(Expression.Equal(accessor, Expression.Constant(filter)), parameter);

            return source.Where(lambda);
        }
    }
}
