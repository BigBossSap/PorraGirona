using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PorraGirona.Models.Entity
{
    public partial class Porres
    {
        public int Idporra { get; set; }
        public int? Golslocal { get; set; }
        public int? Golsvisitant { get; set; }
        public DateTime? Data { get; set; }
        public string Idsgolejadorslocal { get; set; }
        public string Idsgolejadorsvisitant { get; set; }
        public int? Idpenyista { get; set; }
        public int? Idpartit { get; set; }

        public virtual Partits IdpartitNavigation { get; set; }
        public virtual Penyistes IdpenyistaNavigation { get; set; }
    }
}
