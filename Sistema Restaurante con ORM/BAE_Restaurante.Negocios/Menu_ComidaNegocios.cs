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
    public class Menu_ComidaNegocios
    {
        public static DataTable Listar()
        {
            Menu_ComidaDatos objCategoria = new Menu_ComidaDatos();
            return objCategoria.Listar();
        }

        public static string Insertar(int id_mesa, int id_comida)
        {
            Menu_ComidaDatos objCategoria = new Menu_ComidaDatos();
            Menu_ComidaEntidad objCategoriaE = new Menu_ComidaEntidad();
            objCategoriaE.id_menu = id_mesa;
            objCategoriaE.id_comida = id_comida;
            return objCategoria.Insertar(objCategoriaE);

        }


        public static string Eliminar(int Id, int Id2)
        {
            Menu_ComidaDatos objCategoria = new Menu_ComidaDatos();
            return objCategoria.Eliminar(Id, Id2);
        }
    }
}
