using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAE_Restaurante.Entidad
{
    public class ProductoEntidad
    {
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public double num_medida { get; set; }
        public string comentario { get; set; }
        public int id_tipo_producto { get; set; }
        public int id_tipo_medida { get; set; }
    }
}
