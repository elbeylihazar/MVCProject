using Microsoft.EntityFrameworkCore;

namespace ViewProject.Models
{
    public class VeritabaniContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                string connectionString = configuration.GetConnectionString("DatabseConnection");

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<KategoriUrunTarihSatisModel> Satislar { get; set; }
       
    }
}
