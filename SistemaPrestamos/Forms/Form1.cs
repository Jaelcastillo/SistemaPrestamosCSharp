using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPrestamos.Forms;

namespace SistemaPrestamos
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void registrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes clientes = new FormClientes();
            clientes.MdiParent = tis;
            clientes.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
