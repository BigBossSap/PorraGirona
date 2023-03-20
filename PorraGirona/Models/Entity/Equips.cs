using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PorraGirona.Models.Entity
{
    public partial class Equips
    {
        public Equips()
        {
            Jugadors = new HashSet<Jugadors>();
            PartitsIdequiplocalNavigation = new HashSet<Partits>();
            PartitsIdequipvisitantNavigation = new HashSet<Partits>();
        }

        public int Idequip { get; set; }
        public string Nom { get; set; }
        public byte[] Imatge { get; set; }

        public virtual ICollection<Jugadors> Jugadors { get; set; }
        public virtual ICollection<Partits> PartitsIdequiplocalNavigation { get; set; }
        public virtual ICollection<Partits> PartitsIdequipvisitantNavigation { get; set; }
    }
}
