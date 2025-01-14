using Microsoft.EntityFrameworkCore;

namespace WebApi.DB
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ComputerEquipment> ComputerEquipment { get; set; }
        public DbSet<EquipmentType> EquipmentType { get; set; }
        public ApplicationContext()
        {
            // Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json")
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .Build();

            optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));
        }
    }
}
