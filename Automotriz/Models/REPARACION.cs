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
    
    public partial class REPARACION
    {
        public int ID_REPARACION { get; set; }
        public Nullable<int> ID_INGRESO { get; set; }
        public string DESCRIPCION { get; set; }
        public string NOMBRE_COMPLETO { get; set; }
        public Nullable<int> ID_EMPLEADO { get; set; }
        public Nullable<int> TOTAL_PIEZAS { get; set; }
        public Nullable<int> VALOR_TOTAL { get; set; }
        public Nullable<int> ID_REPUESTO { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
    
        public virtual EMPLEADO EMPLEADO { get; set; }
        public virtual INGRESO_VEHICULO INGRESO_VEHICULO { get; set; }
        public virtual REPUESTO REPUESTO { get; set; }
    }
}
