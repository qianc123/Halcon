//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Manager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Umbrales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Umbrales()
        {
            this.Alarmas = new HashSet<Alarmas>();
        }
    
        public int IdUmbral { get; set; }
        public int IdInsecto { get; set; }
        public long ValorMaximo { get; set; }
        public int IdProvincia { get; set; }
        public int IdMes { get; set; }
        public string Observaciones { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alarmas> Alarmas { get; set; }
        public virtual Insectos Insectos { get; set; }
        public virtual Provincias Provincias { get; set; }
    }
}
