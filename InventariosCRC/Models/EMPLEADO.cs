//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventariosCRC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPLEADO
    {
        public int IDEmpleado { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string TipoUsuario { get; set; }
        public Nullable<int> IDPersona { get; set; }
        public string Correo { get; set; }
    
        public virtual PERSONA PERSONA { get; set; }
    }
}
