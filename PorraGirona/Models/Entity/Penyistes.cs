using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PorraGirona.Models.Entity
{
    public partial class Penyistes
    {
        public Penyistes()
        {
            Porres = new HashSet<Porres>();
        }

        public int Idpenyista { get; set; }
        public string Nom { get; set; }
        public string Cognoms { get; set; }
        public string Nif { get; set; }
        public string Numsoci { get; set; }
        public string Rol { get; set; }
        public string Alias { get; set; }
        public string Password { get; set; }
        public DateTime? Dataalta { get; set; }
        public byte[] Imatge { get; set; }
        public int? Idpenya { get; set; }

        public virtual Penyes IdpenyaNavigation { get; set; }
        public virtual ICollection<Porres> Porres { get; set; }
    }
}
