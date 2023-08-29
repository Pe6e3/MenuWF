using MenuWF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MenuWF
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            // Создание консоли для вывода ошибок
            AllocConsole();

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
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

    }
}