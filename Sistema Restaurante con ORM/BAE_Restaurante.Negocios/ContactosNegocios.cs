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
    public class ContactosNegocios
    {
        public static DataTable Listar()
        {
            ContactosDatos objCategoria = new ContactosDatos();
            return objCategoria.Listar();
        }

        public static DataTable Buscar(string Busqueda)
        {
            ContactosDatos objCategoria = new ContactosDatos();
            return objCategoria.Buscar(Busqueda);
        }
        public static string Insertar(string nombre, string tipo_contacto,  string celular, string email, DateTime fecha, string comentario)
        {
            ContactosDatos objCategoria = new ContactosDatos();
            string existe = objCategoria.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "El contacto ya existe en la base de datos";
            }
            else
            {
                ContactosEntidad objCategoriaE = new ContactosEntidad();
                objCategoriaE.nombre = nombre;
                objCategoriaE.tipo_contacto = tipo_contacto;
                objCategoriaE.celular = celular;
                objCategoriaE.email = email;
                objCategoriaE.fecha = fecha;
                objCategoriaE.comentario = comentario;
                return objCategoria.Insertar(objCategoriaE);
            }
        }

        public static string Actualizar(int id_contactos, string nombre, string tipo_contacto, string celular, string email, DateTime fecha, string comentario)
        {
            ContactosDatos objCategoria = new ContactosDatos();
            string existe = objCategoria.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "El contacto ya existe en la base de datos";
            }
            else
            {
                ContactosEntidad objCategoriaE = new ContactosEntidad();
                objCategoriaE.id_contactos = id_contactos;
                objCategoriaE.nombre = nombre;
                objCategoriaE.tipo_contacto = tipo_contacto;
                objCategoriaE.celular = celular;
                objCategoriaE.email = email;
                objCategoriaE.fecha = fecha;
                objCategoriaE.comentario = comentario;
                return objCategoria.Actualizar(objCategoriaE);
            }

        }

        public static string Eliminar(int Id)
        {
            ContactosDatos objCategoria = new ContactosDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
