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
    
    public partial class Detalle_de_Compras
    {
        public string Cod_Compra { get; set; }
        public string Cod_Producto { get; set; }
        public Nullable<int> Cantidad { get; set; }
    
        public virtual Compras Compras { get; set; }
        public virtual Productos Productos { get; set; }
    }
}