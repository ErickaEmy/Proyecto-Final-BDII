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
    public class CargoNegocios
    {
        public static DataTable Listar()
        {
            CargoDatos objCategoria = new CargoDatos();
            return objCategoria.Listar();
        }

        public static DataTable Buscar(string Busqueda)
        {
            CargoDatos objCategoria = new CargoDatos();
            return objCategoria.Buscar(Busqueda);
        }
        public static string Insertar(string nombre,int sueldo)
        {
            CargoDatos objCategoria = new CargoDatos();
            string existe = objCategoria.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "El cargo ya existe en la base de datos";
            }
            else
            {
                CargoEntidad objCategoriaE = new CargoEntidad();
                objCategoriaE.nombre = nombre;
                objCategoriaE.sueldo = sueldo;
                return objCategoria.Insertar(objCategoriaE);
            }
        }

        public static string Actualizar(int id_cargo, string nombre, int sueldo)
        {
            CargoDatos objCategoria = new CargoDatos();
                CargoEntidad objCategoriaE = new CargoEntidad();
                objCategoriaE.id_cargo = id_cargo;
                objCategoriaE.nombre = nombre;
                objCategoriaE.sueldo = sueldo;
                return objCategoria.Actualizar(objCategoriaE);
            

        }

        public static string Eliminar(int Id)
        {
            CargoDatos objCategoria = new CargoDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
