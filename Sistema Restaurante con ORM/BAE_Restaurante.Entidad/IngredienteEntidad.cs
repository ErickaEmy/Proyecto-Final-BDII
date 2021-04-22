using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAE_Restaurante.Entidad
{
    public class IngredienteEntidad
    {
        public int id_ingrediente { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }
        public string comentario { get; set; }
        public int id_tipo_medida { get; set; }

    }
}
