using ApiRedarbor.Interfaces;
using ApiRedarbor.Modelos;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ApiRedarbor.Logica
{
    public class EmployeeLogica : IEmployee
    {
        private readonly string ConnectionStrings = Configuracion.AppSetting["ConnectionStrings:Connection"];

        public Response GetEmployees()
        {
            string spGetEmployees = "EXECUTE [dbo].[SP_GetEmployees]";
            Response response = new();
            List<Employee> employees = new();

            try
            {
                using SqlConnection connection = new(ConnectionStrings);
                SqlCommand command = new(spGetEmployees, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = new()
                    {
                        CompanyId = (int)reader["CompanyId"],
                        CreatedOn = reader["CreatedOn"].ToString(),
                        DeletedOn = reader["DeletedOn"].ToString(),
                        Email = reader["Email"].ToString(),
                        Fax = reader["Fax"].ToString(),
                        Name = reader["Name"].ToString(),
                        Lastlogin = reader["Lastlogin"].ToString(),
                        Password = reader["Password"].ToString(),
                        PortalId = (int)reader["PortalId"],
                        RoleId = (int)reader["RoleId"],
                        StatusId = (int)reader["StatusId"],
                        Telephone = reader["Telephone"].ToString(),
                        UpdatedOn = reader["UpdatedOn"].ToString(),
                        Username = reader["Username"].ToString()
                    };
                    employees.Add(employee);
                }

                reader.Close();
                connection.Close();

                response.Data = employees;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public Response GetEmployee(int id)
        {
            string spGetEmployee = "[dbo].[SP_GetEmployee]";
            Response response = new();
            Employee employee = new();

            try
            {
                using SqlConnection connection = new(ConnectionStrings);
                SqlCommand command = new(spGetEmployee, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.Add(new SqlParameter("@EmployeeId", id));
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    employee = new()
                    {
                        CompanyId = (int)reader["CompanyId"],
                        CreatedOn = reader["CreatedOn"].ToString(),
                        DeletedOn = reader["DeletedOn"].ToString(),
                        Email = reader["Email"].ToString(),
                        Fax = reader["Fax"].ToString(),
                        Name = reader["Name"].ToString(),
                        Lastlogin = reader["Lastlogin"].ToString(),
                        Password = reader["Password"].ToString(),
                        PortalId = (int)reader["PortalId"],
                        RoleId = (int)reader["RoleId"],
                        StatusId = (int)reader["StatusId"],
                        Telephone = reader["Telephone"].ToString(),
                        UpdatedOn = reader["UpdatedOn"].ToString(),
                        Username = reader["Username"].ToString()
                    };
                }

                reader.Close();
                connection.Close();

                response.Data = employee;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public Response PostEmployee(Employee employee)
        {
            string spPostEmployee = "[dbo].[SP_PostEmployee]";
            Response response = new();

            try
            {
                using SqlConnection connection = new(ConnectionStrings);
                SqlCommand command = new(spPostEmployee, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.Add(new SqlParameter("@CompanyId", employee.CompanyId));
                command.Parameters.Add(new SqlParameter("@CreatedOn", Convert.ToDateTime(employee.CreatedOn)));
                command.Parameters.Add(new SqlParameter("@DeletedOn", Convert.ToDateTime(employee.DeletedOn)));
                command.Parameters.Add(new SqlParameter("@Email", employee.Email));
                command.Parameters.Add(new SqlParameter("@Fax", employee.Fax));
                command.Parameters.Add(new SqlParameter("@Name", employee.Name));
                command.Parameters.Add(new SqlParameter("@Lastlogin", Convert.ToDateTime(employee.Lastlogin)));
                command.Parameters.Add(new SqlParameter("@Password", employee.Password));
                command.Parameters.Add(new SqlParameter("@PortalId", employee.PortalId));
                command.Parameters.Add(new SqlParameter("@RoleId", employee.RoleId));
                command.Parameters.Add(new SqlParameter("@StatusId", employee.StatusId));
                command.Parameters.Add(new SqlParameter("@Telephone", employee.Telephone));
                command.Parameters.Add(new SqlParameter("@UpdatedOn", Convert.ToDateTime(employee.UpdatedOn)));
                command.Parameters.Add(new SqlParameter("@Username", employee.Username));
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                response.Data = employee;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public Response PutEmployee(int id, Employee employee)
        {
            string spPostEmployee = "[dbo].[SP_PutEmployee]";
            Response response = new();

            try
            {
                using SqlConnection connection = new(ConnectionStrings);
                SqlCommand command = new(spPostEmployee, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.Add(new SqlParameter("@EmployeeId", id));
                command.Parameters.Add(new SqlParameter("@CompanyId", employee.CompanyId));
                command.Parameters.Add(new SqlParameter("@CreatedOn", Convert.ToDateTime(employee.CreatedOn)));
                command.Parameters.Add(new SqlParameter("@DeletedOn", Convert.ToDateTime(employee.DeletedOn)));
                command.Parameters.Add(new SqlParameter("@Email", employee.Email));
                command.Parameters.Add(new SqlParameter("@Fax", employee.Fax));
                command.Parameters.Add(new SqlParameter("@Name", employee.Name));
                command.Parameters.Add(new SqlParameter("@Lastlogin", Convert.ToDateTime(employee.Lastlogin)));
                command.Parameters.Add(new SqlParameter("@Password", employee.Password));
                command.Parameters.Add(new SqlParameter("@PortalId", employee.PortalId));
                command.Parameters.Add(new SqlParameter("@RoleId", employee.RoleId));
                command.Parameters.Add(new SqlParameter("@StatusId", employee.StatusId));
                command.Parameters.Add(new SqlParameter("@Telephone", employee.Telephone));
                command.Parameters.Add(new SqlParameter("@UpdatedOn", Convert.ToDateTime(employee.UpdatedOn)));
                command.Parameters.Add(new SqlParameter("@Username", employee.Username));
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public Response DeleteEmployee(int id)
        {
            var spDeleteEmployee = "[dbo].[SP_DeleteEmployee]";
            Response response = new();

            try
            {
                using SqlConnection connection = new(ConnectionStrings);
                SqlCommand command = new(spDeleteEmployee, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.Add(new SqlParameter("@EmployeeId", id));
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
