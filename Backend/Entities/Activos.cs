//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backend.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Activos()
        {
            this.Depreciacion = new HashSet<Depreciacion>();
            this.THAsignaciones = new HashSet<THAsignaciones>();
            this.THReparaciones = new HashSet<THReparaciones>();
        }
    
        public int IdActivo { get; set; }
        public string CodActivo { get; set; }
        public Nullable<int> Categoria { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> PrecioInicial { get; set; }
        public Nullable<decimal> PrecioActual { get; set; }
        public Nullable<System.DateTime> FechaCompra { get; set; }
        public Nullable<int> Proveedor { get; set; }
        public Nullable<int> EstadoActivo { get; set; }
        public Nullable<int> Garantia { get; set; }
        public Nullable<int> MesesDepreciacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Depreciacion> Depreciacion { get; set; }
        public virtual Categorias Categorias { get; set; }
        public virtual EstadoActivos EstadoActivos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THAsignaciones> THAsignaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THReparaciones> THReparaciones { get; set; }
        public virtual Proveedores Proveedores { get; set; }
    }
}