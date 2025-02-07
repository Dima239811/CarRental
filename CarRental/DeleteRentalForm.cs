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
    public partial class DeleteRentalForm : Form
    {
        public int id { get; set; }
        public DeleteRentalForm()
        {
            InitializeComponent();
        }

        private void DeleteRentalBtn_Click(object sender, EventArgs e)
        {
            id = int.Parse(textBoxId.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
