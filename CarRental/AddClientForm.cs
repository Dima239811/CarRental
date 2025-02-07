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
    public partial class AddClientForm : Form
    {
        public Client newClient { get; private set; }
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void AddClient(object sender, EventArgs e)
        {
            // Получаем данные из текстовых полей
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;

            newClient = new Client(name, email, phone); // создание нового клиента

            // Закрываем форму
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
