//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Automotriz.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class REPUESTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REPUESTO()
        {
            this.REPARACION = new HashSet<REPARACION>();
        }
    
        public int ID_REPUESTO { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public string ESTADO { get; set; }
        public Nullable<int> PRECIO { get; set; }
        public string DETALLE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPARACION> REPARACION { get; set; }
    }
}
