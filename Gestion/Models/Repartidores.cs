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
    
    public partial class Repartidores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Repartidores()
        {
            this.Pedido_de_Venta = new HashSet<Pedido_de_Venta>();
        }
    
        public string Cod_Repartidor { get; set; }
        public int CI { get; set; }
        public string Telefono_Repartidor { get; set; }
        public string Nombre_Repartidor { get; set; }
        public string Placa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_de_Venta> Pedido_de_Venta { get; set; }
    }
}
