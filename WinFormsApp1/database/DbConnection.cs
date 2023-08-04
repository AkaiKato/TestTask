using System.Data.SqlClient;

namespace WinFormsApp1.database
{
    public static class DbConnection
    {
        private static readonly string DefSQLConnectionString = "Server=.\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        private static readonly string DbSQLConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rail2\\source\\repos\\WinFormsApp1\\WinFormsApp1\\TestTask.mdf;Integrated Security=True";

        public static string DefaultSQLConnectionString { get { return DefSQLConnectionString; } }
        public static string SQLConnectionString { get { return DbSQLConnectionString; } }

        public static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}
