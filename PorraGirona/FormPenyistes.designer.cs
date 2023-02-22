namespace PorraGirona
{
    partial class FormPenyistes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip_BartStatus = new System.Windows.Forms.StatusStrip();
            this.BarraStatustoolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_NIF = new System.Windows.Forms.Label();
            this.label_Alias = new System.Windows.Forms.Label();
            this.label_Rol = new System.Windows.Forms.Label();
            this.label_cognoms = new System.Windows.Forms.Label();
            this.label_num_soci = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_data_alta = new System.Windows.Forms.Label();
            this.text_nom = new System.Windows.Forms.TextBox();
            this.text_nif = new System.Windows.Forms.TextBox();
            this.text_alias = new System.Windows.Forms.TextBox();
            this.text_cognoms = new System.Windows.Forms.TextBox();
            this.text_numsoci = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.button_afegir_foto = new System.Windows.Forms.Button();
            this.button_treure_imatge = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip_BartStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip_BartStatus
            // 
            this.statusStrip_BartStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BarraStatustoolStripStatus});
            this.statusStrip_BartStatus.Location = new System.Drawing.Point(0, 440);
            this.statusStrip_BartStatus.Name = "statusStrip_BartStatus";
            this.statusStrip_BartStatus.Size = new System.Drawing.Size(780, 22);
            this.statusStrip_BartStatus.TabIndex = 1;
            this.statusStrip_BartStatus.Text = "statusStrip1";
            // 
            // BarraStatustoolStripStatus
            // 
            this.BarraStatustoolStripStatus.Name = "BarraStatustoolStripStatus";
            this.BarraStatustoolStripStatus.Size = new System.Drawing.Size(23, 17);
            this.BarraStatustoolStripStatus.Text = "OK";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(241, 102);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(32, 13);
            this.label_nom.TabIndex = 2;
            this.label_nom.Text = "Nom:";
            // 
            // label_NIF
            // 
            this.label_NIF.AutoSize = true;
            this.label_NIF.Location = new System.Drawing.Point(241, 137);
            this.label_NIF.Name = "label_NIF";
            this.label_NIF.Size = new System.Drawing.Size(30, 13);
            this.label_NIF.TabIndex = 3;
            this.label_NIF.Text = "NIF: ";
            // 
            // label_Alias
            // 
            this.label_Alias.AutoSize = true;
            this.label_Alias.Location = new System.Drawing.Point(238, 171);
            this.label_Alias.Name = "label_Alias";
            this.label_Alias.Size = new System.Drawing.Size(35, 13);
            this.label_Alias.TabIndex = 4;
            this.label_Alias.Text = "Alias: ";
            // 
            // label_Rol
            // 
            this.label_Rol.AutoSize = true;
            this.label_Rol.Location = new System.Drawing.Point(244, 208);
            this.label_Rol.Name = "label_Rol";
            this.label_Rol.Size = new System.Drawing.Size(29, 13);
            this.label_Rol.TabIndex = 5;
            this.label_Rol.Text = "Rol: ";
            // 
            // label_cognoms
            // 
            this.label_cognoms.AutoSize = true;
            this.label_cognoms.Location = new System.Drawing.Point(488, 104);
            this.label_cognoms.Name = "label_cognoms";
            this.label_cognoms.Size = new System.Drawing.Size(57, 13);
            this.label_cognoms.TabIndex = 6;
            this.label_cognoms.Text = "Cognoms: ";
            // 
            // label_num_soci
            // 
            this.label_num_soci.AutoSize = true;
            this.label_num_soci.Location = new System.Drawing.Point(488, 142);
            this.label_num_soci.Name = "label_num_soci";
            this.label_num_soci.Size = new System.Drawing.Size(62, 13);
            this.label_num_soci.TabIndex = 7;
            this.label_num_soci.Text = "Num. Soci: ";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(488, 174);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(59, 13);
            this.label_Password.TabIndex = 8;
            this.label_Password.Text = "Password: ";
            // 
            // label_data_alta
            // 
            this.label_data_alta.AutoSize = true;
            this.label_data_alta.Location = new System.Drawing.Point(488, 208);
            this.label_data_alta.Name = "label_data_alta";
            this.label_data_alta.Size = new System.Drawing.Size(64, 13);
            this.label_data_alta.TabIndex = 9;
            this.label_data_alta.Text = "Data d\'alta: ";
            // 
            // text_nom
            // 
            this.text_nom.Location = new System.Drawing.Point(294, 95);
            this.text_nom.Name = "text_nom";
            this.text_nom.Size = new System.Drawing.Size(100, 20);
            this.text_nom.TabIndex = 11;
            // 
            // text_nif
            // 
            this.text_nif.Location = new System.Drawing.Point(294, 130);
            this.text_nif.Name = "text_nif";
            this.text_nif.Size = new System.Drawing.Size(100, 20);
            this.text_nif.TabIndex = 12;
            // 
            // text_alias
            // 
            this.text_alias.Location = new System.Drawing.Point(294, 168);
            this.text_alias.Name = "text_alias";
            this.text_alias.Size = new System.Drawing.Size(100, 20);
            this.text_alias.TabIndex = 13;
            // 
            // text_cognoms
            // 
            this.text_cognoms.Location = new System.Drawing.Point(563, 97);
            this.text_cognoms.Name = "text_cognoms";
            this.text_cognoms.Size = new System.Drawing.Size(100, 20);
            this.text_cognoms.TabIndex = 14;
            // 
            // text_numsoci
            // 
            this.text_numsoci.Location = new System.Drawing.Point(563, 135);
            this.text_numsoci.Name = "text_numsoci";
            this.text_numsoci.Size = new System.Drawing.Size(100, 20);
            this.text_numsoci.TabIndex = 15;
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(563, 171);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(100, 20);
            this.text_password.TabIndex = 16;
            // 
            // button_afegir_foto
            // 
            this.button_afegir_foto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_afegir_foto.Location = new System.Drawing.Point(12, 213);
            this.button_afegir_foto.Name = "button_afegir_foto";
            this.button_afegir_foto.Size = new System.Drawing.Size(20, 20);
            this.button_afegir_foto.TabIndex = 17;
            this.button_afegir_foto.Text = "+";
            this.button_afegir_foto.UseVisualStyleBackColor = false;
            this.button_afegir_foto.Click += new System.EventHandler(this.button_afegir_foto_Click);
            // 
            // button_treure_imatge
            // 
            this.button_treure_imatge.BackColor = System.Drawing.Color.Red;
            this.button_treure_imatge.Location = new System.Drawing.Point(38, 213);
            this.button_treure_imatge.Name = "button_treure_imatge";
            this.button_treure_imatge.Size = new System.Drawing.Size(20, 20);
            this.button_treure_imatge.TabIndex = 18;
            this.button_treure_imatge.Text = "-";
            this.button_treure_imatge.UseVisualStyleBackColor = false;
            this.button_treure_imatge.Click += new System.EventHandler(this.button_treure_imatge_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Soci",
            "Admin",
            "President",
            "Secretari",
            "Tresorer",
            "Vocal"});
            this.comboBox1.Location = new System.Drawing.Point(294, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(563, 205);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::PorraGirona.Properties.Resources.account_box_outline_custom__5_;
            this.pictureBox1.Image = global::PorraGirona.Properties.Resources.account_box_outline_custom__5_;
            this.pictureBox1.InitialImage = global::PorraGirona.Properties.Resources.account_box_outline_custom__5_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormPenyistes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(780, 462);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_treure_imatge);
            this.Controls.Add(this.button_afegir_foto);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_numsoci);
            this.Controls.Add(this.text_cognoms);
            this.Controls.Add(this.text_alias);
            this.Controls.Add(this.text_nif);
            this.Controls.Add(this.text_nom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_data_alta);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_num_soci);
            this.Controls.Add(this.label_cognoms);
            this.Controls.Add(this.label_Rol);
            this.Controls.Add(this.label_Alias);
            this.Controls.Add(this.label_NIF);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.statusStrip_BartStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPenyistes";
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.statusStrip_BartStatus.ResumeLayout(false);
            this.statusStrip_BartStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip_BartStatus;
        private System.Windows.Forms.ToolStripStatusLabel BarraStatustoolStripStatus;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_NIF;
        private System.Windows.Forms.Label label_Alias;
        private System.Windows.Forms.Label label_Rol;
        private System.Windows.Forms.Label label_cognoms;
        private System.Windows.Forms.Label label_num_soci;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_data_alta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox text_nom;
        private System.Windows.Forms.TextBox text_nif;
        private System.Windows.Forms.TextBox text_alias;
        private System.Windows.Forms.TextBox text_cognoms;
        private System.Windows.Forms.TextBox text_numsoci;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Button button_afegir_foto;
        private System.Windows.Forms.Button button_treure_imatge;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}