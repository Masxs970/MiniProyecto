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
    public partial class ViewClientes : Form
    {
        public ViewClientes()
        {
            InitializeComponent();
        }

        private void FacturacionClientes_Click(object sender, EventArgs e)
        {
            ViewCompras k = new ViewCompras();
            k.Show();
        }

        private void AtrasClientes_Click(object sender, EventArgs e)
        {
            this.Close();
            Productos z = new Productos();
            z.Show();
        }

        private void SalirClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistema_tiendaDataSet1.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.sistema_tiendaDataSet1.cliente);

        }
    }
}
