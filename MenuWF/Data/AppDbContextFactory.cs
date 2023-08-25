using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MenuWF.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var appsettigsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            var configuration = new ConfigurationBuilder()
                .AddJsonFile(appsettigsPath)
                .Build();

            var configurationString = configuration.GetConnectionString("AppDbContext");

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(configurationString);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
