using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAE_Restaurante.Entidad
{
    public class ComidaEntidad
    {
        public int id_comida { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }
        public string comentario { get; set; }
        public int id_tipo_comida { get; set; }

    }
}
