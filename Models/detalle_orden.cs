//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contro_de_Inventario.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalle_orden
    {
        public int iddetalleorden { get; set; }
        public Nullable<int> idorden { get; set; }
        public Nullable<int> idinventario { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public string estado { get; set; }
    
        public virtual inventario inventario { get; set; }
        public virtual ordenes ordenes { get; set; }
    }
}
