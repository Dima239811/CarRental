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
    public partial class AllRentalsForm : Form
    {
        private DataManager dataManager;
        public AllRentalsForm(DataManager _dataManager)
        {
            InitializeComponent();
            dataManager = _dataManager;
            LoadRental();    
        }

        // загружаем данные в таблицу формы
        private void LoadRental()
        {
            dataGridView1.DataSource = null;                                            // Сбрасываем источник данных
            dataGridView1.DataSource = dataManager.LoadDataAllRentals();                // Устанавливаем источник данных

            dataGridView1.Columns["StartDate"].DefaultCellStyle.Format = "MM/dd/yyyy";  // Формат даты (например, "MM/dd/yyyy")
            dataGridView1.Columns["EndDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
        }

        // добавить аренду
        private void AddRentBtn_Click(object sender, EventArgs e)
        {
            //Создаем и открываем форму для добавления rental
            using (AddRentalForm addRentalForm = new AddRentalForm(dataManager))
            {
                if (addRentalForm.ShowDialog() == DialogResult.OK)
                {
                    // Получаем новую ренту и добавляем в список
                    try
                    {
                        Rental newRent = addRentalForm.NewRental;
                        dataManager.AddRental(newRent);
                        LoadRental(); // Обновляем отображение
                    }
                    catch (Exception ex)
                    {
                        errorProvider.SetError(dataGridView1, null);
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // удалить аренду
        private void DeleteRentBtn_Click(object sender, EventArgs e)
        {
            using (DeleteRentalForm deleteRentalForm = new DeleteRentalForm())
            {
                if (deleteRentalForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int id = deleteRentalForm.id;
                        dataManager.RemoveRental(id);
                        LoadRental();
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
