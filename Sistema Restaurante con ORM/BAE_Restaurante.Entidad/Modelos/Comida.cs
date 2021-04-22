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
    
    public partial class Comida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comida()
        {
            this.Pedido_Comida = new HashSet<Pedido_Comida>();
            this.Menu = new HashSet<Menu>();
        }
    
        public int id_comida { get; set; }
        public string nombre { get; set; }
        public Nullable<decimal> precio { get; set; }
        public int cantidad { get; set; }
        public string comentario { get; set; }
        public int id_tipo_comida { get; set; }
    
        public virtual Tipo_comida Tipo_comida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_Comida> Pedido_Comida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menu> Menu { get; set; }
    }
}
