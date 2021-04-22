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
    
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            this.Control = new HashSet<Control>();
            this.Pedido = new HashSet<Pedido>();
            this.Usuario = new HashSet<Usuario>();
        }
    
        public int id_empleado { get; set; }
        public string dni { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public Nullable<System.DateTime> fecha_nacimiento { get; set; }
        public string direccion { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public bool estado { get; set; }
        public int id_cargo { get; set; }
    
        public virtual Cargo Cargo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Control> Control { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedido { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
