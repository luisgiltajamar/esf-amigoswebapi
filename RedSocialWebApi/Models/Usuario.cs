//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RedSocialWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.Amigos = new HashSet<Amigos>();
            this.Amigos1 = new HashSet<Amigos>();
            this.MensajePrivado = new HashSet<MensajePrivado>();
            this.MensajePrivado1 = new HashSet<MensajePrivado>();
            this.MensajePublico = new HashSet<MensajePublico>();
        }
    
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
    
        public virtual ICollection<Amigos> Amigos { get; set; }
        public virtual ICollection<Amigos> Amigos1 { get; set; }
        public virtual ICollection<MensajePrivado> MensajePrivado { get; set; }
        public virtual ICollection<MensajePrivado> MensajePrivado1 { get; set; }
        public virtual ICollection<MensajePublico> MensajePublico { get; set; }
    }
}
