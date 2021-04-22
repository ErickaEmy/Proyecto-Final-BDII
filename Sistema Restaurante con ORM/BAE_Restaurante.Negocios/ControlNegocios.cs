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
    public class ControlNegocios
    {
        public static DataTable Listar()
        {
            ControlDatos objCategoria = new ControlDatos();
            return objCategoria.Listar();
        }

        public static DataTable Buscar(string Busqueda)
        {
            ControlDatos objCategoria = new ControlDatos();
            return objCategoria.Buscar(Busqueda);
        }
        public static string Insertar(DateTime fecha, TimeSpan hora_inicio, TimeSpan hora_fin, string falta,int id_empleado)
        {
            ControlDatos objCategoria = new ControlDatos();
            
                ControlEntidad objCategoriaE = new ControlEntidad();
                objCategoriaE.fecha = fecha;
                objCategoriaE.hora_inicio = hora_inicio;
                objCategoriaE.hora_fin = hora_fin;
                objCategoriaE.falta = falta;
                objCategoriaE.id_empleado = id_empleado;
                return objCategoria.Insertar(objCategoriaE);
            
        }

        public static string Actualizar(int id_control,DateTime fecha, TimeSpan hora_inicio, TimeSpan hora_fin, string falta, int id_empleado)
        {
            ControlDatos objCategoria = new ControlDatos();
           
                ControlEntidad objCategoriaE = new ControlEntidad();
                objCategoriaE.id_control = id_control;
                objCategoriaE.fecha = fecha;
                objCategoriaE.hora_inicio = hora_inicio;
                objCategoriaE.hora_fin = hora_fin;
                objCategoriaE.falta = falta;
                objCategoriaE.id_empleado = id_empleado;
                return objCategoria.Actualizar(objCategoriaE);
            

        }

        public static string Eliminar(int Id)
        {
            ControlDatos objCategoria = new ControlDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
