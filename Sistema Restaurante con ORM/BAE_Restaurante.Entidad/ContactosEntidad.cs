using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAE_Restaurante.Entidad
{
    public class ContactosEntidad
    {
        public int id_contactos { get; set; }
        public string nombre { get; set; }
        public string tipo_contacto { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public DateTime fecha { get; set; }
        public string comentario { get; set; }
    }
}
