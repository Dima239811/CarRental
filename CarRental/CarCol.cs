using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class CarCol
    {
        public List<Car> cars;
        public CarCol() { cars = new List<Car>(); }

        private int count = 0;              // количество авто в коллекции
        private int availiableCount = 0;    // кол-во свободных авто
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public int AvailiableCount {  get { return availiableCount; } set {  availiableCount = value; } }

        // Метод для добавления нового автомобиля
        public void AddCar(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car), "Автомобиль не может быть null.");
            }

            cars.Add(car); // Добавление автомобиля в коллекцию
            count++;       // увелечине счетчика количества авто в коллекции 
        }

        // Метод для удаления автомобиля по ID
        public void RemoveCar(int carId)
        {
            var carToRemove = cars.FirstOrDefault(c => c.Id == carId);
            if (carToRemove != null)
            {
                cars.Remove(carToRemove); // Удаление автомобиля из коллекции
                count--;
            }
            else
            {
                throw new KeyNotFoundException("Автомобиль с таким ID не найден.");
            }
        }

        // Метод для поиска автомобиля по ID
        public Car GetCar(int carId)
        {
            var car = cars.FirstOrDefault(c => c.Id == carId);
            if (car == null)
            {
                throw new KeyNotFoundException("Автомобиль с таким ID не найден.");
            }

            return car; // Возврат найденного автомобиля
        }

        // Метод получения всех доступных авто
        public List<Car> getAvailableCars()
        {
            List<Car> AvailableCars = new List<Car>();  // список свободных авто
            foreach (var car in cars) 
            {   // если авто свободно
                if (car.IsAvailable)
                {
                    AvailableCars.Add(car);             
                }
            }

            // Обновляем количество доступных автомобилей
            AvailiableCount = AvailableCars.Count;

            return AvailableCars;
        }

        //public bool IsCarAvailable(int carId)
        //{
        //    var car = GetCar(carId);
        //    return car != null && car.IsAvailable; // Возвращаем true, если машина найдена и доступна
        //}

        // меняем состояние машины если она занята/свободна
        public void ChangeCondition(int CarId, bool flag)
        {
            var carToUpdate = GetCar(CarId);    // находим нужное авто
            if (carToUpdate != null)
            {
                carToUpdate.IsAvailable = flag; // Устанавливаем доступность
            }
        }
    }
}
