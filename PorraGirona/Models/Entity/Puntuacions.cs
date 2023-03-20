using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PorraGirona.Models.Entity
{
    public partial class Puntuacions
    {
        public int Idpuntuacio { get; set; }
        public int Idpenyista { get; set; }
        public string Alias { get; set; }
        public int? Puntuacio { get; set; }
        public string Temporada { get; set; }
    }
}
