//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BAE_Restaurante.Entidad.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedido_Comida
    {
        public int id_pedido { get; set; }
        public int id_comida { get; set; }
        public Nullable<int> cantidad { get; set; }
    
        public virtual Comida Comida { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
