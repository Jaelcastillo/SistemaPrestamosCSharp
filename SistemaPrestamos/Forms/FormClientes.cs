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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
			if (textBoxNombre.Text == "" || textBoxcedula.Text == "" || textBoxmonto.Text == "" || textBoxtelefono.Text =="" || textBoxdireccion.Text == "" || textBoxGarantia.Text == "")
			{
				MessageBox.Show("Debe completar los campos");
			}
			else
			{
				dataGridViewClientes.Rows.Add(textBoxNombre.Text, textBoxcedula.Text, textBoxmonto.Text, 
					textBoxtelefono.Text, textBoxdireccion, textBoxGarantia);
			}
		}

        private void buttonborrar_Click(object sender, EventArgs e)
        {
			textBoxNombre.Clear();
			textBoxcedula.Clear();
			textBoxmonto.Clear();
			textBoxtelefono.Clear();
			textBoxdireccion.Clear();
			textBoxGarantia.Clear();
		}
	}
    }

