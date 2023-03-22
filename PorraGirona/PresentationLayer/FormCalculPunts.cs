using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PorraGirona.Bussines_Layer;
using PorraGirona.DataLayer;

namespace PorraGirona.PresentationLayer
{
    public partial class FormCalculPunts : Form
    {
        GestioEntitats gestioEntitats;
        public FormCalculPunts()
        {
            InitializeComponent();
            gestioEntitats = new GestioEntitats();
        }

        private void FormPuntuacions_Load(object sender, EventArgs e)
        {
            LoadDataOnDataGridView();
        }



        private void LoadDataOnDataGridView()
        {
            puntuacionsBindingSource.DataSource = gestioEntitats.LlegirPuntuacions();
        }

        private void bt_prova_Click(object sender, EventArgs e)
        {
            
            gestioEntitats.CalcularPuntuacioEntity();
            toolStripStatusLabel1.Text = "Punts recalculats";
            LoadDataOnDataGridView();

        }

        
    }
}
