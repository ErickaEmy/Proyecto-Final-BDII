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
    public class UsuarioNegocios
    {
        public static DataTable Listar()
        {
            UsuarioDatos objCategoria = new UsuarioDatos();
            return objCategoria.Listar();
        }

        public static DataTable Buscar(string Busqueda)
        {
            UsuarioDatos objCategoria = new UsuarioDatos();
            return objCategoria.Buscar(Busqueda);
        }
        public static string Insertar(string usuario, string contrasena,string rol,string estado, int id_empleado)
        {
            UsuarioDatos objCategoria = new UsuarioDatos();
            string existe = objCategoria.Existe(usuario);
            if (existe.Equals("1"))
            {
                return "El usuario ya existe en la base de datos";
            }
            else
            {
                UsuarioEntidad objCategoriaE = new UsuarioEntidad();
                objCategoriaE.usuario = usuario;
                objCategoriaE.contrasena = contrasena;
                objCategoriaE.rol = rol;
                objCategoriaE.estado = Convert.ToBoolean( estado);
                objCategoriaE.id_empleado = id_empleado;
                return objCategoria.Insertar(objCategoriaE);
            }
        }

        public static string Actualizar(int id_usuario, string usuario, string contrasena, string rol, string estado, int id_empleado)
        {
            UsuarioDatos objCategoria = new UsuarioDatos();
            string existe = objCategoria.Existe(usuario);
            if (existe.Equals("1"))
            {
                return "El cliente ya existe en la base de datos";
            }
            else
            {
                UsuarioEntidad objCategoriaE = new UsuarioEntidad();
                objCategoriaE.id_usuario = id_usuario;
                objCategoriaE.usuario = usuario;
                objCategoriaE.contrasena = contrasena;
                objCategoriaE.rol = rol;
                objCategoriaE.estado = Convert.ToBoolean(estado);
                objCategoriaE.id_empleado = id_empleado;
                return objCategoria.Actualizar(objCategoriaE);
            }

        }

        public static string Eliminar(int Id)
        {
            UsuarioDatos objCategoria = new UsuarioDatos();
            return objCategoria.Eliminar(Id);
        }
        public static string Activar(int Id)
        {
            UsuarioDatos objCategoria = new UsuarioDatos();
            return objCategoria.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            UsuarioDatos objCategoria = new UsuarioDatos();
            return objCategoria.Desactivar(Id);
        }
    }
}
