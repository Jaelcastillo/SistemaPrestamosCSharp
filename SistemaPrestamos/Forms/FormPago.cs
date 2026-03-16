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
    public partial class FormPago : Form
    {
        public FormPago()
        {
            InitializeComponent();
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
			if (textBoxclientes.Text == "" || textBoxpagado.Text == "")
			{
				MessageBox.Show("Complete los campos");
			}
			else
			{
				dataGridViewpago.Rows.Add(textBoxclientes.Text, textBoxpagado.Text, textBoxfecha.Text, textBoxmetodo.Text);
				MessageBox.Show("Pago registrado");
			}
		}

        private void buttonborrar_Click(object sender, EventArgs e)
        {
			textBoxclientes.Clear();
			textBoxpagado.Clear();
			textBoxfecha.Clear();
			textBoxmetodo.Clear();
		}

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Buscar pago");
		}
    }
}
