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
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
			if (textBoxtipo.Text == "")
			{
				MessageBox.Show("Debe escribir el tipo de reporte");
			}
			else
			{
				dataGridViewreportes.Rows.Add(textBoxtipo.Text, textBoxinicio.Text, textBoxfin.Text);
				MessageBox.Show("Reporte generado");
			}
		}

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
			textBoxtipo.Clear();
			textBoxinicio.Clear();
			textBoxfin.Clear();
		}
    }
}
