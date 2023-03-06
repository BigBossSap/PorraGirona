

using PorraGirona.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PorraGirona.Bussines_Layer;

namespace PorraGirona
{
    //public partial class FormPenyistesEntity : Form
    //{
    //    PostDbContext context;
    //    public FormPenyistesEntity()
    //    {
    //        InitializeComponent();
    //        context = new PostDbContext();
    //    }

    public partial class FormPenyistesEntity : Form
    {
        GestioEntitats gestioEntitats;
        public FormPenyistesEntity()
        {
            InitializeComponent();
            gestioEntitats = new GestioEntitats();
        }


        private void FormPenyistesEntity_Load(object sender, EventArgs e)
        {
            penyistesBindingSource.DataSource = context.Penyistes.ToList();
        }

        private void b_nou_Click(object sender, EventArgs e)
        {
            penyistesBindingSource.AddNew();
        }

        private void b_afegir_Click(object sender, EventArgs e)
        {
            int result;
             result= InserirPenyistaEntity();

            if (result == 1)
            {
                toolStripStatusLabel1.Text = "Registre afegit";
            }

            else if (result==0)
            {
                toolStripStatusLabel1.Text = "No s'ha pogut afegir";
            }
        }
        
        private int InserirPenyistaEntity()
        {
            int result = 0;

            Penyistes penyista;

            penyista = (Penyistes)penyistesBindingSource.Current;
            if (penyista == null) penyista = new Penyistes();


            penyista.Nom = nomTextBox.Text;
            penyista.Cognoms = cognomsTextBox.Text;
            penyista.Nif = nifTextBox.Text;
            penyista.Numsoci = numsociTextBox.Text;
            penyista.Rol = rolComboBox.Text;
            penyista.Alias = aliasTextBox.Text;
            penyista.Password = passwordTextBox.Text;
            penyista.Dataalta = dataaltaDateTimePicker.Value;

            //Codi per guardar la imatge
            if (imatgePictureBox.Image == null) imatgePictureBox.Image = PorraGirona.Properties.Resources.logo;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imatgePictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] pic_array = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(pic_array, 0, pic_array.Length);
            penyista.Imatge = pic_array;

            try
            {   //Per guardar el penyista en el Entity (en la RAM)
                context.Penyistes.Add(penyista);
                //Per guardar tot en la base de dades (en el Disc)
                if (context.SaveChanges() > 0) result = 1;
                else result = 0;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                result = 0;
            }
            return (result);
        }

        private void b_esborrar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Realment vols esborrar?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Penyistes penyista = (Penyistes)penyistesBindingSource.Current;
                Delete(penyista);
                toolStripStatusLabel1.Text = "Esborrat";
                penyistesBindingSource.DataSource = context.Penyistes.ToList();
            }
        }

        private Boolean Delete(Penyistes penyista)
        {
            Boolean result = false;
            PostDbContext context = new PostDbContext();
            if(penyista!=null)
            {
                try
                {
                    context.Penyistes.Remove(penyista);
                    result = (context.SaveChanges() > 0);
                }

                catch (Exception ex)
                {
                    Debug.WriteLine(ex);

                }
            }

            return result;


        }
    }


}
