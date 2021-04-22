using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAE_Restaurante.Entidad
{
    public class MesaEntidad
    {
        public int id_mesa { get; set; }
        public string codigo { get; set; }
        public string estado { get; set; }
        public int asientos { get; set; }
    }
}
