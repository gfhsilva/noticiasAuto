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
    
    public partial class Comentarios
    {
        public int IdComentario { get; set; }
        public string Conteudo { get; set; }
        public int NoticiaFK { get; set; }
        public int UserFK { get; set; }
    
        public virtual Noticias Noticias { get; set; }
        public virtual Utilizadores Utilizadores { get; set; }
    }
}
