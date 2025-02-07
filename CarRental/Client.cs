using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Client
    {
        private int id;
        private string name;
        private string email;
        private string phoneNumber;

        public int Id {  get { return id; } set {  id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string PhoneNumber { get {  return phoneNumber; } set {  phoneNumber = value; } }
        public Client() { }

        // конструктор когда берем из базы клиента
        public Client(int _id, string _name, string _email, string _phonenumber)
        {
            Id = _id;
            Name = _name;
            Email = _email;
            PhoneNumber = _phonenumber;
        }

        // когда заполняем клиента в форме
        public Client(string _name, string _email, string _phonenumber)
        {
            Name = _name;
            Email = _email;
            PhoneNumber = _phonenumber;
        }
    }
}
