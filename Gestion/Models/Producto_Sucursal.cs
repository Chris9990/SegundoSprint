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
    
    public partial class Producto_Sucursal
    {
        public string Cod_Producto { get; set; }
        public string Cod_Sucursal { get; set; }
        public int Stock { get; set; }
        public int Stock_minimo { get; set; }
    
        public virtual Productos Productos { get; set; }
        public virtual Sucursales Sucursales { get; set; }
    }
}
