using PorraGirona.Bussines_Layer;
using PorraGirona.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PorraGirona.PresentationLayer
{
    public partial class FormEquips : Form
    {
        GestioEntitats gestioEntitats;
        public FormEquips()
        {
            InitializeComponent();
            gestioEntitats = new GestioEntitats();

        }

        private void FormPenyistesEntity_Load(object sender, EventArgs e)
        {
            LoadDataOnDataGridView();

        }


        private void LoadDataOnDataGridView()
        {
            equipsBindingSource.DataSource = gestioEntitats.LlegirEquips();

        }

        private void bt_afegir_Click(object sender, EventArgs e)
        {
            equipsBindingSource.AddNew();
        }

        private void bt_esborrar_Click(object sender, EventArgs e)
        {
            Equips equip = (Equips)equipsBindingSource.Current;
            DialogResult res = MessageBox.Show("Realment vols esborrar?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Boolean result = false;
                result = EsborrarEquipEntityBussinesLayer(equip);

                if (result)
                {
                    LoadDataOnDataGridView();
                    toolStripStatusLabel1.Text = " Registre Esborrat";
                }
                else
                {
                    MessageBox.Show("No s'ha pogut esborrar el registre");
                    LoadDataOnDataGridView();
                    toolStripStatusLabel1.Text = "No s'ha pogut esborrar el registre";
                }

            }
        }

        public Boolean EsborrarEquipEntityBussinesLayer(Equips equips)
        {
            Boolean result = false;
            result = gestioEntitats.EsborrarEquip(equips);
            return result;

        }

        private void button_afegir_foto_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();

            open.InitialDirectory = Environment.CurrentDirectory;
            open.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|" +
                "*.BMP;*.JPG;*.GIF;*.PNG|" +
                "All files (*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {

                imatgeEquip.Image = new Bitmap(open.FileName);
            }



        }


        private Boolean InserirEquipEntityBussinesLayer()
        {

            Boolean result = false;
            Equips equip = new Equips();
            equip.Nom = nomEquip.Text;
            if (imatgeEquip.Image == null) imatgeEquip.Image = PorraGirona.Properties.Resources.logo;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imatgeEquip.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] pic_array = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(pic_array, 0, pic_array.Length);
            equip.Imatge = pic_array;

            result = gestioEntitats.InserirEquip(equip);


            return result;
        }

        private void button_AfegirDefinitiu(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Boolean result = false;
            result = InserirEquipEntityBussinesLayer();
            if (result)
            {
                LoadDataOnDataGridView();
                toolStripStatusLabel1.Text = "Afegit";
            }
            else
            {
                toolStripStatusLabel1.Text = " No Afegit";
            }

            stopwatch.Stop();
            toolStripStatusLabel1.Text = toolStripStatusLabel1.Text + ", in " + stopwatch.ElapsedMilliseconds;
        }


    }
}
