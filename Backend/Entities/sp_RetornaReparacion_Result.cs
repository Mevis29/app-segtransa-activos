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
    
    public partial class sp_RetornaReparacion_Result
    {
        public int IdReparacion { get; set; }
        public Nullable<int> IdActivo { get; set; }
        public string CodActivo { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> FechaInicialReparacion { get; set; }
        public Nullable<System.DateTime> FechafinalReparacion { get; set; }
        public string NombreProveedor { get; set; }
    }
}
