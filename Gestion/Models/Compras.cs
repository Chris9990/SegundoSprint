//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
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
    
        public virtual Proveedores Proveedores { get; set; }
        public virtual Detalle_de_Compras Detalle_de_Compras { get; set; }
    }
}
