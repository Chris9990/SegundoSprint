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
    
    public partial class Repartidores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Repartidores()
        {
            this.Envio = new HashSet<Envio>();
        }
    
        public string Cod_Repartidor { get; set; }
        public int CI { get; set; }
        public string Telefono_Repartidor { get; set; }
        public string Nombre_Repartidor { get; set; }
        public string Placa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Envio> Envio { get; set; }
    }
}
