using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class RentalCol
    {
        public List<Rental> rentals;
        private int count = 0;       // количество аренд в коллекции

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public RentalCol()
        {
            rentals = new List<Rental>();
        }

        // Добавление аренды в коллекцию
        public void AddRental(Rental rental)
        {
            if (rental == null) 
                throw new ArgumentNullException(nameof(rental));

            Count++;
            rentals.Add(rental);    // добавление аренды в коллекцию
        }

        // Удаление аренды из коллекции по идентификатору
        public void RemoveRental(int rentalId)
        {
            var rentalToRemove = rentals.FirstOrDefault(r => r.RentalId == rentalId);
            if (rentalToRemove != null)
            {
                Count--;
                rentals.Remove(rentalToRemove);
            }
            else
            {
                throw new KeyNotFoundException("Аренда с таким ID не найдена.");
            }
        }

        // Получение всех аренды
        public List<Rental> GetAllRentals()
        {
            return rentals;
        }

        // Поиск аренды по идентификатору
        public Rental GetRentalById(int rentalId)
        {
            return rentals.FirstOrDefault(r => r.RentalId == rentalId);
        }

        // Проверка, есть ли у клиента активные аренды
        public bool HasActiveRentals(int clientId)
        {
            return rentals.Any(r => r.ClientId == clientId && r.EndDate >= DateTime.Now);
        }
    }
}
