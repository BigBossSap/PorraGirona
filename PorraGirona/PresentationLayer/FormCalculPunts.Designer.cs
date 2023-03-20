
namespace PorraGirona.PresentationLayer
{
    partial class FormCalculPunts
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpuntuacioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpenyistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntuacioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntuacionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_prova = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntuacionsBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpuntuacioDataGridViewTextBoxColumn,
            this.idpenyistaDataGridViewTextBoxColumn,
            this.puntuacioDataGridViewTextBoxColumn,
            this.temporadaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.puntuacionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(410, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 474);
            this.dataGridView1.TabIndex = 0;
            // 
            // idpuntuacioDataGridViewTextBoxColumn
            // 
            this.idpuntuacioDataGridViewTextBoxColumn.DataPropertyName = "Idpuntuacio";
            this.idpuntuacioDataGridViewTextBoxColumn.HeaderText = "Idpuntuacio";
            this.idpuntuacioDataGridViewTextBoxColumn.Name = "idpuntuacioDataGridViewTextBoxColumn";
            // 
            // idpenyistaDataGridViewTextBoxColumn
            // 
            this.idpenyistaDataGridViewTextBoxColumn.DataPropertyName = "Idpenyista";
            this.idpenyistaDataGridViewTextBoxColumn.HeaderText = "Idpenyista";
            this.idpenyistaDataGridViewTextBoxColumn.Name = "idpenyistaDataGridViewTextBoxColumn";
            // 
            // puntuacioDataGridViewTextBoxColumn
            // 
            this.puntuacioDataGridViewTextBoxColumn.DataPropertyName = "Puntuacio";
            this.puntuacioDataGridViewTextBoxColumn.HeaderText = "Puntuacio";
            this.puntuacioDataGridViewTextBoxColumn.Name = "puntuacioDataGridViewTextBoxColumn";
            // 
            // temporadaDataGridViewTextBoxColumn
            // 
            this.temporadaDataGridViewTextBoxColumn.DataPropertyName = "Temporada";
            this.temporadaDataGridViewTextBoxColumn.HeaderText = "Temporada";
            this.temporadaDataGridViewTextBoxColumn.Name = "temporadaDataGridViewTextBoxColumn";
            // 
            // puntuacionsBindingSource
            // 
            this.puntuacionsBindingSource.DataSource = typeof(PorraGirona.DataLayer.Puntuacions);
            // 
            // bt_prova
            // 
            this.bt_prova.Location = new System.Drawing.Point(439, 25);
            this.bt_prova.Name = "bt_prova";
            this.bt_prova.Size = new System.Drawing.Size(285, 32);
            this.bt_prova.TabIndex = 1;
            this.bt_prova.Text = "Prova Insertar";
            this.bt_prova.UseVisualStyleBackColor = true;
            this.bt_prova.Click += new System.EventHandler(this.bt_prova_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // FormCalculPunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bt_prova);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCalculPunts";
            this.Text = "FormCalculPunts";
            this.Load += new System.EventHandler(this.FormPuntuacions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntuacionsBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpuntuacioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpenyistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntuacioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource puntuacionsBindingSource;
        private System.Windows.Forms.Button bt_prova;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}