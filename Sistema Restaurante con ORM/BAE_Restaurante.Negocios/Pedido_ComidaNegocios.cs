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
    public class Pedido_ComidaNegocios
    {
        public static DataTable Listar()
        {
            Pedido_ComidaDatos objCategoria = new Pedido_ComidaDatos();
            return objCategoria.Listar();
        }

        public static string Insertar(int id_pedido, int id_comida, int cantidad)
        {
            Pedido_ComidaDatos objCategoria = new Pedido_ComidaDatos();
            Pedido_ComidaEntidad objCategoriaE = new Pedido_ComidaEntidad();
            objCategoriaE.id_pedido = id_pedido;
            objCategoriaE.id_comida = id_comida;
            objCategoriaE.cantidad = cantidad;
            return objCategoria.Insertar(objCategoriaE);

        }

        public static string Actualizar(int id_pedido, int id_comida, int cantidad)
        {
            Pedido_ComidaDatos objCategoria = new Pedido_ComidaDatos();
            Pedido_ComidaEntidad objCategoriaE = new Pedido_ComidaEntidad();
            objCategoriaE.id_pedido = id_pedido;
            objCategoriaE.id_comida = id_comida;
            objCategoriaE.cantidad = cantidad;
            return objCategoria.Actualizar(objCategoriaE);

        }


        public static string Eliminar(int Id, int Id2)
        {
            Pedido_ComidaDatos objCategoria = new Pedido_ComidaDatos();
            return objCategoria.Eliminar(Id, Id2);
        }
    }
}
