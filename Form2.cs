using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vinoteca
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "")
                MessageBox.Show("Debe llenar los campos");
            else
            {
                //btnAceptar.DialogResult = DialogResult.OK;
                this.DialogResult = DialogResult.OK;
                //this.Close();
            }
        }
    }
}
