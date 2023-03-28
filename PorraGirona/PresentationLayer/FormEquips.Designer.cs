namespace PorraGirona.PresentationLayer
{
    partial class FormEquips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEquips));
            this.equipsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.equipsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.equipsDataGridView = new System.Windows.Forms.DataGridView();
            this.bt_afegir = new System.Windows.Forms.Button();
            this.bt_esborrar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_afegir_foto = new System.Windows.Forms.Button();
            this.imatgeEquip = new System.Windows.Forms.PictureBox();
            this.nomEquip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.equipsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.equipsBindingNavigator)).BeginInit();
            this.equipsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipsDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imatgeEquip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // equipsBindingNavigator
            // 
            this.equipsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.equipsBindingNavigator.BindingSource = this.equipsBindingSource;
            this.equipsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.equipsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.equipsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.equipsBindingNavigatorSaveItem});
            this.equipsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.equipsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.equipsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.equipsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.equipsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.equipsBindingNavigator.Name = "equipsBindingNavigator";
            this.equipsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.equipsBindingNavigator.Size = new System.Drawing.Size(913, 25);
            this.equipsBindingNavigator.TabIndex = 0;
            this.equipsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // equipsBindingNavigatorSaveItem
            // 
            this.equipsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.equipsBindingNavigatorSaveItem.Enabled = false;
            this.equipsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("equipsBindingNavigatorSaveItem.Image")));
            this.equipsBindingNavigatorSaveItem.Name = "equipsBindingNavigatorSaveItem";
            this.equipsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.equipsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // equipsDataGridView
            // 
            this.equipsDataGridView.AutoGenerateColumns = false;
            this.equipsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1});
            this.equipsDataGridView.DataSource = this.equipsBindingSource;
            this.equipsDataGridView.Location = new System.Drawing.Point(25, 52);
            this.equipsDataGridView.Name = "equipsDataGridView";
            this.equipsDataGridView.Size = new System.Drawing.Size(407, 321);
            this.equipsDataGridView.TabIndex = 1;
            // 
            // bt_afegir
            // 
            this.bt_afegir.Location = new System.Drawing.Point(438, 52);
            this.bt_afegir.Name = "bt_afegir";
            this.bt_afegir.Size = new System.Drawing.Size(75, 23);
            this.bt_afegir.TabIndex = 2;
            this.bt_afegir.Text = "Afegir Nou";
            this.bt_afegir.UseVisualStyleBackColor = true;
            this.bt_afegir.Click += new System.EventHandler(this.bt_afegir_Click);
            // 
            // bt_esborrar
            // 
            this.bt_esborrar.Location = new System.Drawing.Point(438, 81);
            this.bt_esborrar.Name = "bt_esborrar";
            this.bt_esborrar.Size = new System.Drawing.Size(75, 23);
            this.bt_esborrar.TabIndex = 3;
            this.bt_esborrar.Text = "Esborrar";
            this.bt_esborrar.UseVisualStyleBackColor = true;
            this.bt_esborrar.Click += new System.EventHandler(this.bt_esborrar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(913, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Afegir Definitiu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_AfegirDefinitiu);
            // 
            // button_afegir_foto
            // 
            this.button_afegir_foto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_afegir_foto.Location = new System.Drawing.Point(566, 147);
            this.button_afegir_foto.Name = "button_afegir_foto";
            this.button_afegir_foto.Size = new System.Drawing.Size(20, 20);
            this.button_afegir_foto.TabIndex = 18;
            this.button_afegir_foto.Text = "+";
            this.button_afegir_foto.UseVisualStyleBackColor = false;
            this.button_afegir_foto.Click += new System.EventHandler(this.button_afegir_foto_Click);
            // 
            // imatgeEquip
            // 
            this.imatgeEquip.ErrorImage = global::PorraGirona.Properties.Resources.logo;
            this.imatgeEquip.Image = global::PorraGirona.Properties.Resources.logo;
            this.imatgeEquip.InitialImage = global::PorraGirona.Properties.Resources.logo;
            this.imatgeEquip.Location = new System.Drawing.Point(566, 28);
            this.imatgeEquip.Name = "imatgeEquip";
            this.imatgeEquip.Size = new System.Drawing.Size(100, 113);
            this.imatgeEquip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imatgeEquip.TabIndex = 19;
            this.imatgeEquip.TabStop = false;
            // 
            // nomEquip
            // 
            this.nomEquip.Location = new System.Drawing.Point(535, 213);
            this.nomEquip.Name = "nomEquip";
            this.nomEquip.Size = new System.Drawing.Size(100, 20);
            this.nomEquip.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nou nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nova  Imatge:";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Imatge";
            this.dataGridViewImageColumn1.HeaderText = "Imatge";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // equipsBindingSource
            // 
            this.equipsBindingSource.DataSource = typeof(PorraGirona.DataLayer.Equips);
            // 
            // FormEquips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomEquip);
            this.Controls.Add(this.imatgeEquip);
            this.Controls.Add(this.button_afegir_foto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bt_esborrar);
            this.Controls.Add(this.bt_afegir);
            this.Controls.Add(this.equipsDataGridView);
            this.Controls.Add(this.equipsBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEquips";
            this.Text = "FormEquips";
            this.Load += new System.EventHandler(this.FormPenyistesEntity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipsBindingNavigator)).EndInit();
            this.equipsBindingNavigator.ResumeLayout(false);
            this.equipsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipsDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imatgeEquip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource equipsBindingSource;
        private System.Windows.Forms.BindingNavigator equipsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton equipsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView equipsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button bt_afegir;
        private System.Windows.Forms.Button bt_esborrar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_afegir_foto;
        private System.Windows.Forms.PictureBox imatgeEquip;
        private System.Windows.Forms.TextBox nomEquip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}