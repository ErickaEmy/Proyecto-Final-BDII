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
    public class IngredienteNegocios
    {
        public static DataTable Listar()
        {
            IngredienteDatos objCategoria = new IngredienteDatos();
            return objCategoria.Listar();
        }

        public static DataTable Buscar(string Busqueda)
        {
            IngredienteDatos objCategoria = new IngredienteDatos();
            return objCategoria.Buscar(Busqueda);
        }
        public static string Insertar(string nombre, double precio, int cantidad, string comentario, int id_tipo_medida)
        {
            IngredienteDatos objCategoria = new IngredienteDatos();
            string existe = objCategoria.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "El ingrediente ya existe en la base de datos";
            }
            else
            {
                IngredienteEntidad objCategoriaE = new IngredienteEntidad();
                objCategoriaE.nombre = nombre;
                objCategoriaE.precio = precio;
                objCategoriaE.cantidad = cantidad;
                objCategoriaE.comentario = comentario;
                objCategoriaE.id_tipo_medida = id_tipo_medida;
                return objCategoria.Insertar(objCategoriaE);
            }
        }

        public static string Actualizar(int id_ingrediente, string nombre, double precio, int cantidad, string comentario, int id_tipo_medida)
        {
            IngredienteDatos objCategoria = new IngredienteDatos();
            string existe = objCategoria.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "El cliente ya existe en la base de datos";
            }
            else
            {
                IngredienteEntidad objCategoriaE = new IngredienteEntidad();
                objCategoriaE.id_ingrediente = id_ingrediente;
                objCategoriaE.nombre = nombre;
                objCategoriaE.precio = precio;
                objCategoriaE.cantidad = cantidad;
                objCategoriaE.comentario = comentario;
                objCategoriaE.id_tipo_medida = id_tipo_medida;
                return objCategoria.Actualizar(objCategoriaE);
            }

        }

        public static string Eliminar(int Id)
        {
            IngredienteDatos objCategoria = new IngredienteDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
