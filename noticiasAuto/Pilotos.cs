//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace noticiasAuto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pilotos
    {
        public int IdPiloto { get; set; }
        public string Nome { get; set; }
        public System.DateTime DataNascimento { get; set; }
        public string Nacionalidade { get; set; }
        public string Fotografia { get; set; }
        public int EquipaFK { get; set; }
    
        public virtual Equipas Equipas { get; set; }
    }
}
