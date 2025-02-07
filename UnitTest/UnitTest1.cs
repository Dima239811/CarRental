using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CarRental;
using System.Collections.Generic;
using Moq;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        // добавление машины
        public void Should_Add_Car_To_Collection()
        {
            Car car = new Car(1, "BMW", "X5", 2020, "A878DF", 25000);
            CarCol carCol = new CarCol();
            carCol.AddCar(car);
            Assert.IsTrue(carCol.Count == 1);
        }

        [TestMethod]
        // изменение статуса машины
        public void Should_Change_Car_Condition()
        {
            Car car = new Car(1, "BMW", "X5", 2020, "A878DF", 25000);
            CarCol carCol = new CarCol();
            carCol.AddCar(car);
            carCol.ChangeCondition(1, false);
            Assert.AreEqual(car.IsAvailable, false);
        }

        [TestMethod]
        // удаление машины
        public void Should_Remove_Car_From_Collection()
        {
            Car car = new Car(1, "BMW", "X5", 2020, "A878DF", 25000);
            CarCol carCol = new CarCol();
            carCol.AddCar(car);
            carCol.RemoveCar(1);
            Assert.AreEqual(0, carCol.Count);
        }

        [TestMethod]
        // получение машины
        public void Should_GetCar_From_Collection() {
            Car car = new Car(1, "BMW", "X5", 2020, "A878DF", 25000);
            CarCol carCol = new CarCol();
            carCol.AddCar(car);
            Car foundCar = new Car();
            foundCar = carCol.GetCar(1);
            Assert.IsNotNull(foundCar);
        }

        [TestMethod]
        // получение свободных машин
        public void Should_GetAvailibleCars_From_Collection()
        {
            Car car = new Car(1, "BMW", "X5", 2020, "A878DF", 25000);
            Car car1 = new Car(2, "BMW", "X3", 2020, "A878fs", 25000);
            CarCol carCol = new CarCol();
            carCol.AddCar(car);
            carCol.AddCar(car1);
            List<Car> availiableCars = carCol.getAvailableCars();
            Assert.IsTrue(availiableCars.Count == 2);
        }

        [TestMethod]
        // добавление и удаление клиента
        public void Should_Add_And_Remove_Client()
        {
            Client client = new Client(1, "Dima", "mail.ru", "+7 905 142 56 89");
            ClientCol clientCol = new ClientCol();
            clientCol.AddClient(client);
            clientCol.RemoveClient(1);
            Assert.AreEqual(0, clientCol.Count);
        }

        [TestMethod]
        // получение клиента
        public void Should_GetClient()
        {
            Client client = new Client(1, "Dima", "mail.ru", "+7 905 142 56 89");
            ClientCol clientCol = new ClientCol();
            clientCol.AddClient(client);
            Client foundClient = clientCol.GetClient(1);
            Assert.IsNotNull(foundClient);
        }

        [TestMethod]
        // создание аренды
        public void Should_Create_Rental()
        {
            Client client = new Client(1, "Dima", "mail.ru", "+7 905 142 56 89");
            Car car = new Car(1, "BMW", "X5", 2020, "A878DF", 25000);
            Tarif tarif = new Tarif();
            DateTime start = DateTime.Now;
            DateTime end = new DateTime(2025, 12, 29, 12, 0, 0); 
            List<string> selectedServices = new List<string>
            {
                { "GPS Navigation"}
            };
            Rental rental = new Rental();
            rental = rental.CreateRental(client, car, tarif, start, end, selectedServices);
            RentalCol rentalCol = new RentalCol();
            rentalCol.AddRental(rental);
            Assert.AreEqual(1, rentalCol.Count);
        }

        [TestMethod]
        // удаление аренды
        public void Should_Delete_Rental()
        {
            Client client = new Client(1, "Dima", "mail.ru", "+7 905 142 56 89");
            Car car = new Car(1, "BMW", "X5", 2020, "A878DF", 25000);
            Tarif tarif = new Tarif();
            DateTime start = DateTime.Now;
            DateTime end = new DateTime(2025, 12, 10, 12, 0, 0); // 10 декабря 2025 года, 12:00:00
            List<string> selectedServices = new List<string>
            {
                { "GPS Navigation"}
            };
            Rental rental = new Rental();
            rental = rental.CreateRental(client, car, tarif, start, end, selectedServices);
            rental.RentalId = 1;
            RentalCol rentalCol = new RentalCol();
            rentalCol.AddRental(rental);
            rentalCol.RemoveRental(1);
            Assert.AreEqual(0, rentalCol.Count);
        }

        [TestMethod]
        // получение аренды
        public void Should_GetRental()
        {
            Client client = new Client(1, "Dima", "mail.ru", "+7 905 142 56 89");
            Car car = new Car(1, "BMW", "X5", 2020, "A878DF", 25000);
            Tarif tarif = new Tarif();
            DateTime start = DateTime.Now;
            DateTime end = new DateTime(2025, 12, 10, 12, 0, 0); // 10 декабря 2025 года, 12:00:00
            List<string> selectedServices = new List<string>
            {
                { "GPS Navigation"}
            };
            Rental rental = new Rental();
            rental = rental.CreateRental(client, car, tarif, start, end, selectedServices);
            rental.RentalId = 1;
            RentalCol rentalCol = new RentalCol();
            rentalCol.AddRental(rental);
            Rental foundRental = rentalCol.GetRentalById(1);
            Assert.IsNotNull(foundRental);
        }

        [TestMethod]
        // получение аренды
        public void Should_GetAllRentals()
        {
            Client client = new Client(1, "Dima", "mail.ru", "+7 905 142 56 89");
            Car car = new Car(1, "BMW", "X5", 2020, "A878DF", 25000);
            Car car1 = new Car("BMW", "X3", 2020, "fff589", 25000);
            Tarif tarif = new Tarif();
            DateTime start = DateTime.Now;
            DateTime end = new DateTime(2025, 12, 10, 12, 0, 0); // 10 декабря 2025 года, 12:00:00
            List<string> selectedServices = new List<string>
            {
                { "GPS Navigation"}
            };
            Rental rental = new Rental();
            rental = rental.CreateRental(client, car, tarif, start, end, selectedServices);
            rental.RentalId = 1;
            Rental rental1 = new Rental();
            rental1 = rental1.CreateRental(client, car1, tarif, start, end, selectedServices);
            rental1.RentalId = 2;
            RentalCol rentalCol = new RentalCol();
            rentalCol.AddRental(rental);
            rentalCol.AddRental(rental1);

            List<Rental> rentals = new List<Rental>();
            rentals = rentalCol.GetAllRentals();
            Assert.IsTrue(rentals.Count == 2);
        }

        [TestMethod]
        // проверка задействовван ли клиентв аренде
        public void Should_IsActiveClient()
        {
            Client client = new Client(1, "Dima", "mail.ru", "+7 905 142 56 89");
            Car car = new Car(1, "BMW", "X5", 2020, "A878DF", 25000);
            Tarif tarif = new Tarif();
            DateTime start = DateTime.Now;
            DateTime end = new DateTime(2025, 12, 10, 12, 0, 0); // 10 декабря 2025 года, 12:00:00
            List<string> selectedServices = new List<string>
            {
                { "GPS Navigation"}
            };
            Rental rental = new Rental();
            rental = rental.CreateRental(client, car, tarif, start, end, selectedServices);
            RentalCol rentalCol = new RentalCol();
            rentalCol.AddRental(rental);
            Assert.IsTrue(rentalCol.HasActiveRentals(1));
        }

        [TestMethod]
        // проверка разности между днями
        public void GetRentalDuration_ValidDates_ReturnsCorrectDuration()
        {
            DateTime startTime = new DateTime(2024, 12, 1);
            DateTime endTime = new DateTime(2024, 12, 5);
            Tarif tarif = new Tarif();
            int duration = tarif.GetRentalDuration(startTime, endTime);
            Assert.AreEqual(4, duration);
        }

        [TestMethod]
        // проверка расчета цены
        public void CalculateTotalPrice_ValidInput_ReturnsCorrectTotalPrice()
        {
            DateTime startDate = new DateTime(2024, 12, 1);
            DateTime endDate = new DateTime(2024, 12, 5);
            List<string> selectedServices = new List<string> { "GPS Navigation" };
            double dailyRate = 100.0;
            Tarif tarif = new Tarif();
            double totalPrice = tarif.CalculateTotalPrice(startDate, endDate, selectedServices, dailyRate);

            Assert.AreEqual(410.0, totalPrice); // 4 days * 100 + 10 for GPS
        }

    }
}
