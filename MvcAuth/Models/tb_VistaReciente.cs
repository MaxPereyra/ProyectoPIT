//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcAuth.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_VistaReciente
    {
        public int idVistaReciente { get; set; }
        public int idCliente { get; set; }
        public int idDoctor { get; set; }
        public System.DateTime fecha { get; set; }
        public string notas { get; set; }
    
        public virtual tb_Cliente tb_Cliente { get; set; }
        public virtual tb_Doctor tb_Doctor { get; set; }
    }
}
