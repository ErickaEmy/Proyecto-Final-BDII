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
    public class EmpresaNegocios
    {
        public static DataTable Listar()
        {
            EmpresaDatos objCategoria = new EmpresaDatos();
            return objCategoria.Listar();
        }

        /*public static DataTable Buscar(string Busqueda)
        {
            EmpresaDatos objCategoria = new EmpresaDatos();
            return objCategoria.Buscar(Busqueda);
        }*/
        public static string Insertar(string caracteristica, string descripcion)
        {
            EmpresaDatos objCategoria = new EmpresaDatos();
            
                EmpresaEntidad objCategoriaE = new EmpresaEntidad();
                objCategoriaE.caracteristica = caracteristica;
                objCategoriaE.descripcion = descripcion;
                return objCategoria.Insertar(objCategoriaE);
            
        }

        public static string Actualizar(int id_empresa, string caracteristica, string descripcion)
        {
            EmpresaDatos objCategoria = new EmpresaDatos();
            
                EmpresaEntidad objCategoriaE = new EmpresaEntidad();
                objCategoriaE.id_empresa = id_empresa;
                objCategoriaE.caracteristica = caracteristica;
                objCategoriaE.descripcion = descripcion;
                return objCategoria.Actualizar(objCategoriaE);
            

        }

        public static string Eliminar(int Id)
        {
            EmpresaDatos objCategoria = new EmpresaDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
