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
    public class Reserva_MesaNegocios
    {
        public static DataTable Listar()
        {
            Reserva_MesaDatos objCategoria = new Reserva_MesaDatos();
            return objCategoria.Listar();
        }

        public static string Insertar(int id_mesa, int id_reserva)
        {
            Reserva_MesaDatos objCategoria = new Reserva_MesaDatos();
            Reserva_MesaEntidad objCategoriaE = new Reserva_MesaEntidad();
            objCategoriaE.id_mesa = id_mesa;
            objCategoriaE.id_reserva = id_reserva;
            return objCategoria.Insertar(objCategoriaE);

        }


        public static string Eliminar(int Id, int Id2)
        {
            Reserva_MesaDatos objCategoria = new Reserva_MesaDatos();
            return objCategoria.Eliminar(Id, Id2);
        }
    }
}
