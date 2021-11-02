using EnergyAPI.DataContexts.EntityTypeConfigurations;
using EnergyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EnergyAPI.DataContexts {
    public class EnergyGenerationDbContext : DbContext {

        public EnergyGenerationDbContext(DbContextOptions<EnergyGenerationDbContext> options) : base(options) {

        }

        public virtual DbSet<EnergyGeneration> EnergyGeneration { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            new EnergyGenerationETC().Configure(builder.Entity<EnergyGeneration>());
        }
    }
}
