using EnergyAPI.Models;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace EnergyAPI.Helpers {
    public static class EnergyGenerationHelpers {
        public static IQueryable<EnergyGeneration> FilterEnergyGeneration(this IQueryable<EnergyGeneration> query, EnergyGenerationFilter filter) {

            return query
                .Filter("Year", filter.Year)
                .Filter("Region", filter.Region.TransformKebabCaseToTitleCase())
                .Filter("Wind2", filter.Wind2)
                .Filter("WaveAndTidal", filter.WaveAndTidal)
                .Filter("SolarPv", filter.SolarPv)
                .Filter("Hydro", filter.Hydro)
                .Filter("LandfillGas", filter.LandfillGas)
                .Filter("OtherBioEnergy", filter.OtherBioEnergy)
                .Filter("Total", filter.Total);
        }

        public static IQueryable<EnergyGeneration> FilterPage(this IQueryable<EnergyGeneration> query, int? page) {

            if(!page.HasValue)
                page = 1;

            var takeAmount = 2;
            int skipAmount = (page.Value - 1) * takeAmount;

            return query
                .OrderBy(eg => eg.Id)
                .Skip(skipAmount)
                .Take(takeAmount);
        }

        private static IQueryable<EnergyGeneration> Filter<T>(this IQueryable<EnergyGeneration> source, string property, T filter) {

            if(filter == null)
                return source;

            var parameter = Expression.Parameter(typeof(EnergyGeneration));
            var accessor = Expression.Property(parameter, property);
            var lambda = Expression.Lambda<Func<EnergyGeneration, bool>>(Expression.Equal(accessor, Expression.Constant(filter)), parameter);

            return source.Where(lambda);
        }

        private static string TransformKebabCaseToTitleCase(this string value) {

            if(string.IsNullOrEmpty(value))
                return value;

            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.Replace('-', ' '));
        }
    }
}
