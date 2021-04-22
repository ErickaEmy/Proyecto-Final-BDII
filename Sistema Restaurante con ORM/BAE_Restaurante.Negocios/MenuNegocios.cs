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
    public class MenuNegocios
    {
        public static DataTable Listar()
        {
            MenuDatos objCategoria = new MenuDatos();
            return objCategoria.Listar();
        }

        public static string Insertar(DateTime fecha, string comentario)
        {
            MenuDatos objCategoria = new MenuDatos();
            
                MenuEntidad objCategoriaE = new MenuEntidad();
                objCategoriaE.fecha = fecha;
                objCategoriaE.comentario = comentario;
                return objCategoria.Insertar(objCategoriaE);
            
        }

        public static string Actualizar(int id_menu, DateTime fecha, string comentario)
        {
            MenuDatos objCategoria = new MenuDatos();

                MenuEntidad objCategoriaE = new MenuEntidad();
                objCategoriaE.id_menu = id_menu;
                objCategoriaE.fecha = fecha;
                objCategoriaE.comentario = comentario;
                return objCategoria.Actualizar(objCategoriaE);
            

        }

        public static string Eliminar(int Id)
        {
            MenuDatos objCategoria = new MenuDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
