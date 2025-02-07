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
    public partial class DeleteClientForm : Form
    {
        public int id { get; set; }
        public DeleteClientForm()
        {
            InitializeComponent();
        }

        private void DeleteClient(object sender, EventArgs e)
        {
            id = int.Parse(textBoxId.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
