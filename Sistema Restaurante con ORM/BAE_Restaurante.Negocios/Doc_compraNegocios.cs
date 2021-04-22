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
    public class Doc_compraNegocios
    {
        public static DataTable Listar()
        {
            Doc_compraDatos objCategoria = new Doc_compraDatos();
            return objCategoria.Listar();
        }

        public static DataTable Buscar(int Busqueda)
        {
            Doc_compraDatos objCategoria = new Doc_compraDatos();
            return objCategoria.Buscar(Busqueda);
        }
        public static string Insertar(string tipo_doc_compra, int num_doc_compra, double venta_total,DateTime fecha, string comentario)
        {
            Doc_compraDatos objCategoria = new Doc_compraDatos();

            Doc_compraEntidad objCategoriaE = new Doc_compraEntidad();
            objCategoriaE.tipo_doc_compra = tipo_doc_compra;
            objCategoriaE.num_doc_compra = num_doc_compra;
            objCategoriaE.venta_total = venta_total;
            objCategoriaE.fecha = fecha;
            objCategoriaE.comentario = comentario;
            return objCategoria.Insertar(objCategoriaE);

        }

        public static string Actualizar(int id_doc_compra, string tipo_doc_compra, int num_doc_compra, double venta_total, DateTime fecha, string comentario)
        {
            Doc_compraDatos objCategoria = new Doc_compraDatos();

            Doc_compraEntidad objCategoriaE = new Doc_compraEntidad();
            objCategoriaE.id_doc_compra = id_doc_compra;
            objCategoriaE.tipo_doc_compra = tipo_doc_compra;
            objCategoriaE.num_doc_compra = num_doc_compra;
            objCategoriaE.venta_total = venta_total;
            objCategoriaE.fecha = fecha;
            objCategoriaE.comentario = comentario;
            return objCategoria.Actualizar(objCategoriaE);


        }

        public static string Eliminar(int Id)
        {
            Doc_compraDatos objCategoria = new Doc_compraDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
