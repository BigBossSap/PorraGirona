using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace PorraGirona.PresentationLayer
{
    public partial class FormLogin : Form
    {

        string connectionString = "Data Source=localhost;Initial " +
            "Catalog=porragirona;" +
            "User ID=root;" +
            "Password=";
        public FormLogin()
        {
            InitializeComponent();
        }

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Placeholder or WaterMark
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        #endregion 

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            TestDBConnection();

            if (DBExisteixUsuari(txtuser.Text, txtpass.Text))
            {
                txtuser.Text = "";
                txtpass.Text = "";
                this.Hide();
                Principal newprincipal = new Principal();
                newprincipal.Show();
            }
            else
                MessageBox.Show("Usuari o Password incorrecte");
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

        /// <summary>
        /// Funció que comprova si existeix un usuaro
        /// </summary>
        /// <param name="nom">camp de la base de dades</param>
        /// <param name="password">password de la base de dades</param>
        /// <returns>true o false</returns>
        private Boolean DBExisteixUsuari(String nom, String password)
        {
            Boolean existeix = false;
            MySqlConnection DBConnection = new MySqlConnection(connectionString);
            try
            {
                DBConnection.Open();
                MySqlCommand sqlcommand = DBConnection.CreateCommand();
                sqlcommand.CommandText = "SELECT * FROM penyistes " +
                    "WHERE alias=@alias " +
                    "AND password=@password";
                sqlcommand.Parameters.AddWithValue("@alias", nom);
                sqlcommand.Parameters.AddWithValue("@password", password);
                sqlcommand.Prepare(); //Compila la consulta per també evitar SQLInjection
                var reader = sqlcommand.ExecuteReader();
                if (reader.Read())
                {
                    existeix = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
            return (existeix);
        }

      


    }
}
