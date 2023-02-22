using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PorraGirona
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }

        private void buttonSortir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Realment vols sortir?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }

        }
        private void button_Login_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text == "admin" && textBox_Password.Text == "12345")
            {
                textBox_Username.Text = "";
                textBox_Username.Text = "";

                

                this.Hide();

                Principal newprincipal = new Principal();

                newprincipal.Show();


            }

            else
                MessageBox.Show("Usuari o Password incorrecte");
                
        }


    }
}
