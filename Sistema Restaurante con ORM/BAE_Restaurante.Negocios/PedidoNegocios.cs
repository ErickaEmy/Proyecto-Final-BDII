using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAE_Restaurante.Datos;
using BAE_Restaurante.Entidad;
using System.Data;

namespace BAE_Restaurante.Negocios
{
    public class PedidoNegocios
    {
        public static DataTable Listar()
        {
            PedidoDatos objCategoria = new PedidoDatos();
            return objCategoria.Listar();
        }

        public static DataTable ListarActivos()
        {
            PedidoDatos objCategoria = new PedidoDatos();
            return objCategoria.ListarActivos();
        }

        public static DataTable Buscar(string Busqueda)
        {
            PedidoDatos objCategoria = new PedidoDatos();
            return objCategoria.Buscar(Busqueda);
        }

        public static DataTable ListarVentas(int id_pedido)
        {
            PedidoDatos objCategoria = new PedidoDatos();
            return objCategoria.ListarVentas(id_pedido);
        }

        public static string Insertar(DateTime fecha, string tipo_pedido, string tipo_pago, int imagen_pago, string estado, string comentario, int id_empleado, int id_cliente, int id_mesa, string direccion_envio)
        {
            PedidoDatos objCategoria = new PedidoDatos();
            PedidoEntidad objCategoriaE = new PedidoEntidad();
            objCategoriaE.fecha = fecha;
            objCategoriaE.tipo_pedido = tipo_pedido;
            objCategoriaE.tipo_pago = tipo_pago;
            objCategoriaE.imagen_pago = imagen_pago;
            objCategoriaE.estado = estado;
            objCategoriaE.comentario = comentario;
            objCategoriaE.id_empleado = id_empleado;
            objCategoriaE.id_cliente = id_cliente;
            objCategoriaE.id_mesa = id_mesa;
            objCategoriaE.direccion_envio = direccion_envio;
            return objCategoria.Insertar(objCategoriaE);

        }

        public static string Actualizar(int id_pedido, DateTime fecha, string tipo_pedido, string tipo_pago, int imagen_pago, string estado, string comentario, int id_empleado, int id_cliente, int id_mesa, string direccion_envio)
        {
            PedidoDatos objCategoria = new PedidoDatos();
            PedidoEntidad objCategoriaE = new PedidoEntidad();
            objCategoriaE.id_pedido = id_pedido;
            objCategoriaE.fecha = fecha;
            objCategoriaE.tipo_pedido = tipo_pedido;
            objCategoriaE.tipo_pago = tipo_pago;
            objCategoriaE.imagen_pago = imagen_pago;
            objCategoriaE.estado = estado;
            objCategoriaE.comentario = comentario;
            objCategoriaE.id_empleado = id_empleado;
            objCategoriaE.id_cliente = id_cliente;
            objCategoriaE.id_mesa = id_mesa;
            objCategoriaE.direccion_envio = direccion_envio;
            return objCategoria.Actualizar(objCategoriaE);


        }

        public static string Eliminar(int Id)
        {
            PedidoDatos objCategoria = new PedidoDatos();
            return objCategoria.Eliminar(Id);
        }

        public static DataTable ListarComidaMasVendida()
        {
            PedidoDatos objCategoria = new PedidoDatos();
            return objCategoria.ListarComidaMasVendida();
        }
        public static DataTable ListarProductoMasVendido()
        {
            PedidoDatos objCategoria = new PedidoDatos();
            return objCategoria.ListarProductoMasVendido();
        }
        public static DataTable ListarVentasTipoComida()
        {
            PedidoDatos objCategoria = new PedidoDatos();
            return objCategoria.ListarVentasTipoComida();
        }
        public static DataTable ListarMejoresClientes()
        {
            PedidoDatos objCategoria = new PedidoDatos();
            return objCategoria.ListarMejoresClientes();
        }
        //public static DataTable BuscarPedidosFechas(DateTime Busqueda1, DateTime Busqueda2)
        //{
        //    //PedidoDatos objCategoria = new PedidoDatos();
        //    //return objCategoria.BuscarPedidosFechas(Busqueda1, Busqueda2);
        //}



    }
}
