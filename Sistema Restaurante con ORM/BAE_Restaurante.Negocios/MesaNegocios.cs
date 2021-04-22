using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAE_Restaurante.Datos;
using BAE_Restaurante.Entidad;
using System.Data;

namespace BAE_Restaurante.Negocios
{
    public class MesaNegocios
    {
        public static DataTable Listar()
        {
            MesaDatos objCategoria = new MesaDatos();
            return objCategoria.Listar();
        }

        public static DataTable ListarDisponibles()
        {
            MesaDatos objCategoria = new MesaDatos();
            return objCategoria.ListarDisponibles();
        }

        public static DataTable Buscar(string Busqueda)
        {
            MesaDatos objCategoria = new MesaDatos();
            return objCategoria.Buscar(Busqueda);
        }
        public static string Insertar(string codigo, string estado, int asientos)
        {
            MesaDatos objCategoria = new MesaDatos();
            MesaEntidad objCategoriaE = new MesaEntidad();
            objCategoriaE.codigo = codigo;
            objCategoriaE.estado = estado;
            objCategoriaE.asientos = asientos;
            return objCategoria.Insertar(objCategoriaE);

        }

        public static string Actualizar(int id_mesa, string codigo, string estado, int asientos)
        {
            MesaDatos objCategoria = new MesaDatos();
            MesaEntidad objCategoriaE = new MesaEntidad();
            objCategoriaE.id_mesa = id_mesa;
            objCategoriaE.codigo = codigo;
            objCategoriaE.estado = estado;
            objCategoriaE.asientos = asientos;
            return objCategoria.Actualizar(objCategoriaE);


        }

        public static string Eliminar(int Id)
        {
            MesaDatos objCategoria = new MesaDatos();
            return objCategoria.Eliminar(Id);
        }

    }
}
