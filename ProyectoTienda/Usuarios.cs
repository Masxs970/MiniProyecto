using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoTienda
{
    class Usuarios : Conexion
    {
        private string user;
        private string password;

        public Usuarios()
        {
            user = string.Empty;
            password = string.Empty;
            this.sql = string.Empty;
        }

        public string Users
        {
            get{ return this.user;}

            set{ this.user = value;}
        }

        public string Passwords
        {
            get{ return this.password;}

            set{ this.password = value;}
        }

        public bool Pursuit()
        {
            bool result = false;
            this.sql = string.Format("SELECT * FROM usuario WHERE usuario='{0}' AND contraseña='{1}'", this.user, this.password);
            this.CommandSql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            SqlDataReader reader = null;
            reader = this.CommandSql.ExecuteReader();

            if (reader.Read())
            {
                result = true;
                this.message = "Bienvenido a la Base de Datos";
            }
            else
            {
                this.message = "Datos incorrectos. Vuelva a intentarlo";
            }

            this.conn.Close();
            return result;
        }
    }
}
