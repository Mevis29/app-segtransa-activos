//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backend.Entities
{
    using System;
    
    public partial class sp_obtenerActivos_Result
    {
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
    }
}
