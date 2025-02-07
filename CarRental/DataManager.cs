using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CarRental
{
    public class DataManager
    {
        private ClientManager _clientManager;
        private CarManager _carManager; 
        private RentalManager _rentalManager;

        private ClientCol clientcol;
        private CarCol carcol;
        private RentalCol rentalcol;

        public DataManager()
        {
            _clientManager = new ClientManager();
            _carManager = new CarManager();
            _rentalManager = new RentalManager();

            clientcol = new ClientCol();
            carcol = new CarCol();
            rentalcol = new RentalCol();

            LoadDataAllCleints();
            LoadDataAllCars();
            LoadDataAllRentals();
        }

        // Метод для загрузки данных из БД
        public List<Client> LoadDataAllCleints()
        {
            // при запуске программы коллекция пустая, загружаем данные из БД
            if (clientcol.Count == 0)
            {
                var clientsFromDB = _clientManager.getAllClients(); // загружаем клиентов из бд
                foreach (var client in clientsFromDB)
                {
                    clientcol.AddClient(client);                    // добавляем каждого клиента в коллекцию
                }
            }
           
            return clientcol.clients;
        }

        // Метод для загрузки автомобилей из БД
        public List<Car> LoadDataAllCars()
        {
            // если коллекция пустая, то в первый раз загружаем в нее данные из бд
            if (carcol.Count == 0)
            {
                var carsFromDB = _carManager.GetAllCarsFromDB();    // загружаем авто из коллекции

                foreach (var car in carsFromDB)
                {
                    carcol.AddCar(car);                             // добавляем каждое авто в коллекцию
                }
            }
            
            return carcol.cars;
        }

        public List<Rental> LoadDataAllRentals()
        {
            // если коллекция пустая, то в первый раз загружаем в нее данные из бд
            if (rentalcol.Count == 0)
            {
                var rentalsFromDB = _rentalManager.GetAllRentalsFromDB();

                foreach (var rental in rentalsFromDB)
                {
                    rentalcol.AddRental(rental);
                }
            }

            return rentalcol.rentals;
        }

        // Метод для добавления клиента
        public void AddClient(Client client)
        {
            _clientManager.AddClientToDB(client);                       // Сохранение клиента в БД
            clientcol.AddClient(_clientManager.GetLastClientFromDB());  // получаем из бд обьект клиента с id и добавляем затем его в коллекцию
        }

        // Метод для удаления клиента
        public void RemoveClient(int clientId)
        {
            if (ClientHasActiveRentals(clientId))
            {
                throw new InvalidOperationException("Невозможно удалить клиента, так как он участвует в активной аренде.");
            }

            clientcol.RemoveClient(clientId);               // удаляем из бд клиента
            _clientManager.removeClientFromDB(clientId);    // удаляем из коллекции клиента
        }

        // Метод для проверки, есть ли у клиента активные аренды
        public bool ClientHasActiveRentals(int clientId)
        {
            return rentalcol.HasActiveRentals(clientId);
        }

        // метод поиска клиента
        public Client ExistClient(int clientId)
        {
            try
            {
                return clientcol.GetClient(clientId); // Пытаемся получить клиента
            }
            catch (KeyNotFoundException)
            {
                return null; // Если клиент не найден, возвращаем null
            }
        }

        // Метод для добавления автомобиля
        public void AddCar(Car car)
        {
            _carManager.AddCarToDB(car);                    // добавляем машину в бд
            carcol.AddCar(_carManager.GetLastCarFromDB());  // добавляем машину, полученную из БД с id, в коллекцию
        }

        // Метод для удаления автомобиля
        public void RemoveCar(int carId)
        {
            carcol.RemoveCar(carId);                // удаляем авто из коллекции
            _carManager.RemoveCarFromDB(carId);     // удаляем авто из бд
        }

        public Car ExistCar(int CarId)
        {
            try
            {
                return carcol.GetCar(CarId); // Пытаемся получить машину
            }
            catch (KeyNotFoundException)
            {
                return null; // Если машина не найдена, возвращаем null
            }
        }

        //получение всех свободных авто
        public List<Car> GetAllAvailiableCars()
        {
            return carcol.getAvailableCars();
        }

        // добавление аренды
        public void AddRental(Rental rental)
        {
            _rentalManager.AddRentalToDB(rental);                       // добавляем аренду в бд
            rentalcol.AddRental(_rentalManager.GetLastRentalFromDB());  // добавляем аренду в коллекцию
            carcol.ChangeCondition(rental.CarId, false);                // меняем состояние машины в коллекции (то есть машина занята)
            _carManager.UpdateCarAvailability(rental.CarId, false);     // меняем состояние машины в бд
        }

        // удаление аренды
        public void RemoveRental(int rentalId)
        {
            _rentalManager.RemoveRentalFromDB(rentalId);        // удаляем из бд аренду
            Rental rental = rentalcol.GetRentalById(rentalId); // получаем ренту которую надо удалить
            if (rental != null)
            {
                carcol.ChangeCondition(rental.CarId, true);             // меняем состояние машины в коллекции
                _carManager.UpdateCarAvailability(rental.CarId, true); // меняем состояние машины в бд
                rentalcol.RemoveRental(rentalId);                      // удаляем аренду из коллекции
            }  
        }
    }

}
    

