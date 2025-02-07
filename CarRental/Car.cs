using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Car
    {
        private int id;
        private string brand;
        private string model;
        private int year;
        private string licensePlate;      // номер авто
        private double dailyRate;         // цена аренды авто в день
        private bool isAvailable = true;   // если машину заняли меняем на false

        public int Id { get { return id; } set {  id = value; } }   
        public string Brand { get {  return brand; } set {  brand = value; } }
        public string Model { get { return model; } set { model = value; } }    
        public int Year { get { return year; } set { year = value; } }  
        public string LicensePlate { get {  return licensePlate; } set {  licensePlate = value; } }
        public double DailyRate { get {  return dailyRate; } set {  dailyRate = value; } }
        public bool IsAvailable { get {  return isAvailable; } set {  isAvailable = value; } }   

        public Car() { }
        public Car(int _id, string _brand, string _model, int _year, string _licensePlate,
                   double _dailyRate)
        {
            Id = _id;
            Brand = _brand;
            Model = _model;
            Year = _year;
            LicensePlate = _licensePlate;
            DailyRate = _dailyRate;
        }

        public Car(string _brand, string _model, int _year, string _licensePlate,
                   double _dailyRate)
        {
            Brand = _brand;
            Model = _model;
            Year = _year;
            LicensePlate = _licensePlate;
            DailyRate = _dailyRate;
        }
    }
}
