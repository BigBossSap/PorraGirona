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
        String connectionString = Globals.connectionString;
        MySqlConnection DBConnection;
        MySqlDataAdapter adapter;
        DataTable table;


        
        public FormPenyistes()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            ConnectarBD();
        }
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DesconnectarBD();
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

        private Boolean ConnectarBD()
        {
            Boolean result = false;
            DBConnection = new MySqlConnection(connectionString);

            try
            {
                DBConnection.Open();
                result = true;

            }

            catch (Exception ex)
            {
                statusStrip_BartStatus.Text = "No es pot connectar a la base de dades";
                MessageBox.Show(statusStrip_BartStatus.Text);
            }

            return (result);

        }

        private void DesconnectarBD()
        {
            DBConnection.Close();
        }
    }
   
}
