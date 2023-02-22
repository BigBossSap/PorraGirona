//extern alias MySqlConnectorAlias;
//using MySql.Data.MySqlClient;

using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace PorraGirona
{
    public partial class Principal : Form
    {
        
        public Principal()
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
            open.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = new Bitmap(open.FileName);
            }   


        }

       

        private void button_treure_imatge_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
            pictureBox1.Image = pictureBox1.InitialImage;

            pictureBox1.Refresh();
        }
    }
   
}
