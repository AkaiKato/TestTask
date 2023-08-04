using System.Data.SqlClient;
using WinFormsApp1.database;
using WinFormsApp1.models;

namespace WinFormsApp1.tablework
{
    public class DivisionTableWork
    {
        public List<TransferObject> GetDivisionsIdNames()
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "SELECT Id, DivisionName FROM Divisions";

            List<TransferObject> result = new List<TransferObject>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlComa, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(new TransferObject
                        {
                            Id = (int)reader.GetValue(0),
                            Name = (string)reader.GetValue(1)
                        });
                    }
                }

                reader.Close();
            }

            return result;
        }

        public string GetDivisionNameById(int id)
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "SELECT DivisionName FROM Divisions WHERE Id = @id";

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlComa, connection);

                SqlParameter DivId = new("@id", id);
                command.Parameters.Add(DivId);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return (string)reader.GetValue(0);
                    }
                }

                reader.Close();
            }

            return "";
        }

        public Division GetDivisionById(int id)
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "SELECT * FROM Divisions WHERE Id = @id";

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlComa, connection);

                SqlParameter DivId = new("@id", id);
                command.Parameters.Add(DivId);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return new Division
                        {
                            Id = (int)reader.GetValue(0),
                            DivisionName = (string)reader.GetValue(1),
                            HeadDivision = reader.GetValue(2) is DBNull ? 0 : (int)reader.GetValue(2),
                            Manager = reader.GetValue(3) is DBNull ? 0 : (int)reader.GetValue(3),
                            StatusOfDivision = (int)reader.GetValue(4),
                        };
                    }
                }
                reader.Close();
            }

            return new Division();
        }

        public List<Division> GetAllDivisions()
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "SELECT * FROM Divisions";

            List<Division> list = new();
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlComa, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(new Division
                        {
                            Id = (int)reader.GetValue(0),
                            DivisionName = (string)reader.GetValue(1),
                            HeadDivision = reader.GetValue(2) is DBNull ? 0 : (int)reader.GetValue(2),
                            Manager = reader.GetValue(3) is DBNull ? 0 : (int)reader.GetValue(3),
                            StatusOfDivision = (int)reader.GetValue(4),
                        });
                    }
                }
                reader.Close();
            }
            return list;
        }

        public void CreateDivision(Division division)
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "INSERT INTO Divisions " +
                "(DivisionName, HeadDivision, Manager, StatusOfDivision)" +
                "VALUES (@DivName, @HeadDiv, @Manager, @Status)";

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlComa, connection);

                SqlParameter DivName = new("@DivName", division.DivisionName);
                command.Parameters.Add(DivName);

                SqlParameter HeadDiv = new("@HeadDiv", DBNull.Value);
                if (division.HeadDivision != 0)
                    HeadDiv = new SqlParameter("@HeadDiv", division.HeadDivision);

                command.Parameters.Add(HeadDiv);

                SqlParameter Manager = new("@Manager", DBNull.Value);
                if (division.Manager != 0)
                    Manager = new SqlParameter("@Manager", division.Manager);
                command.Parameters.Add(Manager);

                SqlParameter Status = new("@Status", division.StatusOfDivision);
                command.Parameters.Add(Status);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateDivision(Division division)
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "UPDATE Divisions " +
                "SET DivisionName=@DivName," +
                "HeadDivision=@HeadDiv," +
                "Manager=@Manager," +
                "StatusOfDivision=@Status " +
                "WHERE Id=@id";

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlComa, connection);

                SqlParameter DivName = new("@DivName", division.DivisionName);
                command.Parameters.Add(DivName);

                SqlParameter HeadDiv = new("@HeadDiv", DBNull.Value);
                if (division.HeadDivision != 0)
                    HeadDiv = new SqlParameter("@HeadDiv", division.HeadDivision);

                command.Parameters.Add(HeadDiv);

                SqlParameter Manager = new("@Manager", DBNull.Value);
                if (division.Manager != 0)
                    Manager = new SqlParameter("@Manager", division.Manager);
                command.Parameters.Add(Manager);

                SqlParameter Status = new("@Status", division.StatusOfDivision);
                command.Parameters.Add(Status);

                SqlParameter Id = new("@id", division.Id);
                command.Parameters.Add(Id);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteDivision(int id)
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "DELETE FROM Divisions WHERE Id = @id";
            string sqlCheck = "UPDATE Divisions " +
                "SET HeadDivision = @HeadDiv " +
                "WHERE HeadDivision = @id";
            string sqlEmployee = "UPDATE CompanyEmployees " +
                "SET DivisionID=@DivisionID " +
                "WHERE DivisionID = @id";

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlCheck, connection);

                //Delete This Division from HeadDivision
                SqlParameter HeadDiv = new("@HeadDiv", DBNull.Value);
                command.Parameters.Add(HeadDiv);

                SqlParameter Id = new("@id", id);
                command.Parameters.Add(Id);

                command.ExecuteNonQuery();

                //Delete this Division from Employee
                command = new(sqlEmployee, connection);
                SqlParameter DivisionID = new("@DivisionID", DBNull.Value);
                command.Parameters.Add(DivisionID);

                Id = new("@id", id);
                command.Parameters.Add(Id);

                command.ExecuteNonQuery();
                //Final Delete
                command = new(sqlComa, connection);

                Id = new("@id", id);
                command.Parameters.Add(Id);

                command.ExecuteNonQuery();
            }
        }

        public int GetDivisionByName(string name)
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "SELECT Id FROM Divisions WHERE DivisionName = @name";

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlComa, connection);

                SqlParameter DivisionName = new("@name", name);
                command.Parameters.Add(DivisionName);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return (int)reader.GetValue(0);
                    }
                }
                reader.Close();
            }

            return 0;
        }

        public bool HaveDivision(string division)
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "SELECT * FROM Divisions WHERE DivisionName = @division";

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlComa, connection);

                SqlParameter Divisions = new("@division", division);
                command.Parameters.Add(Divisions);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                reader.Close();
            }

            return false;
        }
    }
}
