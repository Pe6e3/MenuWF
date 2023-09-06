using MenuWF.Data;
using MenuWF.Repository;

namespace MenuWF
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            using (var dbContext = new AppDbContext())
            {
                UnitOfWork uow = new UnitOfWork();
                Application.Run(new MainForm());
            }
 
        }

    }
}