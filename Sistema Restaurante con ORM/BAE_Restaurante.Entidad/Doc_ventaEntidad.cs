using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAE_Restaurante.Entidad
{
    public class Doc_ventaEntidad
    {
        public int id_doc_venta { get; set; }
        public string tipo_doc_venta { get; set; }
        public int num_doc_venta { get; set; }
        public double venta_total { get; set; }
        public DateTime fecha { get; set; }
        public string comentario { get; set; }
        public int id_pedido { get; set; }
    }
}
