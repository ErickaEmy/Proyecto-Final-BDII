using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAE_Restaurante.Entidad
{
    public class EmpleadoEntidad
    {
		public int id_empleado { get; set; }
		public string dni { get; set; }
		public string nombres { get; set; }
		public string apellidos { get; set; }
		public DateTime fecha_nacimiento { get; set; }
		public string direccion { get; set; }
		public string celular { get; set; }
		public string email { get; set; }
		public bool estado { get; set; }
		public int id_cargo { get; set; }
    }
}
