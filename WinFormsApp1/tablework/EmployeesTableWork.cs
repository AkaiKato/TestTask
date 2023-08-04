using System.Collections.Generic;
using System.Data.SqlClient;
using WinFormsApp1.database;
using WinFormsApp1.models;

namespace WinFormsApp1.tablework
{
    public class EmployeesTableWork
    {
        public List<Employees> GetAllEmployees()
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "SELECT * FROM CompanyEmployees";

            List<Employees> list = new();

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlComa, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(new Employees
                        {
                            Id = (int)reader.GetValue(0),
                            FullName = (string)reader.GetValue(1),
                            ServiceNumber = (string)reader.GetValue(2),
                            Position = (string)reader.GetValue(3),
                            Division = reader.GetValue(4) is DBNull ? 0 : (int)reader.GetValue(4),
                            Email = (string)reader.GetValue(5),
                            Number = (string)reader.GetValue(6),
                            DateOfAppointment = (DateTime)reader.GetValue(7),
                            DateOfDismissal = reader.GetValue(8) is DBNull ? null : (DateTime)reader.GetValue(8),
                            Status = (int)reader.GetValue(9),
                        });
                    }
                }
                reader.Close();
            }

            return list;
        }

        public List<TransferObject> GetEmployeeIdNames()
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "SELECT Id, FullName FROM CompanyEmployees";

            List<TransferObject> result = new();

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlComa, connection);
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

        public string GetEmployeeNameById(int id)
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "SELECT FullName FROM CompanyEmployees WHERE Id = @id";

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

        public Employees GetEmployeeById(int id)
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "SELECT * FROM CompanyEmployees WHERE Id = @id";

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
                        return new Employees
                        {
                            Id = (int)reader.GetValue(0),
                            FullName = (string)reader.GetValue(1),
                            ServiceNumber = (string)reader.GetValue(2),
                            Position = (string)reader.GetValue(3),
                            Division = reader.GetValue(4) is DBNull ? 0 : (int)reader.GetValue(4),
                            Email = (string)reader.GetValue(5),
                            Number = (string)reader.GetValue(6),
                            DateOfAppointment = (DateTime)reader.GetValue(7),
                            DateOfDismissal = reader.GetValue(8) is DBNull ? null : (DateTime)reader.GetValue(8),
                            Status = (int)reader.GetValue(9),
                        };
                    }
                }
                reader.Close();
            }

            return new Employees();
        }

        public void CreateEmployee(Employees employees)
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "INSERT INTO CompanyEmployees " +
                "(FullName, ServiceNumber, Position, DivisionID, Email, Number, DateOfAppointment, StatusOfAccount)" +
                "VALUES (@FullName, @ServiceNumber, @Position, @DivisionID, @Email, @Number, @DateOfAppointment, @StatusOfAccount)";

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlComa, connection);

                SqlParameter FullName = new("@FullName", employees.FullName);
                command.Parameters.Add(FullName);

                SqlParameter ServiceNumber = new("@ServiceNumber", employees.ServiceNumber);
                command.Parameters.Add(ServiceNumber);

                SqlParameter Position = new("@Position", employees.Position);
                command.Parameters.Add(Position);

                SqlParameter DivisionID = new("@DivisionID", employees.Division);
                command.Parameters.Add(DivisionID);

                SqlParameter Email = new("@Email", employees.Email);
                command.Parameters.Add(Email);

                SqlParameter Number = new("@Number", employees.Number);
                command.Parameters.Add(Number);

                SqlParameter DateOfAppointment = new("@DateOfAppointment", employees.DateOfAppointment);
                command.Parameters.Add(DateOfAppointment);

                SqlParameter StatusOfAccount = new("@StatusOfAccount", employees.Status);
                command.Parameters.Add(StatusOfAccount);

                command.ExecuteNonQuery();
            }
        }

        public void CreateEmployeeExcel(Employees employees)
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "INSERT INTO CompanyEmployees " +
                "(FullName, ServiceNumber, Position, DivisionID, Email, Number, DateOfAppointment, DateOfDismissal, StatusOfAccount)" +
                "VALUES (@FullName, @ServiceNumber, @Position, @DivisionID, @Email, @Number, @DateOfAppointment, @DateOfDismissal, @StatusOfAccount)";

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlComa, connection);

                SqlParameter FullName = new("@FullName", employees.FullName);
                command.Parameters.Add(FullName);

                SqlParameter ServiceNumber = new("@ServiceNumber", employees.ServiceNumber);
                command.Parameters.Add(ServiceNumber);

                SqlParameter Position = new("@Position", employees.Position);
                command.Parameters.Add(Position);

                SqlParameter DivisionID = new("@DivisionID", employees.Division);
                command.Parameters.Add(DivisionID);

                SqlParameter Email = new("@Email", employees.Email);
                command.Parameters.Add(Email);

                SqlParameter Number = new("@Number", employees.Number);
                command.Parameters.Add(Number);

                SqlParameter DateOfAppointment = new("@DateOfAppointment", employees.DateOfAppointment);
                command.Parameters.Add(DateOfAppointment);

                SqlParameter DateOfDismissal = new("@DateOfDismissal", DBNull.Value);
                if(employees.DateOfDismissal != null)
                    DateOfDismissal = new("@DateOfDismissal", employees.DateOfDismissal);
                command.Parameters.Add(DateOfDismissal);

                SqlParameter StatusOfAccount = new("@StatusOfAccount", employees.Status);
                command.Parameters.Add(StatusOfAccount);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateEmployee(Employees employee)
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "UPDATE CompanyEmployees " +
                "SET FullName=@FullName," +
                "ServiceNumber=@ServiceNumber," +
                "Position=@Position," +
                "DivisionID=@DivisionID, " +
                "Email=@Email, " +
                "Number=@Number, " +
                "DateOfAppointment=@DateOfAppointment, " +
                "StatusOfAccount=@StatusOfAccount " +
                "WHERE Id=@id";

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlComa, connection);

                SqlParameter FullName = new("@FullName", employee.FullName);
                command.Parameters.Add(FullName);

                SqlParameter ServiceNumber = new("@ServiceNumber", employee.ServiceNumber);
                command.Parameters.Add(ServiceNumber);

                SqlParameter Position = new("@Position", employee.Position);
                command.Parameters.Add(Position);

                SqlParameter DivisionID = new("@DivisionID", DBNull.Value);
                if (employee.Division != 0)
                    DivisionID = new SqlParameter("@DivisionID", employee.Division);
                command.Parameters.Add(DivisionID);

                SqlParameter Email = new("@Email", employee.Email);
                command.Parameters.Add(Email);

                SqlParameter Number = new("@Number", employee.Number);
                command.Parameters.Add(Number);

                SqlParameter DateOfAppointment = new("@DateOfAppointment", employee.DateOfAppointment);
                command.Parameters.Add(DateOfAppointment);

                SqlParameter StatusOfAccount = new("@StatusOfAccount", employee.Status);
                command.Parameters.Add(StatusOfAccount);

                SqlParameter Id = new("@id", employee.Id);
                command.Parameters.Add(Id);

                command.ExecuteNonQuery();
            }
        }

        public void FireEmployee(Employees employee)
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "UPDATE CompanyEmployees " +
                "SET DateOfDismissal=@DateOfDismissal," +
                "StatusOfAccount=@StatusOfAccount " +
                "WHERE Id=@id";
            string sqlDivision = "UPDATE Divisions " +
                "SET Manager = @Manager " +
                "WHERE Manager = @id";

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlDivision, connection);

                SqlParameter Manager = new("@Manager", DBNull.Value);
                command.Parameters.Add(Manager);

                SqlParameter Id = new("@id", employee.Id);
                command.Parameters.Add(Id);

                command.ExecuteNonQuery();

                command = new(sqlComa, connection);

                SqlParameter DateOfDismissal = new("@DateOfDismissal", employee.DateOfDismissal);
                command.Parameters.Add(DateOfDismissal);

                SqlParameter StatusOfAccount = new("@StatusOfAccount", employee.Status);
                command.Parameters.Add(StatusOfAccount);

                Id = new("@id", employee.Id);
                command.Parameters.Add(Id);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(int id)
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "DELETE FROM CompanyEmployees WHERE Id = @id";
            string sqlCheck = "UPDATE Divisions " +
                "SET Manager = @Manager " +
                "WHERE Manager = @id";

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlCheck, connection);

                //Delete This Managet from Division
                SqlParameter Manager = new("@Manager", DBNull.Value);
                command.Parameters.Add(Manager);

                SqlParameter Id = new("@id", id);
                command.Parameters.Add(Id);

                command.ExecuteNonQuery();

                //Final Delete
                command = new(sqlComa, connection);

                Id = new("@id", id);
                command.Parameters.Add(Id);

                command.ExecuteNonQuery();
            }
        }

        public List<Employees> SearchEmployees(string searchString)
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "SELECT * FROM CompanyEmployees WHERE (FullName LIKE '%' + @searchString + '%') OR (ServiceNumber LIKE '%' + @searchString + '%')";
            
            List<Employees> list = new();

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlComa, connection);

                SqlParameter SearchString = new("@searchString", searchString);
                command.Parameters.Add(SearchString);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(new Employees
                        {
                            Id = (int)reader.GetValue(0),
                            FullName = (string)reader.GetValue(1),
                            ServiceNumber = (string)reader.GetValue(2),
                            Position = (string)reader.GetValue(3),
                            Division = reader.GetValue(4) is DBNull ? 0 : (int)reader.GetValue(4),
                            Email = (string)reader.GetValue(5),
                            Number = (string)reader.GetValue(6),
                            DateOfAppointment = (DateTime)reader.GetValue(7),
                            DateOfDismissal = reader.GetValue(8) is DBNull ? null : (DateTime)reader.GetValue(8),
                            Status = (int)reader.GetValue(9),
                        });
                    }
                }
                reader.Close();
                
                return list;
            }
        }

        public List<Employees> GetAllDivisionEmployees(int divId)
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "SELECT * FROM CompanyEmployees WHERE DivisionID = @divId";

            List<Employees> list = new();

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlComa, connection);
                SqlParameter DivId = new("@divId", divId);
                command.Parameters.Add(DivId);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(new Employees
                        {
                            Id = (int)reader.GetValue(0),
                            FullName = (string)reader.GetValue(1),
                            ServiceNumber = (string)reader.GetValue(2),
                            Position = (string)reader.GetValue(3),
                            Division = reader.GetValue(4) is DBNull ? 0 : (int)reader.GetValue(4),
                            Email = (string)reader.GetValue(5),
                            Number = (string)reader.GetValue(6),
                            DateOfAppointment = (DateTime)reader.GetValue(7),
                            DateOfDismissal = reader.GetValue(8) is DBNull ? null : (DateTime)reader.GetValue(8),
                            Status = (int)reader.GetValue(9),
                        });
                    }
                }
                reader.Close();
            }
            return list;
        }

        public List<Employees> GetStatAppointmentEmployees(DateTime startTime, DateTime endTime, int statDiv)
        {
            string connectionString = DbConnection.SQLConnectionString;
            
            string sqlComa = statDiv == 0 
                ? "SELECT * FROM CompanyEmployees WHERE DateOfAppointment >= @StartTime AND DateOfAppointment <= @EndTime"
                : "SELECT * FROM CompanyEmployees WHERE DateOfAppointment >= @StartTime AND DateOfAppointment <= @EndTime AND DivisionID = @StatDiv";

            List<Employees> list = new();

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlComa, connection);

                SqlParameter StartTime = new("@StartTime", startTime);
                command.Parameters.Add(StartTime);

                SqlParameter EndTime = new("@EndTime", endTime);
                command.Parameters.Add(EndTime);

                if (statDiv != 0)
                {
                    SqlParameter StatDiv = new("@StatDiv", statDiv);
                    command.Parameters.Add(StatDiv);
                }

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(new Employees
                        {
                            Id = (int)reader.GetValue(0),
                            FullName = (string)reader.GetValue(1),
                            ServiceNumber = (string)reader.GetValue(2),
                            Position = (string)reader.GetValue(3),
                            Division = reader.GetValue(4) is DBNull ? 0 : (int)reader.GetValue(4),
                            Email = (string)reader.GetValue(5),
                            Number = (string)reader.GetValue(6),
                            DateOfAppointment = (DateTime)reader.GetValue(7),
                            DateOfDismissal = reader.GetValue(8) is DBNull ? null : (DateTime)reader.GetValue(8),
                            Status = (int)reader.GetValue(9),
                        });
                    }
                }
                reader.Close();
            }
            return list;
        }

        public List<Employees> GetStatFireEmployees(DateTime startTime, DateTime endTime, int statDiv)
        {
            string connectionString = DbConnection.SQLConnectionString;

            string sqlComa = statDiv == 0
                ? "SELECT * FROM CompanyEmployees WHERE DateOfDismissal >= @StartTime AND DateOfDismissal <= @EndTime"
                : "SELECT * FROM CompanyEmployees WHERE DateOfDismissal >= @StartTime AND DateOfDismissal <= @EndTime AND DivisionID = @StatDiv";

            List<Employees> list = new();

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlComa, connection);

                SqlParameter StartTime = new("@StartTime", startTime);
                command.Parameters.Add(StartTime);

                SqlParameter EndTime = new("@EndTime", endTime);
                command.Parameters.Add(EndTime);

                if (statDiv != 0)
                {
                    SqlParameter StatDiv = new("@StatDiv", statDiv);
                    command.Parameters.Add(StatDiv);
                }

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(new Employees
                        {
                            Id = (int)reader.GetValue(0),
                            FullName = (string)reader.GetValue(1),
                            ServiceNumber = (string)reader.GetValue(2),
                            Position = (string)reader.GetValue(3),
                            Division = reader.GetValue(4) is DBNull ? 0 : (int)reader.GetValue(4),
                            Email = (string)reader.GetValue(5),
                            Number = (string)reader.GetValue(6),
                            DateOfAppointment = (DateTime)reader.GetValue(7),
                            DateOfDismissal = reader.GetValue(8) is DBNull ? null : (DateTime)reader.GetValue(8),
                            Status = (int)reader.GetValue(9),
                        });
                    }
                }
                reader.Close();
            }
            return list;
        }

        public bool HaveServiceNumber(string serviceNumber)
        {
            string connectionString = DbConnection.SQLConnectionString;
            string sqlComa = "SELECT * FROM CompanyEmployees WHERE ServiceNumber = @serviceNumber";

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                SqlCommand command = new(sqlComa, connection);

                SqlParameter ServiceNumber = new("@serviceNumber", serviceNumber);
                command.Parameters.Add(ServiceNumber);

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
