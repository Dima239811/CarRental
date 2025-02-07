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
    public partial class ClientForm : Form
    {
        private DataManager dataManager;

        public ClientForm(DataManager temp)
        {
            InitializeComponent();
            dataManager = temp;
            loadClients();
        }

        // загрузка информации о клиентах в таблицу формы
        public void loadClients()
        {
            dataGridView1.DataSource = null;                             // Сбрасываем источник данных
            dataGridView1.DataSource = dataManager.LoadDataAllCleints(); // Устанавливаем источник данных
        }

        // метод добавления клиента
        private void AddClient(object sender, EventArgs e)
        {
            // Создаем и открываем форму для добавления клиента
            using (AddClientForm addClientForm = new AddClientForm())
            {
                if (addClientForm.ShowDialog() == DialogResult.OK)
                {
                    // Получаем новый автомобиль и добавляем его в список
                    try
                    {
                        Client client = addClientForm.newClient;
                        dataManager.AddClient(client);
                        loadClients();
                    }
                    catch (Exception ex)
                    {
                        errorProvider.SetError(dataGridView1, null);
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // метод удаления клиента
        private void DeleteClient(object sender, EventArgs e)
        {
            using (DeleteCarForm deleteClientForm = new DeleteCarForm())
            {
                if (deleteClientForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int id = deleteClientForm.id;
                        dataManager.RemoveClient(id);
                        loadClients();
                    }
                    catch (Exception ex)
                    {
                        errorProvider.SetError(dataGridView1, null);
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
