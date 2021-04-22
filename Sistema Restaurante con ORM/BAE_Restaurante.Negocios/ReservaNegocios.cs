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
    public class ReservaNegocios
    {
        public static DataTable Listar()
        {
            ReservaDatos objCategoria = new ReservaDatos();
            return objCategoria.Listar();
        }

        public static string Insertar(DateTime fecha, TimeSpan hora_inicio, TimeSpan hora_fin, int id_cliente)
        {
            ReservaDatos objCategoria = new ReservaDatos();
            ReservaEntidad objCategoriaE = new ReservaEntidad();
            objCategoriaE.fecha = fecha;
            objCategoriaE.hora_inicio = hora_inicio;
            objCategoriaE.hora_fin = hora_fin;
            objCategoriaE.id_cliente = id_cliente;
            return objCategoria.Insertar(objCategoriaE);

        }

        public static string Actualizar(int id_reserva, DateTime fecha, TimeSpan hora_inicio, TimeSpan hora_fin, int id_cliente)
        {
            ReservaDatos objCategoria = new ReservaDatos();
            ReservaEntidad objCategoriaE = new ReservaEntidad();
            objCategoriaE.id_reserva = id_reserva;
            objCategoriaE.fecha = fecha;
            objCategoriaE.hora_inicio = hora_inicio;
            objCategoriaE.hora_fin = hora_fin;
            objCategoriaE.id_cliente = id_cliente;
            return objCategoria.Actualizar(objCategoriaE);
        }

        public static string Eliminar(int Id)
        {
            MesaDatos objCategoria = new MesaDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
