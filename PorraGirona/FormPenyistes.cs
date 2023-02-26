extern alias MySqlConnectorAlias;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PorraGirona
{
    public partial class FormPenyistes : Form
    {
        
        public FormPenyistes()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
           
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

                pictureBox1.Image = new Bitmap(open.FileName);
            }   


        }

       

        private void button_treure_imatge_Click(object sender, EventArgs e)
        {
           
            pictureBox1.Image = pictureBox1.InitialImage;

            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormLogin login = new FormLogin();
            
            login.Show();
        }
    }
   
}
