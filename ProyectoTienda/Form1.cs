using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;


namespace ProyectoTienda
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ConectarButton_Click(object sender, EventArgs e)
        {
            Usuarios UObject = new Usuarios();
            UObject.Users = InsertUser.Text;
            UObject.Passwords = InsertPassword.Text;

            if(UObject.Pursuit() == true)
            {
                MessageBox.Show(UObject.Message, "Log In");
                Productos pr = new Productos();
                pr.Show();
            }

            else
            {
                MessageBox.Show(UObject.Message, "ERROR");
            }
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void InsertPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
