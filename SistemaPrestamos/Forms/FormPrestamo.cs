using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPrestamos.Forms
{
    public partial class FormPrestamo : Form
    {
        public FormPrestamo()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void botonguardar_Click(object sender, EventArgs e)
        {
			if (textBoxClientes.Text == "" || textBoxMonto.Text == "")
			{
				MessageBox.Show("Debe completar los campos");
			}
			else
			{
				dataGridViewPrestamos.Rows.Add(textBoxClientes.Text, textBoxMonto.Text, textBoxInteres.Text, textBoxFecha.Text);
				MessageBox.Show("Préstamo guardado");
			}
		}

        private void buttonBorrar_Click(object sender, EventArgs e)
        {

			textBoxClientes.Clear();
			textBoxMonto.Clear();
			textBoxInteres.Clear();
			textBoxFecha.Clear();
		}

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Buscar préstamo");
		}
    }
}
