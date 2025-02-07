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
    public partial class CarListForm : Form
    {
        private DataManager dataManager;
  
        public CarListForm(DataManager temp)
        {
            InitializeComponent();
            dataManager = temp;
            LoadCars();
        }

        // загружаем информацию о всех авто в таблицу формы
        private void LoadCars()
        {
            dataGridView1.DataSource = null;                          // Сбрасываем источник данных
            dataGridView1.DataSource = dataManager.LoadDataAllCars(); // Устанавливаем источник данных
        }

        // добавление нового авто
        private void AddNewCar(object sender, EventArgs e)
        {
            // Создаем и открываем форму для добавления автомобиля
            using (AddCarForm addCarForm = new AddCarForm())
            {
                if (addCarForm.ShowDialog() == DialogResult.OK)
                {
                    // Получаем новый автомобиль и добавляем его в список
                    try
                    {
                        Car newCar = addCarForm.NewCar;
                        dataManager.AddCar(newCar);
                        LoadCars(); // Обновляем отображение
                    }
                    catch (Exception ex)
                    {
                        errorProvider.SetError(dataGridView1, null);
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // удаление авто
        private void DeleteCar(object sender, EventArgs e)
        {
            using (DeleteCarForm deleteCarForm = new DeleteCarForm())
            {
                if(deleteCarForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int id = deleteCarForm.id;
                        Car deletedCar = dataManager.ExistCar(id);

                        if (!deletedCar.IsAvailable)
                        {
                            MessageBox.Show("Невозможно удалить автомобиль, потому что он задействован в аренде.", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        else
                        {
                            dataManager.RemoveCar(id);
                            LoadCars();
                        }
                        
                    }
                    catch(Exception ex)
                    {
                        errorProvider.SetError(dataGridView1, null);
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}


