﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAE_Restaurante.Datos;
using System.Data;
using System.Data.SqlClient;
using BAE_Restaurante.Entidad;

namespace BAE_Restaurante.Datos
{
    public class Tipo_comidaDatos
    {
        public DataTable Listar()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("usp_Tipo_comida_S", sqlCnx);
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
                SqlCommand comando = new SqlCommand("usp_Tipo_comida_S_Buscar", sqlCnx);
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

        //Metodo Verificar si existe.
        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("usp_Tipo_comida_Verificar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pvalor", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParExiste);
                sqlCnx.Open();
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);

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

        //Método Insertar.

        public string Insertar(Tipo_comidaEntidad objcargo)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("usp_Tipo_comida_I", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objcargo.nombre;
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

        public string Actualizar(Tipo_comidaEntidad objcargo)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("usp_Tipo_comida_U", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pid_tipo_comida", SqlDbType.Int).Value = objcargo.id_tipo_comida;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objcargo.nombre;
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
                SqlCommand comando = new SqlCommand("usp_Tipo_comida_D", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pid_tipo_comida", SqlDbType.Int).Value = Id;
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