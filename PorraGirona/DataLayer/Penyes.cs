﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PorraGirona.DataLayer
{
    public partial class Penyes
    {
        public Penyes()
        {
            Penyistes = new HashSet<Penyistes>();
        }

        public int Idpenya { get; set; }
        public string Nom { get; set; }

        public virtual ICollection<Penyistes> Penyistes { get; set; }
    }
}
