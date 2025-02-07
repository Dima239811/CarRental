using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class MainForm : Form
    {
        public DataManager dataManager;
 
        public MainForm()
        {
            InitializeComponent();
            dataManager = new DataManager();
        }

        // обработчик события показать авто
        private void ShowAuto(object sender, EventArgs e)
        {
            // Создаем новую форму и передаем список автомобилей
            CarListForm carListForm = new CarListForm(dataManager);
            carListForm.Show();
        }

        // обработчик события показать доступные авто
        private void ShowAvailiableAuto(object sender, EventArgs e)
        {
            AvailiableAutoForm availiableList = new AvailiableAutoForm(dataManager);
            availiableList.Show();
        }

        // обработчик события показать клиентов
        private void showAllClients(object sender, EventArgs e)
        {
            ClientForm listClientForm = new ClientForm(dataManager);
            listClientForm.Show();
            
        }

        // обработчик события показать аренды
        private void ShowAllRentals_Click(object sender, EventArgs e)
        {
            AllRentalsForm allRent = new AllRentalsForm(dataManager);
            allRent.Show();
        }

    }
}
