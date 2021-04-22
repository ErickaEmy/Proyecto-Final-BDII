using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAE_Restaurante.Entidad
{
    public class Pedido_ProductoEntidad
    {
        public int id_pedido { get; set; }
        public int id_producto { get; set; }
        public int cantidad { get; set; }

    }
}
