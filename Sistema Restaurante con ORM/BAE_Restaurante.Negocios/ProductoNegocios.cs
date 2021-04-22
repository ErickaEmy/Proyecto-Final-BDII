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
    public class ProductoNegocios
    {
        public static DataTable Listar()
        {
            ProductoDatos objCategoria = new ProductoDatos();
            return objCategoria.Listar();
        }

        public static DataTable Buscar(string Busqueda)
        {
            ProductoDatos objCategoria = new ProductoDatos();
            return objCategoria.Buscar(Busqueda);
        }
        public static string Insertar(string nombre, double precio, int cantidad, DateTime fecha_vencimiento, double num_medida, string comentario,int id_tipo_producto, int id_tipo_medida)
        {
            ProductoDatos objCategoria = new ProductoDatos();
            
                ProductoEntidad objCategoriaE = new ProductoEntidad();
                objCategoriaE.nombre = nombre;
                objCategoriaE.precio = precio;
                objCategoriaE.cantidad = cantidad;
                objCategoriaE.fecha_vencimiento = fecha_vencimiento;
                objCategoriaE.num_medida = num_medida;
                objCategoriaE.comentario = comentario;
                objCategoriaE.id_tipo_producto = id_tipo_producto;
                objCategoriaE.id_tipo_medida = id_tipo_medida;
            return objCategoria.Insertar(objCategoriaE);
            
        }

        public static string Actualizar(int id_producto, string nombre, double precio, int cantidad, DateTime fecha_vencimiento, double num_medida, string comentario, int id_tipo_producto, int id_tipo_medida)
        {
            ProductoDatos objCategoria = new ProductoDatos();
            
                ProductoEntidad objCategoriaE = new ProductoEntidad();
                objCategoriaE.id_producto = id_producto;
                objCategoriaE.nombre = nombre;
                objCategoriaE.precio = precio;
                objCategoriaE.cantidad = cantidad;
                objCategoriaE.fecha_vencimiento = fecha_vencimiento;
                objCategoriaE.num_medida = num_medida;
                objCategoriaE.comentario = comentario;
                objCategoriaE.id_tipo_producto = id_tipo_producto;
                objCategoriaE.id_tipo_medida = id_tipo_medida;
            return objCategoria.Actualizar(objCategoriaE);
            

        }

        public static string Eliminar(int Id)
        {
            ProductoDatos objCategoria = new ProductoDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
