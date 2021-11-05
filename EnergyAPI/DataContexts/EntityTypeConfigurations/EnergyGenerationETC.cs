using System;
using System.Linq;
using EnergyAPI.Helpers;
using EnergyAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EnergyAPI.DataContexts.EntityTypeConfigurations {
    public class EnergyGenerationETC : IEntityTypeConfiguration<EnergyGeneration> {
        public void Configure(EntityTypeBuilder<EnergyGeneration> builder) {

            builder.HasKey(eg => eg.Id);

            builder
                .Property(eg => eg.Price)
                .HasPrecision(14, 2)
                .HasDefaultValue(0.0m);

            builder
                .Property(eg => eg.Region)
                .HasMaxLength(100);

            builder
                .Property(eg => eg.Wind2)
                .HasPrecision(14, 1)
                .HasDefaultValue(0.0m);

            builder
                .Property(eg => eg.WaveAndTidal)
                .HasPrecision(14, 1)
                .HasDefaultValue(0.0m);

            builder
                .Property(eg => eg.SolarPv)
                .HasPrecision(14, 1)
                .HasDefaultValue(0.0m);

            builder
                .Property(eg => eg.Hydro)
                .HasPrecision(14, 1)
                .HasDefaultValue(0.0m);

            builder
                .Property(eg => eg.LandfillGas)
                .HasPrecision(14, 1)
                .HasDefaultValue(0.0m);

            builder
                .Property(eg => eg.OtherBioEnergy)
                .HasPrecision(14, 1)
                .HasDefaultValue(0.0m);

            builder
                .Property(eg => eg.Total)
                .HasPrecision(14, 1)
                .HasDefaultValue(0.0m);

            var years = new int[4] { 2003, 2004, 2005, 2006 };
            var regions = new string[4] { "England", "Northern Ireland", "Yorkshire and the Humber", "Scotland" };
            var random = new Random();

            builder.HasData(Enumerable.Range(1, 50).Select(index => new EnergyGeneration {
                Id = index,
                Price = random.NextDecimal(2),
                Year = years[random.Next(4)],
                Region = regions[random.Next(4)],
                Wind2 = random.NextDecimal(),
                WaveAndTidal = random.NextDecimal(),
                SolarPv = random.NextDecimal(),
                Hydro = random.NextDecimal(),
                LandfillGas = random.NextDecimal(),
                OtherBioEnergy = random.NextDecimal(),
                Total = random.NextDecimal(),
                Image = "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg"
            }));
        }
    }
}
