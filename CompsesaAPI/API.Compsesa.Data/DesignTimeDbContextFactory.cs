using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace API.Compsesa.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<APICompsesaContext>
    {
        public APICompsesaContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "API.Compsesa.API"))
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<APICompsesaContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseNpgsql(connectionString);

            return new APICompsesaContext(optionsBuilder.Options);
        }
    }
}
