using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BAE_Restaurante.Datos;
using BAE_Restaurante.Entidad;

namespace BAE_Restaurante.Negocios
{
    public class EmpleadoNegocios
    {   
        public static DataTable Listar()
        {
            EmpleadoDatos objCategoria = new EmpleadoDatos();
            return objCategoria.Listar();
        }

        public static string Insertar(string dni, string nombres, string apellidos, DateTime fecha, string direccion, string celular, string email,string estado, int id_cargo)
        {
            EmpleadoDatos objCategoria = new EmpleadoDatos();
            EmpleadoEntidad objCategoriaE = new EmpleadoEntidad();
            objCategoriaE.dni = dni;
            objCategoriaE.nombres = nombres;
            objCategoriaE.apellidos = apellidos;
            objCategoriaE.fecha_nacimiento = fecha;
            objCategoriaE.direccion = direccion;
            objCategoriaE.celular = celular;
            objCategoriaE.email = email;
            objCategoriaE.estado = Convert.ToBoolean(estado);
            objCategoriaE.id_cargo = id_cargo;
            objCategoriaE.dni = dni;

            return objCategoria.Insertar(objCategoriaE);

        }

        public static string Actualizar(int id_empleado, string dni, string nombres, string apellidos, DateTime fecha, string direccion, string celular,string email , string estado, int id_cargo)
        {
            EmpleadoDatos objCategoria = new EmpleadoDatos();
            EmpleadoEntidad objCategoriaE = new EmpleadoEntidad();
            objCategoriaE.id_empleado = id_empleado;
            objCategoriaE.dni = dni;
            objCategoriaE.nombres = nombres;
            objCategoriaE.apellidos = apellidos;
            objCategoriaE.fecha_nacimiento = fecha;
            objCategoriaE.direccion = direccion;
            objCategoriaE.celular = celular;
            objCategoriaE.email = email;
            objCategoriaE.estado = Convert.ToBoolean(estado);
            objCategoriaE.id_cargo = id_cargo;
            objCategoriaE.dni = dni;

            return objCategoria.Actualizar(objCategoriaE);

        }

        public static string Eliminar(int Id)
        {
            EmpleadoDatos objCategoria = new EmpleadoDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
