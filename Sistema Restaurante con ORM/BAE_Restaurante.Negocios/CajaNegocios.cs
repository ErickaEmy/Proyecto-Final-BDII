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
    public class CajaNegocios
    {
        public static DataTable Listar()
        {
            CajaDatos objCategoria = new CajaDatos();
            return objCategoria.Listar();
        }

        public static string Insertar(DateTime fecha, double reserva, double ingreso, double egreso, string comentario)
        {
            CajaDatos objCategoria = new CajaDatos();
            string existe = objCategoria.Existe(fecha);
            if (existe.Equals("1"))
            {
                return "La caja del dia "+fecha+" ya esta registrada en la base de datos";
            }
            else
            {
                CajaEntidad objCategoriaE = new CajaEntidad();
                objCategoriaE.fecha = fecha;
                objCategoriaE.reserva = reserva;
                objCategoriaE.ingreso = ingreso;
                objCategoriaE.egreso = egreso;
                objCategoriaE.comentario = comentario;
                return objCategoria.Insertar(objCategoriaE);
            }
        }

        public static string Actualizar(int id_caja, DateTime fecha, double reserva, double ingreso, double egreso, string comentario)
        {
            CajaDatos objCategoria = new CajaDatos();
            string existe = objCategoria.Existe(fecha);
            CajaEntidad objCategoriaE = new CajaEntidad();
            objCategoriaE.id_caja = id_caja;
            objCategoriaE.fecha = fecha;
            objCategoriaE.reserva = reserva;
            objCategoriaE.ingreso = ingreso;
            objCategoriaE.egreso = egreso;
            objCategoriaE.comentario = comentario;
            return objCategoria.Actualizar(objCategoriaE);

        }

        public static string Actualizar2(DateTime fecha, double ingreso)
        {
            CajaDatos objCategoria = new CajaDatos();
            string existe = objCategoria.Existe(fecha);
            CajaEntidad objCategoriaE = new CajaEntidad();
            objCategoriaE.fecha = fecha;
            objCategoriaE.ingreso = ingreso;
            return objCategoria.Actualizar2(objCategoriaE);

        }

        public static string Actualizar3(DateTime fecha,double egreso)
        {
            CajaDatos objCategoria = new CajaDatos();
            CajaEntidad objCategoriaE = new CajaEntidad();
            objCategoriaE.fecha = fecha;
            objCategoriaE.egreso = egreso;
            return objCategoria.Actualizar3(objCategoriaE);

        }

        public static string Eliminar(int Id)
        {
            CajaDatos objCategoria = new CajaDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
