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
    
    public partial class INGRESO_VEHICULO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INGRESO_VEHICULO()
        {
            this.REPARACION = new HashSet<REPARACION>();
        }
    
        public int ID_INGRESO { get; set; }
        public Nullable<int> ID_CLIENTE { get; set; }
        public Nullable<int> ID_MARCA { get; set; }
        public string COLOR { get; set; }
        public string MODELO { get; set; }
        public string PLACA { get; set; }
        public Nullable<System.DateTime> FECHA_INGRESO { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<int> ID_TALLER { get; set; }
        public Nullable<System.DateTime> FECHA_ING { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual MARCA MARCA { get; set; }
        public virtual TALLER TALLER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPARACION> REPARACION { get; set; }
    }
}