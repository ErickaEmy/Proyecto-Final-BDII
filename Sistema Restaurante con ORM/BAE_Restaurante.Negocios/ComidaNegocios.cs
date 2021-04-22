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
    public class ComidaNegocios
    {
        public static DataTable Listar()
        {
            ComidaDatos objCategoria = new ComidaDatos();
            return objCategoria.Listar();
        }

        public static DataTable Buscar(string Busqueda)
        {
            ComidaDatos objCategoria = new ComidaDatos();
            return objCategoria.Buscar(Busqueda);
        }
        public static string Insertar(string nombre, double precio, int cantidad, string comentario, int id_tipo_comida)
        {
            ComidaDatos objCategoria = new ComidaDatos();
            string existe = objCategoria.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "La comida ya existe en la base de datos";
            }
            else
            {
                ComidaEntidad objCategoriaE = new ComidaEntidad();
                objCategoriaE.nombre = nombre;
                objCategoriaE.precio = precio;
                objCategoriaE.cantidad = cantidad;
                objCategoriaE.comentario = comentario;
                objCategoriaE.id_tipo_comida = id_tipo_comida;
                return objCategoria.Insertar(objCategoriaE);
            }
        }

        public static string Actualizar(int id_comida, string nombre, double precio, int cantidad, string comentario, int id_tipo_comida)
        {
            ComidaDatos objCategoria = new ComidaDatos();
            string existe = objCategoria.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "El cliente ya existe en la base de datos";
            }
            else
            {
                ComidaEntidad objCategoriaE = new ComidaEntidad();
                objCategoriaE.id_comida = id_comida; 
                objCategoriaE.nombre = nombre;
                objCategoriaE.precio = precio;
                objCategoriaE.cantidad = cantidad;
                objCategoriaE.comentario = comentario;
                objCategoriaE.id_tipo_comida = id_tipo_comida;
                return objCategoria.Actualizar(objCategoriaE);
            }

        }

        public static string Eliminar(int Id)
        {
            ComidaDatos objCategoria = new ComidaDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
