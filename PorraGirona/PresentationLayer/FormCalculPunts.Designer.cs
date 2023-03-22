
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
            this.puntuacionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_prova = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.puntuacionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.puntuacionsBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntuacionsDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(896, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // puntuacionsDataGridView
            // 
            this.puntuacionsDataGridView.AllowUserToAddRows = false;
            this.puntuacionsDataGridView.AllowUserToDeleteRows = false;
            this.puntuacionsDataGridView.AutoGenerateColumns = false;
            this.puntuacionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.puntuacionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.puntuacionsDataGridView.DataSource = this.puntuacionsBindingSource;
            this.puntuacionsDataGridView.Location = new System.Drawing.Point(389, 151);
            this.puntuacionsDataGridView.Name = "puntuacionsDataGridView";
            this.puntuacionsDataGridView.Size = new System.Drawing.Size(245, 268);
            this.puntuacionsDataGridView.TabIndex = 2;
           
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Alias";
            this.dataGridViewTextBoxColumn3.HeaderText = "Alias";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Puntuacio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Puntuacio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FormCalculPunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 484);
            this.Controls.Add(this.puntuacionsDataGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bt_prova);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCalculPunts";
            this.Text = "FormCalculPunts";
            this.Load += new System.EventHandler(this.FormPuntuacions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.puntuacionsBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntuacionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource puntuacionsBindingSource;
        private System.Windows.Forms.Button bt_prova;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView puntuacionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}