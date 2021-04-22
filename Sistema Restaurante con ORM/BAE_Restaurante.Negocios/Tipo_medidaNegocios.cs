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
    public class Tipo_medidaNegocios
    {
        public static DataTable Listar()
        {
            Tipo_medidaDatos objCategoria = new Tipo_medidaDatos();
            return objCategoria.Listar();
        }

        public static DataTable Buscar(string Busqueda)
        {
            Tipo_medidaDatos objCategoria = new Tipo_medidaDatos();
            return objCategoria.Buscar(Busqueda);
        }
        public static string Insertar(string nombre)
        {
            Tipo_medidaDatos objCategoria = new Tipo_medidaDatos();
            string existe = objCategoria.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "El tipo de medida ya existe en la base de datos";
            }
            else
            {
                Tipo_medidaEntidad objCategoriaE = new Tipo_medidaEntidad();
                objCategoriaE.nombre = nombre;
                return objCategoria.Insertar(objCategoriaE);
            }
        }

        public static string Actualizar(int id_tipo_medida, string nombre)
        {
            Tipo_medidaDatos objCategoria = new Tipo_medidaDatos();
            string existe = objCategoria.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "El tipo de medida ya existe en la base de datos";
            }
            else
            {
                Tipo_medidaEntidad objCategoriaE = new Tipo_medidaEntidad();
                objCategoriaE.id_tipo_medida = id_tipo_medida;
                objCategoriaE.nombre = nombre;
                return objCategoria.Actualizar(objCategoriaE);
            }

        }

        public static string Eliminar(int Id)
        {
            Tipo_medidaDatos objCategoria = new Tipo_medidaDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
