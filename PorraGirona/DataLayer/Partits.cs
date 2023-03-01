using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PorraGirona.DataLayer
{
    public partial class Partits
    {
        public Partits()
        {
            Porres = new HashSet<Porres>();
        }

        public int Idpartit { get; set; }
        public int? Idequiplocal { get; set; }
        public int? Idequipvisitant { get; set; }
        public DateTime? Datainici { get; set; }
        public int? Jornada { get; set; }
        public int? Golslocal { get; set; }
        public int? Golsvisitant { get; set; }
        public string Finalitzat { get; set; }
        public string Temporada { get; set; }
        public string Idsjugadorslocal { get; set; }
        public string Idsjugadorsvisitant { get; set; }

        public virtual Equips IdequiplocalNavigation { get; set; }
        public virtual Equips IdequipvisitantNavigation { get; set; }
        public virtual ICollection<Porres> Porres { get; set; }
    }
}
