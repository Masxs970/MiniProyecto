using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTienda
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        
        private void SalirProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientesProductos_Click(object sender, EventArgs e)
        {
            ViewClientes j = new ViewClientes();
            j.Show();
        }
    }
}
