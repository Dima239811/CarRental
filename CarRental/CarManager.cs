using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CarRental
{
    public class CarManager
    {
        private SqlConnection sqlConnection = null;

        // строка подключения из конфига
        private string sqlConnectionPath = ConfigurationManager.ConnectionStrings["RentalCarsDB"].ConnectionString;

        // SQL - команда для добавления машины в бд
        private string queryInsertCar = "INSERT INTO [car_table] (brand, model, year, licensePlate, dailyRate, isAvailable) VALUES (@brand, @model, @year, @licensePlate, @dailyRate, @isAvailable)";

        // запрос получения всей таблицы из бд
        private string queryGetAllCars = "SELECT * FROM car_table";

        // запрос на удаление машины из бд
        private string queryDeleteCar = "DELETE FROM car_table WHERE CarId = @id";

        // SQL-запрос для получения последнего добавленного автомобиля
        private string queryGetLastCar = "SELECT TOP 1 * FROM car_table ORDER BY CarId DESC";

        // SQL-запрос для обновления статуса автомобиля
        private string queryUpdateCarAvailability = "UPDATE car_table SET isAvailable = @isAvailable WHERE CarId = @id";
        public CarManager() { }

        // Метод для добавления автомобиля в БД
        public void AddCarToDB(Car car)
        {
            using (sqlConnection = new SqlConnection(sqlConnectionPath))    // Создание подключения к базе данных
            {
                sqlConnection.Open();                                       // Открытие подключения
                using (SqlCommand command = new SqlCommand(queryInsertCar, sqlConnection))
                {
                    command.Parameters.AddWithValue("@brand", car.Brand);   // Добавление параметров к команде запроса в БД
                    command.Parameters.AddWithValue("@model", car.Model);
                    command.Parameters.AddWithValue("@year", car.Year);
                    command.Parameters.AddWithValue("@licensePlate", car.LicensePlate);
                    command.Parameters.AddWithValue("@dailyRate", car.DailyRate);
                    command.Parameters.AddWithValue("@isAvailable", car.IsAvailable);

                    command.ExecuteNonQuery();                              // Выполнение команды
                }
            }
        }

        // Метод для получения всех автомобилей из БД
        public List<Car> GetAllCarsFromDB()
        {
            SqlDataReader dataReader = null;    // переменная для чтения данных из базы данных
            List<Car> cars = new List<Car>();   // список всех авто, полученных из БД
            using (sqlConnection = new SqlConnection(sqlConnectionPath))
            {
                try
                {
                    // Открываем соединение
                    sqlConnection.Open();

                    using (SqlCommand command = new SqlCommand(queryGetAllCars, sqlConnection))
                    {
                        dataReader = command.ExecuteReader();   // построчно читаем данные, возвращенные запросом.

                        while (dataReader.Read())
                        {
                            var car = new Car
                            {
                                Id = Convert.ToInt32(dataReader["CarId"]),
                                Brand = dataReader["brand"].ToString(),
                                Model = dataReader["model"].ToString(),
                                Year = Convert.ToInt32(dataReader["year"]),
                                LicensePlate = dataReader["licensePlate"].ToString(),
                                DailyRate = Convert.ToDouble(dataReader["dailyRate"]),
                                IsAvailable = Convert.ToBoolean(dataReader["isAvailable"])
                            };
                            cars.Add(car);
                        }
                    }
                    sqlConnection.Close();  // закрываем соединение с базой
                    return cars;
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    return cars; // Возвращаем пустой список в случае ошибки
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

        // Метод для удаления автомобиля по ID
        public void RemoveCarFromDB(int carId)
        {
            using (sqlConnection = new SqlConnection(sqlConnectionPath))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(queryDeleteCar, sqlConnection))
                {
                    command.Parameters.AddWithValue("@id", carId);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Метод для получения последнего добавленного автомобиля из БД
        public Car GetLastCarFromDB()
        {
            SqlDataReader dataReader = null;
            Car lastCar = null;

            using (sqlConnection = new SqlConnection(sqlConnectionPath))
            {
                try
                {
                    // Открываем соединение
                    sqlConnection.Open();

                    using (SqlCommand command = new SqlCommand(queryGetLastCar, sqlConnection))
                    {
                        dataReader = command.ExecuteReader();

                        if (dataReader.Read())
                        {
                            lastCar = new Car
                            {
                                Id = Convert.ToInt32(dataReader["CarId"]),
                                Brand = dataReader["brand"].ToString(),
                                Model = dataReader["model"].ToString(),
                                Year = Convert.ToInt32(dataReader["year"]),
                                LicensePlate = dataReader["licensePlate"].ToString(),
                                DailyRate = Convert.ToDouble(dataReader["dailyRate"]),
                                IsAvailable = Convert.ToBoolean(dataReader["isAvailable"])
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

            return lastCar; // Возвращаем последний добавленный автомобиль или null, если не найден
        }

        // Метод для обновления состояния автомобиля по ID
        public void UpdateCarAvailability(int carId, bool isAvailable)
        {
            using (sqlConnection = new SqlConnection(sqlConnectionPath))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(queryUpdateCarAvailability, sqlConnection))
                {
                    command.Parameters.AddWithValue("@isAvailable", isAvailable);
                    command.Parameters.AddWithValue("@id", carId);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        throw new Exception("Автомобиль не найден."); // Если не найдено ни одной строки
                    }
                }
            }
        }
    }
}
