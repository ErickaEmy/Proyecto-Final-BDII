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
    public class Pedido_ProductoNegocios
    {
        public static DataTable Listar()
        {
            Pedido_ProductoDatos objCategoria = new Pedido_ProductoDatos();
            return objCategoria.Listar();
        }

        public static string Insertar(int id_pedido, int id_producto, int cantidad)
        {
            Pedido_ProductoDatos objCategoria = new Pedido_ProductoDatos();
            Pedido_ProductoEntidad objCategoriaE = new Pedido_ProductoEntidad();
            objCategoriaE.id_pedido = id_pedido;
            objCategoriaE.id_producto = id_producto;
            objCategoriaE.cantidad = cantidad;
            return objCategoria.Insertar(objCategoriaE);

        }

        public static string Actualizar(int id_pedido, int id_producto, int cantidad)
        {
            Pedido_ProductoDatos objCategoria = new Pedido_ProductoDatos();
            Pedido_ProductoEntidad objCategoriaE = new Pedido_ProductoEntidad();
            objCategoriaE.id_pedido = id_pedido;
            objCategoriaE.id_producto = id_producto;
            objCategoriaE.cantidad = cantidad;
            return objCategoria.Actualizar(objCategoriaE);

        }


        public static string Eliminar(int Id, int Id2)
        {
            Pedido_ProductoDatos objCategoria = new Pedido_ProductoDatos();
            return objCategoria.Eliminar(Id, Id2);
        }
    }
}
