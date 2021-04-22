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
    class Producto_Doc_compraNegocios
    {
        public static DataTable Listar()
        {
            Producto_Doc_compraDatos objCategoria = new Producto_Doc_compraDatos();
            return objCategoria.Listar();
        }

        public static string Insertar(int id_producto, int id_doc_compra)
        {
            Producto_Doc_compraDatos objCategoria = new Producto_Doc_compraDatos();
            Producto_Doc_compraEntidad objCategoriaE = new Producto_Doc_compraEntidad();
            objCategoriaE.id_producto = id_producto;
            objCategoriaE.id_doc_compra = id_doc_compra;
            return objCategoria.Insertar(objCategoriaE);

        }


        public static string Eliminar(int Id, int Id2)
        {
            Producto_Doc_compraDatos objCategoria = new Producto_Doc_compraDatos();
            return objCategoria.Eliminar(Id, Id2);
        }
    }
}
