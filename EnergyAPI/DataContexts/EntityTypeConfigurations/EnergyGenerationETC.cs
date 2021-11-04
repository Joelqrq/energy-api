using EnergyAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EnergyAPI.DataContexts.EntityTypeConfigurations {
    public class EnergyGenerationETC : IEntityTypeConfiguration<EnergyGeneration> {
        public void Configure(EntityTypeBuilder<EnergyGeneration> builder) {

            builder.HasKey(eg => eg.Id);

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

            builder.HasData(new EnergyGeneration[] {
                new EnergyGeneration {
                    Id = 1,
                    Year = 2003,
                    Region = "England",
                    Wind2 = 349.2m,
                    WaveAndTidal = 0.0m,
                    SolarPv = 25.3m,
                    Hydro = 25.3m,
                    LandfillGas = 2899.0m,
                    OtherBioEnergy = 2716.9m,
                    Total = 5990.4m
                },
                new EnergyGeneration {
                    Id = 2,
                    Year = 2009,
                    Region = "Northern Ireland",
                    Wind2 = 743.8m,
                    WaveAndTidal = 0.6m,
                    SolarPv = 0.0m,
                    Hydro = 30.8m,
                    LandfillGas = 22.5m,
                    OtherBioEnergy = 0.8m,
                    Total = 19.3m
                },
                new EnergyGeneration {
                    Id = 3,
                    Year = 2013,
                    Region = "Yorkshire and the Humber",
                    Wind2 = 774.5m,
                    WaveAndTidal = 0.2m,
                    SolarPv = 129.6m,
                    Hydro = 6.5m,
                    LandfillGas = 465.3m,
                    OtherBioEnergy = 31.8m,
                    Total = 3637.6m
                },
                new EnergyGeneration {
                    Id = 4,
                    Year = 2015,
                    Region = "Scotland",
                    Wind2 = 13833.5m,
                    WaveAndTidal = 2.0m,
                    SolarPv = 173.9m,
                    Hydro = 5757.1m,
                    LandfillGas = 503.4m,
                    OtherBioEnergy = 26.2m,
                    Total = 1331.4m
                }
            });
        }
    }
}
