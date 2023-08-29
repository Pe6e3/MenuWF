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
            // Создание консоли для вывода ошибок
            AllocConsole();

            ApplicationConfiguration.Initialize();

            using (var dbContext = new AppDbContext())
            {
                UnitOfWork uow = new UnitOfWork();
                Application.Run(new MainForm());
            }
 
        }
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

    }
}