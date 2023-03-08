extern alias MySqlConnectorAlias;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PorraGirona.PresentationLayer
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

        private void TestDBConnection()
        {
            MySqlConnection DBConnection = new MySqlConnection(connectionString);
            try
            {
                DBConnection.Open();
                MessageBox.Show("DataBase Connection successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not connect to DataBase");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
        }
        private void FormPenyistes_Load(object sender, EventArgs e)
        {
            if (ConnectarBD())
                MessageBox.Show("Connectado");
            LoadDataOnDataGridview();
        }
        private void FormPenyistes_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button_afegir_Click(object sender, EventArgs e)
        {

            Boolean result = InserirPenyistaSQL();
            if (result)
            {
                BarraStatustoolStripStatus.Text = "Registre afegit";
                LoadDataOnDataGridview();
            }

            else
                BarraStatustoolStripStatus.Text = "No s'ha pogut afegir el registre";
                
        }

        private void LoadDataOnDataGridview()
        {
            string query = "SELECT nom, cognoms, nif, numsoci, rol, imatge, alias, password, dataalta FROM penyistes";
            try
            {
                MySqlCommand commandDatabase = new MySqlCommand(query, DBConnection);
                adapter = new MySqlDataAdapter(commandDatabase);
                table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.ReadOnly = true;

            }

            catch (Exception ex)
            {
                BarraStatustoolStripStatus.Text = "No s'ha`pogut carregar el grid";
                MessageBox.Show(ex.Message);
                    }
        
        }


        private Boolean InserirPenyistaSQL()
        {
            Boolean result = false;


            string query = "INSERT INTO penyistes(`nom`, `cognoms`, `nif`,`numsoci`, `rol`, `alias`, `password`, `dataalta`, `imatge`)VALUES (@nom, @cognoms, @nif, @numsoci, @rol, @alias, @password, @dataalta, @imatge)";

            try
            {
                MySqlCommand commandDatabase = new MySqlCommand(query, DBConnection);
                commandDatabase.Parameters.AddWithValue("@nom",text_nom.Text);
                commandDatabase.Parameters.AddWithValue("@cognoms", text_cognoms.Text);
                commandDatabase.Parameters.AddWithValue("@nif", text_nif.Text);
                commandDatabase.Parameters.AddWithValue("@numsoci", text_numsoci.Text);
                commandDatabase.Parameters.AddWithValue("@rol", comboBox1.Text);
                commandDatabase.Parameters.AddWithValue("@alias", text_alias.Text);
                commandDatabase.Parameters.AddWithValue("@password", text_password.Text);
                commandDatabase.Parameters.AddWithValue("@dataalta", dateTimePicker1.Value);

                //Codi per guardar la imatge
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] pic_array = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(pic_array, 0, pic_array.Length);
                commandDatabase.Parameters.Add("@imatge", MySqlDbType.MediumBlob);
                commandDatabase.Parameters["@imatge"].Value = pic_array;

                int res = commandDatabase.ExecuteNonQuery();
                if (res != 0) result = true;
            } catch(Exception ex)
            {

                result = false;
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }


            return result;
        }
    }
   
}
