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
    public class Tipo_productoNegocios
    {
        public static DataTable Listar()
        {
            Tipo_productoDatos objCategoria = new Tipo_productoDatos();
            return objCategoria.Listar();
        }

        public static DataTable Buscar(string Busqueda)
        {
            Tipo_productoDatos objCategoria = new Tipo_productoDatos();
            return objCategoria.Buscar(Busqueda);
        }
        public static string Insertar(string nombre)
        {
            Tipo_productoDatos objCategoria = new Tipo_productoDatos();
            string existe = objCategoria.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "El tipo de producto ya existe en la base de datos";
            }
            else
            {
                Tipo_productoEntidad objCategoriaE = new Tipo_productoEntidad();
                objCategoriaE.nombre = nombre;
                return objCategoria.Insertar(objCategoriaE);
            }
        }

        public static string Actualizar(int id_tipo_producto, string nombre)
        {
            Tipo_productoDatos objCategoria = new Tipo_productoDatos();
            string existe = objCategoria.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "El tipo de producto ya existe en la base de datos";
            }
            else
            {
                Tipo_productoEntidad objCategoriaE = new Tipo_productoEntidad();
                objCategoriaE.id_tipo_producto = id_tipo_producto;
                objCategoriaE.nombre = nombre;
                return objCategoria.Actualizar(objCategoriaE);
            }

        }

        public static string Eliminar(int Id)
        {
            Tipo_productoDatos objCategoria = new Tipo_productoDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
