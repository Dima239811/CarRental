using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarRental
{
    public partial class AddRentalForm : Form
    {
        public Rental NewRental { get; private set; }
        private DataManager _dataManager;

        //данные для создание ренты
        public Car car;
        public Client client;
        public DateTime startTime;
        public DateTime endTime;
        List<string> selectedServices;
        Tarif tarif;
        int id;

        public AddRentalForm(DataManager datamager)
        {
            InitializeComponent();
            changeActClient(false);   // изначально скрываем элементы
            changeActCar(false);
            _dataManager = datamager;
            selectedServices = new List<string>();
        }

        // метод открытия соответствующих элементов
        private void btnIsClientInDB(object sender, EventArgs e)
        {
            changeActClient(true);
        }

        // открытие формы добавление новго клиента и получение из нее обьекта клиент
        private void btnOpenAddClientForm(object sender, EventArgs e)
        {
            changeActClient(false);

            // Создаем и открываем форму для добавления клиента
            using (AddClientForm addClientForm = new AddClientForm())
            {
                if (addClientForm.ShowDialog() == DialogResult.OK)
                {
                    // Получаем нового клиента  и добавляем его в список
                    try
                    {
                        client = addClientForm.newClient;
                        _dataManager.AddClient(client);
                        
                    }
                    catch (Exception ex)
                    {
                        errorProvider.SetError(button2, null);
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // метод открытия/скрытия полей для поиска клиента в бд
        public void changeActClient(bool flag)
        {
            labelId.Visible = flag;
            textBoxId.Visible = flag;
            BtnExistClient.Visible = flag;
        }

        // метод открытия/скрытия полей для поиска машины в бд
        public void changeActCar(bool flag)
        {
            labelIdCar.Visible = flag;
            textBoxIdCar.Visible = flag;
            BtnExistCar.Visible = flag;
        }

        // обработчик нажатия на кнопку, что машина находится в бд
        private void carIsInDB_Click(object sender, EventArgs e)
        {
            changeActCar(true);
        }

        // обработчик события добавления новой машины
        private void BtnAddCarForm_Click(object sender, EventArgs e)
        {
            changeActCar(false);
  
            // Создаем и открываем форму для добавления клиента
            using (AddCarForm addCarForm = new AddCarForm())
            {
                if (addCarForm.ShowDialog() == DialogResult.OK)
                {
                    // Получаем новый автомобиль и добавляем его в список
                    try
                    {
                        car = addCarForm.NewCar;
                        _dataManager.AddCar(car);
                        tarif = new Tarif();

                    }
                    catch (Exception ex)
                    {
                        errorProvider.SetError(button2, null);
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // поиск клиента в базе
        private void BtnExistClient_Click(object sender, EventArgs e)
        {
            // Получаем ID клиента из текстового поля
            if (int.TryParse(textBoxId.Text, out int clientId))
            {
                // Используем метод ExistClient для проверки существования клиента
                client = _dataManager.ExistClient(clientId);

                if (client != null)
                {
                    // Клиент найден, можно сообщить об этом пользователю
                    MessageBox.Show($"Клиент найден: {client.Name}, Email: {client.Email}");
                }
                else
                {
                    // Если клиент не найден, сообщаем об этом
                    MessageBox.Show("Клиент с таким ID не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Если ID не корректный
                MessageBox.Show("Введите корректный ID клиента.");
                textBoxId.Text = string.Empty;
            }
        }

        // нажатие на кнопку поиск машины в бд
        private void BtnExistCar_Click(object sender, EventArgs e)
        {
            // Получаем ID машиеы из текстового поля
            if (int.TryParse(textBoxIdCar.Text, out int carId))
            {
                car = _dataManager.ExistCar(carId);

                if (car != null) // Сначала проверяем, найден ли автомобиль
                {
                    // Проверяем, доступен ли автомобиль
                    if (!car.IsAvailable)
                    {
                        MessageBox.Show("Машина уже занята. Пожалуйста, выберите другую машину.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Выходим из метода, если машина занята
                    }

                    // Машина найдена и доступна, можно сообщить об этом пользователю
                    MessageBox.Show($"Машина найдена: {car.Brand}, Модель: {car.Model}");
                    tarif = new Tarif();
                }
                else
                {
                    // Если автомобиль не найден, сообщаем об этом
                    MessageBox.Show("Машина с таким ID не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Если ID не корректный
                MessageBox.Show("Введите корректный ID машины.");
                textBoxIdCar.Text = string.Empty;
            }
        }

        // обработчик события выбора доп услуги кресла
        private void checkBoxChair_CheckedChanged(object sender, EventArgs e)
        {
            string serviceName = "Child Seat";
            if (checkBoxChair.Checked)
            {   // если чекбокс установлен, то добавляем доп услугу
                selectedServices.Add(serviceName);
            }
            else
            {   // иначе удаляем ее
                selectedServices.Remove(serviceName);
            }
        }

        // обработчик события выбора доп услуги КАСКО
        private void checkBoxKASKO_CheckedChanged(object sender, EventArgs e)
        {
            string serviceName = "KASKO";
            if (checkBoxKASKO.Checked)
            {
                selectedServices.Add(serviceName);
            }
            else
            {
                selectedServices.Remove(serviceName);
            }
        }

        // обработчик события выбора доп услуги навигации
        private void checkBoxnNav_CheckedChanged(object sender, EventArgs e)
        {
            string serviceName = "GPS Navigation";
            if (checkBoxnNav.Checked)
            {
                selectedServices.Add(serviceName);
            }
            else
            {
                selectedServices.Remove(serviceName);
            }
        }

        // нажатие на кнопку выбора времени
        private void SelectDateBut_Click(object sender, EventArgs e)
        {
            if (dateStartTimer.Value > dateEndTimer.Value)
            {
                MessageBox.Show("Дата начала не может быть позже даты окончания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                startTime = dateStartTimer.Value;
                endTime = dateEndTimer.Value;
            }

        }

        // добавить аренду
        private void AddRentalBut_Click(object sender, EventArgs e)
        {
            // Проверяем, выбраны ли клиент и машина
            if (client == null)
            {
                MessageBox.Show("Пожалуйста, выберите клиента перед добавлением аренды.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Выходим из метода, если клиент не выбран
            }

            if (car == null)
            {
                MessageBox.Show("Пожалуйста, выберите машину перед добавлением аренды.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Выходим из метода, если машина не выбрана
            }

            NewRental = new Rental();
            NewRental = NewRental.CreateRental(client, car, tarif, startTime, endTime, selectedServices);   // создаем новую ренту
            
            // Закрываем форму
            DialogResult = DialogResult.OK;
            Close();
        }

        // кнопка расчета стоимости
        private void CalculatePrice_Click(object sender, EventArgs e)
        {
            // Проверяем, что все необходимые данные введены
            if (car == null)
            {
                MessageBox.Show("Пожалуйста, выберите машину.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Выходим из метода, если машина не выбрана
            }

            if (startTime == default(DateTime) || endTime == default(DateTime))
            {
                MessageBox.Show("Пожалуйста, выберите корректные даты начала и окончания аренды.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Выходим из метода, если даты не выбраны
            }

            // Если все данные корректны, рассчитываем цену
            double price = tarif.CalculateTotalPrice(startTime, endTime, selectedServices, car.DailyRate);
            textBoxPrice.Text = $"Ваша сумма: {price:F2}";
        }
    }
}
