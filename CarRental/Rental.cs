using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Rental
    {
        public int RentalId { get; set; }       // Уникальный идентификатор аренды
        public int CarId { get; set; }          // Внешний ключ к машине
        public int ClientId { get; set; }       // Внешний ключ к клиенту
        public DateTime StartDate { get; set; } // Дата начала аренды
        public DateTime EndDate { get; set; }   // Дата окончания аренды
        public double TotalPrice { get; set; }  // Общая цена аренды

        // Метод для создания аренды из бд
        public Rental CreateRental(Client client, Car car, Tarif tarif,
            DateTime start, DateTime end,
            List<string> selectedServices, int id)
        {
            if (car == null) throw new ArgumentNullException(nameof(car));
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (tarif == null) throw new ArgumentNullException(nameof(tarif));

            var rental = new Rental
            {
                RentalId = id,
                ClientId = client.Id,
                CarId = car.Id,
                StartDate = start,
                EndDate = end,
                TotalPrice = tarif.CalculateTotalPrice(start, end, selectedServices, car.DailyRate) // Рассчитываем цену с учетом тарифа и услуг
            };

            return rental;
        }

        // создание аренды пользователем
        public Rental CreateRental(Client client, Car car, Tarif tarif,
            DateTime start, DateTime end,
            List<string> selectedServices)
        {
            if (car == null) throw new ArgumentNullException(nameof(car));
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (tarif == null) throw new ArgumentNullException(nameof(tarif));

            var rental = new Rental
            {
                ClientId = client.Id,
                CarId = car.Id,
                StartDate = start,
                EndDate = end,
                TotalPrice = tarif.CalculateTotalPrice(start, end, selectedServices, car.DailyRate) // Рассчитываем цену с учетом тарифа и услуг
            };

            return rental;
        }

    }
}
