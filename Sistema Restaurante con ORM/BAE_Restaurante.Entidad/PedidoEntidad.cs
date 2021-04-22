using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAE_Restaurante.Entidad
{
    public class PedidoEntidad
    {
        public int id_pedido { get; set; }
        public DateTime fecha { get; set; }
        public string tipo_pedido { get; set; }
        public string tipo_pago { get; set; }
        public int imagen_pago { get; set; }
        public string estado { get; set; }
        public string comentario { get; set; }
        public int id_empleado { get; set; }
        public int id_cliente { get; set; }
        public int id_mesa { get; set; }
        public string direccion_envio { get; set; }
    }
}
