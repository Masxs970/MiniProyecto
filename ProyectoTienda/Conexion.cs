using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ProyectoTienda
{
    class Conexion
    {
        public string StringConnection;
        protected string sql;
        protected bool result;
        protected SqlConnection conn;
        protected SqlCommand CommandSql;
        protected string message;

        public Conexion()
        {
            this.StringConnection = ("Data Source=WINDOWS7-PC\\SQLEXPRESS;Initial Catalog=sistema_tienda;Integrated Security=True");
            this.conn = new SqlConnection(this.StringConnection);
        }

        public string Message
        {
            get
            {
                return this.message;
            }
        }
    }
}
