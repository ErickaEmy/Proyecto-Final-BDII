using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAE_Restaurante.Entidad
{
    public class CajaEntidad
    {
        public int id_caja { get; set; }
        public DateTime fecha { get; set; }
        public double reserva { get; set; }
        public double ingreso { get; set; }
        public double egreso { get; set; }
        public string comentario { get; set; }
    }
}
