﻿

using PorraGirona.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PorraGirona
{
    public partial class FormPenyistesEntity : Form
    {
        PostDbContext context;
        public FormPenyistesEntity()
        {
            InitializeComponent();
            context = new PostDbContext();
        }


        private void FormPenyistesEntity_Load(object sender, EventArgs e)
        {
            penyistesBindingSource2.DataSource = context.Penyistes.ToList();
    }
    }

   
}
