//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Compras
    {
        public string Cod_Compra { get; set; }
        public string Cod_Prov { get; set; }
        public System.DateTime Fecha_Compra { get; set; }
        public int Cantidad { get; set; }
    
        public virtual Proveedores Proveedores { get; set; }
        public virtual Detalle_de_Compras Detalle_de_Compras { get; set; }
    }
}
