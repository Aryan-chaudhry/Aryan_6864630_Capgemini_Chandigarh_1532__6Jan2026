using System.Data;
using Microsoft.Data.SqlClient;

namespace ADODOTNETCoreDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // setup db connection
                string connectionString = "Data Source=DESKTOP-DB8HM32\\SQLEXPRESS; Initial Catalog=EMPLOYEEDB; TrustServerCertificate=True; Integrated Security=True";

                // calling getAllEmployee   
                GetAllEmployee(connectionString);

                // calling get employee by id
                Console.Write("Enter Employee Id : ");
                int id = Convert.ToInt32(Console.ReadLine());

                GetEmployeeById(connectionString, id);

				string firstname = "Ramesh";
				string lastname = "Sharma";
				string email = "Ramesh@Example.com";
				string street = "123 Patia";
				string city = "BBSR";
				string state = "India";
				string postalcode = "755019";
				

                CreateEmployeeWithAddress(connectionString, firstname, lastname, email, street, city, state, postalcode);

				// calling updateEmployeewithAddress;
				int employeeID = 3;
                firstname = "Ramesh";
                lastname = "Sharma";
                email = "Ramesh@Example.com";
                street = "123 Patia";
                city = "BBSR";
                state = "India";
                postalcode = "755019";
                int addressId = 3;

                UpdateEmployeeWithAddress(connectionString, employeeID, firstname, lastname, email, street, city, state, postalcode, addressId);



			}
            catch(Exception ex)
            {
                Console.WriteLine("Exception Occured : " + ex.Message); 
            }

            static void GetAllEmployee(string connectionString)
            {
                Console.WriteLine("GetAllEmployee Stored Procedure Called");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("GetAllEmployee", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"EmployeeID : {reader["employeeID"]}," + 
                            $" FirstName : {reader["firstname"]}, LastName : {reader["lastname"]}, Email : {reader["email"]}");

                        Console.WriteLine($"Address : {reader["street"]}, {reader["city"]}, {reader["state"]}, PostalCode : {reader["postalcode"]} ");
                    }
                    Console.WriteLine("\n");
                    reader.Close();
                    connection.Close();
                }
            }

            static void GetEmployeeById(string connectionString, int employeeID)
            {
                Console.WriteLine("GetEmployeeById StoredProcedure called");
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("GetEmployeeById", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeId", employeeID);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"FirstName : {reader["firstname"]} \n" +
                            $"LastName : {reader["lastname"]} \n" +
                            $"Email : {reader["email"]} \n" +
                            $"Address : {reader["street"]} {reader["city"]} {reader["state"]} PostalCode : {reader["postalcode"]} ");
                    }
                    Console.WriteLine("\n");
                    reader.Close();
                    connection.Close();
                }
            }

			static void CreateEmployeeWithAddress(string connectionString, string firstname,
				string lastname, string email, string street, string city, string state, string postalcode)
			{
				Console.WriteLine("CreateEmployeeWithAddress stored Procedure called");
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					SqlCommand command = new SqlCommand("CreateEmployeeWithAddress", connection);
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@FirstName", firstname);
					command.Parameters.AddWithValue("@LastName", lastname);
					command.Parameters.AddWithValue("@Email", email);
					command.Parameters.AddWithValue("@Street", street);
					command.Parameters.AddWithValue("@City", city);
					command.Parameters.AddWithValue("@State", state);
					command.Parameters.AddWithValue("@PostalCode", postalcode);

					connection.Open();
					command.ExecuteNonQuery();
					Console.WriteLine("Employee and Address created Successfully");
					connection.Close();
				}
			}

			static void UpdateEmployeeWithAddress(string connectionString, int employeeID, string firstname, 
                string lastname, string email, string street, string city, string state, string postalcode, int addressId)
            {
                Console.WriteLine("UpdateEmployeeWithAddress stored Procedure called");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("UpdateEmployeeWithAddress", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeId", employeeID);
					command.Parameters.AddWithValue("@FirstName", firstname);
					command.Parameters.AddWithValue("@LastName", lastname);
					command.Parameters.AddWithValue("@Email", email);
					command.Parameters.AddWithValue("@Street", street);
					command.Parameters.AddWithValue("@City", city);
					command.Parameters.AddWithValue("@State", state);
					command.Parameters.AddWithValue("@PostalCode", postalcode);
					command.Parameters.AddWithValue("@AddressID", addressId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Employee and Address updated Successfully \n");
                    connection.Close();
				}
            }

            static void DeleteEmployee(string connectionString, int employeeID)
            {
                Console.WriteLine("DeleteEmployee stored procedure called");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("DeleteEmployee", connection);
                }
            }

		}
    }
}
