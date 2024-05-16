using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vinoteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Empresa empresa = new Empresa();
        private void button1_Click(object sender, EventArgs e)
        {

            //listView1.View = View.Details;
            /*listView1.Dock = DockStyle.Fill;

            listView1.Columns.Add("Bodega", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Vino", 150);
            listView1.Columns.Add("Color", 100);
            listView1.Columns.Add("Tipo", 100);
            listView1.Columns.Add("Precio", 80);*/

            string[] item1 = { "Bodega1", "Vino1", "Rojo", "Tinto", "$10.00" };
            string[] item2 = { "Bodega2", "Vino2", "Blanco", "Seco", "$15.00" };
            string[] item3 = { "Bodega3", "Vino3", "Rosado", "Dulce", "$8.50" };

            listView1.Items.Add(new ListViewItem(item1));
            listView1.Items.Add(new ListViewItem(item2));
            listView1.Items.Add(new ListViewItem(item3));

        }
        private void actualizarTabla(List<Vino> lista)
        {
            listView1.Items.Clear();
            foreach (Vino vino in lista)
            {
                string[] item = { vino.Id.ToString(), vino.Bodega, vino.Nombre, vino.Tipo, vino.Precio.ToString() };
                listView1.Items.Add(new ListViewItem(item));
            }
        }

        private void agregarVinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            if (form.ShowDialog() == DialogResult.OK)
            {
                string bodega = form.textBox1.Text;
                string vino = form.textBox2.Text;
                string tipo = form.textBox3.Text;
                double precio = (double)form.numericUpDown1.Value;
                int cant = (int)form.numericUpDown2.Value;
                empresa.AgregarVino(cant, bodega, vino, tipo, precio);
                actualizarTabla(empresa.ListaVinos);
            }
            form.Dispose();
        }

        private void modificarVinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {


                Form2 form = new Form2();
                int id = Convert.ToInt32(listView1.SelectedItems[0].Text);
                Vino vino = empresa.ListaVinos.Find(x => x.Id == id);
                form.textBox1.Enabled = false;
                form.textBox2.Enabled = false;
                form.textBox3.Enabled = false;
                form.textBox1.Text = vino.Bodega;
                form.textBox2.Text = vino.Nombre;
                form.textBox3.Text = vino.Tipo;
                form.numericUpDown1.Value = (Decimal)vino.Precio;
                form.numericUpDown2.Value = (Decimal)vino.Cantidad;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    double precio = (double)form.numericUpDown1.Value;
                    int cant = (int)form.numericUpDown2.Value;
                    empresa.CambiarPrecio(id, precio, cant);
                    actualizarTabla(empresa.ListaVinos);
                }
                form.Dispose();
            }
        }

        private void quitarVinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listView1.SelectedItems[0].Text);
            string bodega = listView1.SelectedItems[0].SubItems[1].Text;
            string nombre = listView1.SelectedItems[0].SubItems[2].Text;
            string tipo = listView1.SelectedItems[0].SubItems[3].Text;
            if (MessageBox.Show($"Estas seguro de borar '{bodega} {nombre} {tipo}'", "Confirmar", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                empresa.QuitarVino(id);
                actualizarTabla(empresa.ListaVinos);
            }
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listView1.SelectedItems[0].Text);
            Vino vino = empresa.ListaVinos.Find(x => x.Id == id);
            //empresa.ReservarVino(vino);

        }

        private void btnRojo_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string txt = toolStripTextBox1.Text;
            if (txt == "")
                actualizarTabla(empresa.ListaVinos);
            else
                actualizarTabla(empresa.filtrar(txt));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            empresa.AgregarVinosRandom();
            actualizarTabla(empresa.ListaVinos);
        }
    }
}
