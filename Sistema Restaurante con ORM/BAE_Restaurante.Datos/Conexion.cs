using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BAE_Restaurante.Datos
{
    class Conexion
    {
        private string BD;
        private string Server;
        private string User;
        private string Clave;
        private bool Autenticacion;
        private static Conexion cnx = null;

        private Conexion()
        {
            this.BD = "BAE_Restaurante";
            this.Server = "DESKTOP-4TS8EI8";
            this.User = "sa";
            this.Clave = "root";
            this.Autenticacion = true;
        }
        public SqlConnection EstablecerConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.Server + ";" + "Database=" + this.BD + ";";
                if (this.Autenticacion)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.User + ";" + "Password=" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }
        public static Conexion getInstancia()
        {
            if (cnx == null)
            {
                cnx = new Conexion();
            }
            return cnx;
        }
    }
}