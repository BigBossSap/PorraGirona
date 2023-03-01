using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PorraGirona.DataLayer
{
    public partial class Jugadors
    {
        public int Idjugador { get; set; }
        public string Nom { get; set; }
        public int? Idequip { get; set; }
        public string Temporada { get; set; }

        public virtual Equips IdequipNavigation { get; set; }
    }
}
