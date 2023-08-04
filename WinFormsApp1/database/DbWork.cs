using System.Data.SqlClient;

namespace WinFormsApp1.database
{
    public static class DbWork
    {
        public static void Tables()
        {
            CreateTables();
        }

        public static bool CheckTables()
        {
            if (CheckTable("CompanyEmployees") == 0 && CheckTable("Divisions") == 0)
                return false;
            return true;
        }

        private static int CheckTable(string tableName)
        {
            var conString = DbConnection.SQLConnectionString;
            var commandText = "SELECT count(Id) FROM sysobjects WHERE name = @tableName and type = 'U'";
            int count = 0;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                SqlCommand command = new()
                {
                    CommandText = commandText,
                    Connection = connection,
                };
                command.Parameters.AddWithValue("@tableName", tableName);
                count = (int)command.ExecuteScalar();
            }

            return count;
        }

        private static void CreateTables()
        {
            CreateEmployeeTable();
            CreateDivisionTable();
            CreateAlterTable();
        }

        private static void CreateEmployeeTable()
        {
            var conString = DbConnection.SQLConnectionString;
            var commandText = "CREATE TABLE CompanyEmployees " +
                    "(Id int IDENTITY(1,1) PRIMARY KEY," +
                    "FullName nvarchar(255) NOT NULL," +
                    "ServiceNumber nvarchar(20) NOT NULL," +
                    "Position nvarchar(255) NOT NULL," +
                    "DivisionID int," +
                    "Email nvarchar(255) NOT NULL," +
                    "Number nvarchar(20) NOT NULL," +
                    "DateOfAppointment date NOT NULL," +
                    "DateOfDismissal date NULL," +
                    "StatusOfAccount int NOT NULL," +
                    ");";
            MakeSQLCommand(conString, commandText);
        }

        private static void CreateDivisionTable()
        {
            var conString = DbConnection.SQLConnectionString;
            var commandText = "CREATE TABLE Divisions" +
                    "(Id int IDENTITY(1,1) PRIMARY KEY," +
                    "DivisionName nvarchar(255) NOT NULL," +
                    "HeadDivision int," +
                    "Manager int," +
                    "StatusOfDivision int NOT NULL," +
                    "Employees int," +
                    "FOREIGN KEY (HeadDivision) REFERENCES Divisions(Id)," +
                    "FOREIGN KEY (Manager) REFERENCES CompanyEmployees(Id)," +
                    "FOREIGN KEY (Employees) REFERENCES CompanyEmployees(Id));";
            MakeSQLCommand(conString, commandText);
        }

        private static void CreateAlterTable()
        {
            var conString = DbConnection.SQLConnectionString;
            var commandText = "ALTER TABLE CompanyEmployees ADD CONSTRAINT FK_CompanyEmployees_To_Divisions FOREIGN KEY(DivisionID) REFERENCES Divisions(Id)";
            MakeSQLCommand(conString, commandText);
        }

        private static void MakeSQLCommand(string SqlConnectionString, string CommandText)
        {
            using (SqlConnection connection = new(SqlConnectionString))
            {
                connection.Open();

                SqlCommand command = new()
                {
                    CommandText = CommandText,
                    Connection = connection
                };
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
