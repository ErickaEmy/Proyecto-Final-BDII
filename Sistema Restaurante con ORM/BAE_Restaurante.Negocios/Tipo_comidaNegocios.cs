using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAE_Restaurante.Datos;
using BAE_Restaurante.Entidad;

namespace BAE_Restaurante.Negocios
{
    public class Tipo_comidaNegocios
    {

        public static DataTable Listar()
        {
            Tipo_comidaDatos objCategoria = new Tipo_comidaDatos();
            return objCategoria.Listar();
        }

        public static DataTable Buscar(string Busqueda)
        {
            Tipo_comidaDatos objCategoria = new Tipo_comidaDatos();
            return objCategoria.Buscar(Busqueda);
        }
        public static string Insertar(string nombre)
        {
            Tipo_comidaDatos objCategoria = new Tipo_comidaDatos();
            string existe = objCategoria.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "El tipo de comida ya existe en la base de datos";
            }
            else
            {
                Tipo_comidaEntidad objCategoriaE = new Tipo_comidaEntidad();
                objCategoriaE.nombre = nombre;
                return objCategoria.Insertar(objCategoriaE);
            }
        }

        public static string Actualizar(int id_tipo_comida, string nombre)
        {
            Tipo_comidaDatos objCategoria = new Tipo_comidaDatos();
            string existe = objCategoria.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "El tipo de comida ya existe en la base de datos";
            }
            else
            {
                Tipo_comidaEntidad objCategoriaE = new Tipo_comidaEntidad();
                objCategoriaE.id_tipo_comida = id_tipo_comida;
                objCategoriaE.nombre = nombre;
                return objCategoria.Actualizar(objCategoriaE);
            }

        }

        public static string Eliminar(int Id)
        {
            Tipo_comidaDatos objCategoria = new Tipo_comidaDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
