using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAE_Restaurante.Entidad;

namespace BAE_Restaurante.Datos
{
    public class ProductoDatos
    {
        public DataTable Listar()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("usp_Producto_S", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                sqlCnx.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
        }

        //Método Buscar.
        public DataTable Buscar(string Busqueda)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("usp_Producto_S_Buscar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pbusqueda", SqlDbType.VarChar).Value = Busqueda;
                sqlCnx.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
        }

        //Método Insertar.

        public string Insertar(ProductoEntidad objproducto)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("usp_Producto_I", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objproducto.nombre;
                comando.Parameters.Add("@pprecio", SqlDbType.Float).Value = objproducto.precio;
                comando.Parameters.Add("@pcantidad", SqlDbType.Int).Value = objproducto.cantidad;
                comando.Parameters.Add("@pfecha_vencimiento", SqlDbType.Date).Value = objproducto.fecha_vencimiento;
                comando.Parameters.Add("@pnum_medida", SqlDbType.Float).Value = objproducto.num_medida;
                comando.Parameters.Add("@pcomentario", SqlDbType.Text).Value = objproducto.comentario;
                comando.Parameters.Add("@pid_tipo_producto", SqlDbType.Int).Value = objproducto.id_tipo_producto;
                comando.Parameters.Add("@pid_tipo_medida", SqlDbType.Int).Value = objproducto.id_tipo_medida;
                sqlCnx.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo agregar el registro.";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
            return Rpta;
        }

        //Método Actualizar.

        public string Actualizar(ProductoEntidad objproducto)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("usp_Producto_U", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pid_producto", SqlDbType.Int).Value = objproducto.id_producto;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objproducto.nombre;
                comando.Parameters.Add("@pprecio", SqlDbType.Float).Value = objproducto.precio;
                comando.Parameters.Add("@pcantidad", SqlDbType.Int).Value = objproducto.cantidad;
                comando.Parameters.Add("@pfecha_vencimiento", SqlDbType.Date).Value = objproducto.fecha_vencimiento;
                comando.Parameters.Add("@pnum_medida", SqlDbType.Float).Value = objproducto.num_medida;
                comando.Parameters.Add("@pcomentario", SqlDbType.Text).Value = objproducto.comentario;
                comando.Parameters.Add("@pid_tipo_producto", SqlDbType.Int).Value = objproducto.id_tipo_producto;
                comando.Parameters.Add("@pid_tipo_medida", SqlDbType.Int).Value = objproducto.id_tipo_medida;
                sqlCnx.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro.";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
            return Rpta;
        }

        //Método Eliminar.

        public string Eliminar(int Id)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("usp_Producto_D", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pid_producto", SqlDbType.Int).Value = Id;
                sqlCnx.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro.";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
            return Rpta;
        }
    }
}
