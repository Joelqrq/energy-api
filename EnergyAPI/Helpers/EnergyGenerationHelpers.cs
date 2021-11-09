using EnergyAPI.Models;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace EnergyAPI.Helpers {
    public static class EnergyGenerationHelpers {

        public static IQueryable<EnergyRecord> FilterEnergyGeneration(this IQueryable<EnergyRecord> query, EnergyRecordFilter filter) {

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

        public static IQueryable<EnergyRecord> FilterPage(this IQueryable<EnergyRecord> query, int? page) {

            if(!page.HasValue)
                page = 1;

            var takeAmount = 30;
            int skipAmount = (page.Value - 1) * takeAmount;

            return query
                .OrderBy(eg => eg.Id)
                .Skip(skipAmount)
                .Take(takeAmount);
        }

        private static IQueryable<EnergyRecord> Filter<T>(this IQueryable<EnergyRecord> source, string property, T filter) {

            if(filter == null)
                return source;

            var parameter = Expression.Parameter(typeof(EnergyRecord));
            var accessor = Expression.Property(parameter, property);
            var lambda = Expression.Lambda<Func<EnergyRecord, bool>>(Expression.Equal(accessor, Expression.Constant(filter)), parameter);

            return source.Where(lambda);
        }

        private static string TransformKebabCaseToTitleCase(this string value) {

            if(string.IsNullOrEmpty(value))
                return value;

            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.Replace('-', ' '));
        }
    }
}
