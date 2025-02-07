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
    public partial class AvailiableAutoForm : Form
    {
        private DataManager dataManager;
        public AvailiableAutoForm(DataManager temp)
        {
            InitializeComponent();
            dataManager = temp;
            LoadCars();
        }

        // загружаем информацию об авто в таблицу формы
        private void LoadCars()
        {
            dataGridView1.DataSource = null;                               // Сбрасываем источник данных
            dataGridView1.DataSource = dataManager.GetAllAvailiableCars(); // Устанавливаем источник данных
        }
    }
}
