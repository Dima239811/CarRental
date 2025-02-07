using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public class ClientCol
    {
        public List<Client> clients;
        private int count = 0;  // количество клиентов в коллекции

        public ClientCol() {
            clients = new List<Client>();
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        // метод добавления клиента в коллекцию
        public void AddClient(Client client)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client), "Клиент не может быть null.");
            }

            clients.Add(client);
            count++;

            //contrBD.AddClientToDB(client); // добавляем в бд клиента
        }

        // Метод для удаления клиента по ID
        public void RemoveClient(int clientId)
        {
            var clientToRemove = clients.FirstOrDefault(c => c.Id == clientId);
            if (clientToRemove != null)
            {
                clients.Remove(clientToRemove);
                count--;
            }
            else
            {
                throw new KeyNotFoundException("Клиент с таким ID не найден.");
            }
        }

        // Метод для поиска клиента по ID
        public Client GetClient(int clientId)
        {
            var client = clients.FirstOrDefault(c => c.Id == clientId);
            if (client == null)
            {
                throw new KeyNotFoundException("Клиент с таким ID не найден.");
            }

            return client;
        }


    }
}
