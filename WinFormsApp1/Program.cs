using WinFormsApp1.database;

namespace WinFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DoWork();
            Application.Run(new MainForm());
        }

        private static void DoWork()
        {
            if (DbConnection.IsServerConnected(DbConnection.SQLConnectionString))
            {
                if(!DbWork.CheckTables())
                    DbWork.Tables();
            }
        }
    }
}