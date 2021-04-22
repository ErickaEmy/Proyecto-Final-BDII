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
    public class Doc_ventaNegocios
    {
        public static DataTable Listar()
        {
            Doc_ventaDatos objCategoria = new Doc_ventaDatos();
            return objCategoria.Listar();
        }

        public static DataTable Buscar(int Busqueda)
        {
            Doc_ventaDatos objCategoria = new Doc_ventaDatos();
            return objCategoria.Buscar(Busqueda);
        }
        public static string Insertar(string tipo_doc_compra, int num_doc_compra, double venta_total, DateTime fecha, string comentario, int id_pedido)
        {
            Doc_ventaDatos objCategoria = new Doc_ventaDatos();

            Doc_ventaEntidad objCategoriaE = new Doc_ventaEntidad();
            objCategoriaE.tipo_doc_venta = tipo_doc_compra;
            objCategoriaE.num_doc_venta = num_doc_compra;
            objCategoriaE.venta_total = venta_total;
            objCategoriaE.fecha = fecha;
            objCategoriaE.comentario = comentario;
            objCategoriaE.id_pedido = id_pedido;
            return objCategoria.Insertar(objCategoriaE);

        }

        public static string Actualizar(int id_doc_compra, string tipo_doc_compra, int num_doc_compra, double venta_total, DateTime fecha, string comentario, int id_pedido)
        {
            Doc_ventaDatos objCategoria = new Doc_ventaDatos();

            Doc_ventaEntidad objCategoriaE = new Doc_ventaEntidad();
            objCategoriaE.id_doc_venta = id_doc_compra;
            objCategoriaE.tipo_doc_venta = tipo_doc_compra;
            objCategoriaE.num_doc_venta = num_doc_compra;
            objCategoriaE.venta_total = venta_total;
            objCategoriaE.fecha = fecha;
            objCategoriaE.comentario = comentario;
            objCategoriaE.id_pedido = id_pedido;
            return objCategoria.Actualizar(objCategoriaE);


        }

        public static string Eliminar(int Id)
        {
            Doc_ventaDatos objCategoria = new Doc_ventaDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
