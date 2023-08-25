using MenuWF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MenuWF
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var appsettigsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            var configuration = new ConfigurationBuilder()
                                    .AddJsonFile(appsettigsPath)
                                    .Build();

            var configurationString = configuration.GetConnectionString("AppDbContext");

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>()
                                    .UseSqlServer(configurationString);

            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                Application.Run(new MainForm(dbContext));
            }
        }
    }
}