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
    
    public partial class Alarmas
    {
        public int IdAlarma { get; set; }
        public int IdRelevamiento { get; set; }
        public int IdUmbral { get; set; }
        public long ValorMaximo { get; set; }
        public string Observaciones { get; set; }
    
        public virtual Relevamientos Relevamientos { get; set; }
        public virtual Umbrales Umbrales { get; set; }
    }
}
