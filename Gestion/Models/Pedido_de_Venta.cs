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
    
    public partial class Pedido_de_Venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pedido_de_Venta()
        {
            this.Envio = new HashSet<Envio>();
            this.Venta_Estado = new HashSet<Venta_Estado>();
        }
    
        public string Cod_Pedido { get; set; }
        public string Cod_Producto { get; set; }
        public int Cantidad { get; set; }
        public string Cod_Cliente { get; set; }
        public string Direccion { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Envio> Envio { get; set; }
        public virtual Productos Productos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Estado> Venta_Estado { get; set; }
    }
}
