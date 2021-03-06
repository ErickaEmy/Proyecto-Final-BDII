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
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.Pedido_Producto = new HashSet<Pedido_Producto>();
            this.Doc_compra = new HashSet<Doc_compra>();
        }
    
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
        public System.DateTime fecha_vencimiento { get; set; }
        public decimal num_medida { get; set; }
        public string comentario { get; set; }
        public int id_tipo_producto { get; set; }
        public int id_tipo_medida { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_Producto> Pedido_Producto { get; set; }
        public virtual Tipo_producto Tipo_producto { get; set; }
        public virtual Tipo_medida Tipo_medida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doc_compra> Doc_compra { get; set; }
    }
}
