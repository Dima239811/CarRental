using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRental
{
    public partial class AddCarForm : Form
    {

        public Car NewCar { get; private set; }
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void AddCar(object sender, EventArgs e)
        {
            string brand = textBoxBrand.Text;
            string model = textBoxModel.Text;
            int year = int.Parse(textBoxYear.Text);
            string licensePlate = textBoxLicensePlate.Text;
            double dailyRate = double.Parse(textBoxDailyRate.Text);

            // Создаем новый объект Car
            NewCar = new Car(brand, model, year, licensePlate, dailyRate);

            // Закрываем форму
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

       
    }
}
