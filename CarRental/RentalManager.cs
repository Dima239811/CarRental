using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Configuration;


namespace CarRental
{
    public class RentalManager
    {
        public RentalManager() { }

        private SqlConnection sqlConnection = null;

        // строка подключения из конфига
        private string sqlConnectionPath = ConfigurationManager.ConnectionStrings["RentalCarsDB"].ConnectionString;

        // SQL - команда для вставки клиента
        private string queryInsertRental = "INSERT INTO [rental_table] (CarId, ClientId, StartDate, EndDate, TotalPrice) VALUES (@CarId, @ClientId, @StartDate, @EndDate, @TotalPrice)";

        // запрос получения всей таблицы из бд
        private string queryGetAllRentals = "SELECT * FROM rental_table";

        // запрос на удаление машины из бд
        private string queryDeleteRental = "DELETE FROM rental_table WHERE RentalId = @id";

        // SQL-запрос для получения последнего добавленного автомобиля
        private string queryGetLastRental = "SELECT TOP 1 * FROM rental_table ORDER BY RentalId DESC";

        // Метод для добавления аренды в БД
        public void AddRentalToDB(Rental rental)
        {
            using (sqlConnection = new SqlConnection(sqlConnectionPath))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(queryInsertRental, sqlConnection))
                {
                    command.Parameters.AddWithValue("@CarId", rental.CarId);
                    command.Parameters.AddWithValue("@ClientId", rental.ClientId);
                    command.Parameters.AddWithValue("@StartDate", rental.StartDate);
                    command.Parameters.AddWithValue("@EndDate", rental.EndDate);
                    command.Parameters.AddWithValue("@TotalPrice", rental.TotalPrice);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Метод для получения всех аренды из БД
        public List<Rental> GetAllRentalsFromDB()
        {
            SqlDataReader dataReader = null;
            List<Rental> rentals = new List<Rental>();

            using (sqlConnection = new SqlConnection(sqlConnectionPath))
            {
                try
                {
                    sqlConnection.Open();

                    using (SqlCommand command = new SqlCommand(queryGetAllRentals, sqlConnection))
                    {
                        dataReader = command.ExecuteReader();

                        while (dataReader.Read())
                        {
                            var rental = new Rental
                            {
                                RentalId = Convert.ToInt32(dataReader["RentalId"]),
                                CarId = Convert.ToInt32(dataReader["CarId"]),
                                ClientId = Convert.ToInt32(dataReader["ClientId"]),
                                StartDate = Convert.ToDateTime(dataReader["StartDate"]),
                                EndDate = Convert.ToDateTime(dataReader["EndDate"]),
                                TotalPrice = Convert.ToDouble(dataReader["TotalPrice"])
                            };
                            rentals.Add(rental);
                        }
                    }
                    sqlConnection.Close();
                    return rentals;
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    return rentals; // Возвращаем пустой список в случае ошибки
                }
                finally
                {
                    if (dataReader != null && !dataReader.IsClosed)
                    {
                        dataReader.Close(); // Закрываем DataReader
                    }
                }
            }

        }

        // Метод для удаления аренды по ID
        public void RemoveRentalFromDB(int rentalId)
        {
            using (sqlConnection = new SqlConnection(sqlConnectionPath))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(queryDeleteRental, sqlConnection))
                {
                    command.Parameters.AddWithValue("@id", rentalId);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Метод для получения последней добавленной аренды из БД
        public Rental GetLastRentalFromDB()
        {
            SqlDataReader dataReader = null;
            Rental lastRental = null;

            using (sqlConnection = new SqlConnection(sqlConnectionPath))
            {
                try
                {
                    // Открываем соединение
                    sqlConnection.Open();

                    using (SqlCommand command = new SqlCommand(queryGetLastRental, sqlConnection))
                    {
                        dataReader = command.ExecuteReader();

                        if (dataReader.Read())
                        {
                            lastRental = new Rental
                            {
                                RentalId = Convert.ToInt32(dataReader["RentalId"]),
                                CarId = Convert.ToInt32(dataReader["CarId"]),
                                ClientId = Convert.ToInt32(dataReader["ClientId"]),
                                StartDate = Convert.ToDateTime(dataReader["StartDate"]),
                                EndDate = Convert.ToDateTime(dataReader["EndDate"]),
                                TotalPrice = Convert.ToDouble(dataReader["TotalPrice"])
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

            return lastRental; // Возвращаем последнюю добавленную аренду или null, если не найдено
        }

    }
}
