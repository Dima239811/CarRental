using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Configuration;


namespace CarRental
{
    public class ClientManager
    {
        private SqlConnection sqlConnection = null;

        // строка подключения из конфига
        private string sqlConnectionPath = ConfigurationManager.ConnectionStrings["RentalCarsDB"].ConnectionString;

        // SQL - команда для вставки клиента
        private string query1 = "INSERT INTO [client_table] (name, email, phonenumber) VALUES (@name, @email, @phonenumber)";

        // запрос получения всей таблицы из бд
        private string query2 = "SELECT * FROM client_table";

        // SQL-запрос для получения последнего добавленного клиента
        private string queryGetLastClient = "SELECT TOP 1 * FROM client_table ORDER BY ClientId DESC";

        // SQL-запрос для удаления клиента по ID
        private string query = "DELETE FROM client_table WHERE ClientId = @clientId";

        public ClientManager() { }

        // Метод для добавления клиента
        public void AddClientToDB(Client client)
        {
            using (sqlConnection = new SqlConnection(sqlConnectionPath))
            {
                try
                {    
                    sqlConnection.Open();  // Открываем соединение

                    using (SqlCommand command = new SqlCommand(query1, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@name", client.Name);
                        command.Parameters.AddWithValue("@email", client.Email);
                        command.Parameters.AddWithValue("@phonenumber", client.PhoneNumber);

                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }

        //// метод получения всех клиентов из бд
        public List<Client> getAllClients()
        {
            SqlDataReader dataReader = null;
            List<Client> clients = new List<Client>();  // список всех клиентов из бд
            using (sqlConnection = new SqlConnection(sqlConnectionPath))
            {
                try
                {
                    sqlConnection.Open();
                    Client client = null;

                    using (SqlCommand command = new SqlCommand(query2, sqlConnection))
                    {
                        dataReader = command.ExecuteReader();

                        while (dataReader.Read())
                        {
                            client = new Client()
                            {
                                Name = Convert.ToString(dataReader["name"]),
                                Email = Convert.ToString(dataReader["email"]),
                                PhoneNumber = Convert.ToString(dataReader["phonenumber"]),
                                Id = Convert.ToInt32(dataReader["ClientId"])
                            };
                            clients.Add(client);
                        }
                    }
                    sqlConnection.Close();
                    return clients;
                }
                catch (Exception ex)
                {
                    return clients;
                }
                finally
                {
                    if (dataReader != null && !dataReader.IsClosed)
                    {
                        dataReader.Close();
                    }
                }
            }
        }

        // метод удаления клиента из БД
        public void removeClientFromDB(int clientId)
        {
            using (sqlConnection = new SqlConnection(sqlConnectionPath))
            {
                try
                {
                    sqlConnection.Open();

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@clientId", clientId); // Добавляем параметр для предотвращения SQL-инъекций

                        int rowsAffected = command.ExecuteNonQuery(); // Выполняем запрос на удаление

                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }

        // Метод для получения последнего добавленного клиента из БД
        public Client GetLastClientFromDB()
        {
            SqlDataReader dataReader = null;
            Client lastClient = null;

            using (sqlConnection = new SqlConnection(sqlConnectionPath))
            {
                try
                {
                    sqlConnection.Open();          

                    using (SqlCommand command = new SqlCommand(queryGetLastClient, sqlConnection))
                    {
                        dataReader = command.ExecuteReader();

                        if (dataReader.Read())
                        {
                            lastClient = new Client
                            {
                                Id = Convert.ToInt32(dataReader["ClientId"]),
                                Name = dataReader["name"].ToString(),
                                Email = dataReader["email"].ToString(),
                                PhoneNumber = dataReader["phonenumber"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
                finally
                {
                    if (dataReader != null && !dataReader.IsClosed)
                    {
                        dataReader.Close(); // Закрываем DataReader
                    }
                }
            }

            return lastClient; // Возвращаем последнего добавленного клиента или null, если не найден
        }
    }
}
