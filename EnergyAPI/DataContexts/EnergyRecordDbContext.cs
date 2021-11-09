using EnergyAPI.DataContexts.EntityTypeConfigurations;
using EnergyAPI.Models;
using EnergyAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace EnergyAPI.DataContexts {
    public class EnergyRecordDbContext : DbContext {

        public EnergyRecordDbContext(DbContextOptions<EnergyRecordDbContext> options, NotificationService notificationService) : base(options) {
            //ChangeTracker.StateChanged += notificationService.BroadcastToClient;
        }

        public virtual DbSet<EnergyRecord> EnergyRecord { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            new EnergyRecordETC().Configure(builder.Entity<EnergyRecord>());
        }
    }
}
