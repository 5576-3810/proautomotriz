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
    
    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            this.INGRESO_VEHICULO = new HashSet<INGRESO_VEHICULO>();
        }
    
        public int ID_CLIENTE { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public Nullable<int> TELEFONO { get; set; }
        public string LOCACION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGRESO_VEHICULO> INGRESO_VEHICULO { get; set; }
    }
}
