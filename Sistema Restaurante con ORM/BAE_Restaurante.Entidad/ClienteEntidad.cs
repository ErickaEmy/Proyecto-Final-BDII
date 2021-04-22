using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAE_Restaurante.Entidad
{
    public class ClienteEntidad
    {
        public int id_cliente { get; set; }
        public string num_documento { get; set; }
        public string tipo_documento { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string celular { get; set; }
    }
}
