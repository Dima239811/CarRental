using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Tarif
    {    
        public Dictionary<string, double> AdditionalServices { get; private set; } // словарь услуг (название и цена)
        public double DailyRate { get; set; }                                      // Стоимость аренды машины в день
        public Tarif()
        {
            AdditionalServices = new Dictionary<string, double>
            {
                { "GPS Navigation", 10.0 }, 
                { "Child Seat", 15.0 },
                { "KASKO", 330.0 }
            };
        }

        // Метод добавления дополнительной услуги
        public void AddService(string serviceName, double servicePrice)
        {
            AdditionalServices[serviceName] = servicePrice;
        }

        // Метод для вычисления разницы между startTime и endTime
        public int GetRentalDuration(DateTime startTime, DateTime endTime)
        {
            if (endTime < startTime)
            {
                throw new InvalidOperationException("endTime не может быть меньше startTime.");
            }

            TimeSpan difference = endTime - startTime;      // Вычисляем разницу
            int daysDifference = (int)difference.TotalDays; // Получаем количество дней

            return daysDifference;
        }

        // расчет итоговой цены
        public double CalculateTotalPrice(DateTime startDate, DateTime endDate, List<string> selectedServices, double price)
        {
            DailyRate = price;                                      // цена аренды машины в день
            int rentalDays = GetRentalDuration(startDate, endDate); // Получаем количество дней аренды
            double totalCost = DailyRate * rentalDays;              // Рассчитываем стоимость аренды

            // Добавляем стоимость выбранных дополнительных услуг
            foreach (var service in selectedServices)
            {
                if (AdditionalServices.TryGetValue(service, out double serviceCost))
                {
                    totalCost += serviceCost; // добавляем стоимость услуги
                }
            }

            return totalCost;   // возвращаем окончательную стоимость ренты
        }

    }
}
