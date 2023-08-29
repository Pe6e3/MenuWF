using MenuWF.Data;
using MenuWF.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MenuWF
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            // �������� ������� ��� ������ ������
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
                UnitOfWork uow = new UnitOfWork(dbContext);
                Application.Run(new MainForm(uow));
            }
 
        }
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

    }
}