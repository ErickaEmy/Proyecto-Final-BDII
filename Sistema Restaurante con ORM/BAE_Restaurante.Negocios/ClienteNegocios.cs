using BAE_Restaurante.Datos;
using BAE_Restaurante.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAE_Restaurante.Negocios
{
    public class ClienteNegocios
    {

        public static DataTable Listar()
        {
            ClienteDatos objCategoria = new ClienteDatos();
            return objCategoria.Listar();
        }

        public static DataTable Buscar(string Busqueda)
        {
            ClienteDatos objCategoria = new ClienteDatos();
            return objCategoria.Buscar(Busqueda);
        }
        public static string Insertar(string num_documento, string tipo_documento, string nombres,string apellidos, string direccion,string celular)
        {
            ClienteDatos objCategoria = new ClienteDatos();
            string existe = objCategoria.Existe(num_documento);
            if (existe.Equals("1"))
            {
                return "El cliente ya existe en la base de datos";
            }
            else
            {
                ClienteEntidad objCategoriaE = new ClienteEntidad();
                objCategoriaE.num_documento = num_documento;
                objCategoriaE.tipo_documento = tipo_documento;
                objCategoriaE.nombres = nombres;
                objCategoriaE.apellidos = apellidos;
                objCategoriaE.direccion = direccion;
                objCategoriaE.celular = celular;
                return objCategoria.Insertar(objCategoriaE);
            }
        }

        public static string Actualizar(int id_cliente, string num_documento, string tipo_documento, string nombres, string apellidos, string direccion, string celular)
        {
            ClienteDatos objCategoria = new ClienteDatos();
            ClienteEntidad objCategoriaE = new ClienteEntidad();
            objCategoriaE.id_cliente = id_cliente;
            objCategoriaE.num_documento = num_documento;
            objCategoriaE.tipo_documento = tipo_documento;
            objCategoriaE.nombres = nombres;
            objCategoriaE.apellidos = apellidos;
            objCategoriaE.direccion = direccion;
            objCategoriaE.celular = celular;
            return objCategoria.Actualizar(objCategoriaE);

        }

        public static string Eliminar(int Id)
        {
            ClienteDatos objCategoria = new ClienteDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
