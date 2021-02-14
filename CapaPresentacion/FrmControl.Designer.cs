namespace CapaPresentacion
{
    partial class FrmControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControl));
            this.label3 = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.dgvVacunas = new System.Windows.Forms.DataGridView();
            this.lblAgregarVacuna = new System.Windows.Forms.LinkLabel();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.paneAgregarVacuna = new System.Windows.Forms.Panel();
            this.lblAgregar = new System.Windows.Forms.LinkLabel();
            this.llblCerrarAgragarVacuna = new System.Windows.Forms.LinkLabel();
            this.txtVacuna = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbDosis = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbNombreVacuna = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbxNuevoControl = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunas)).BeginInit();
            this.paneAgregarVacuna.SuspendLayout();
            this.gbxNuevoControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 15);
            this.label3.TabIndex = 96;
            this.label3.Text = "ULTIMOS CONTROLES QUE SE LE REALIZO A LA MASCOTA";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToOrderColumns = true;
            this.dgvListado.AllowUserToResizeRows = false;
            this.dgvListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(209)))));
            this.dgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(104)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListado.EnableHeadersVisualStyles = false;
            this.dgvListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.dgvListado.Location = new System.Drawing.Point(16, 50);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersVisible = false;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(624, 120);
            this.dgvListado.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 201;
            this.label2.Text = "Peso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 203;
            this.label5.Text = "Kilogramos.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 214;
            this.label9.Text = "Talla:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 216;
            this.label1.Text = "Centimetros.";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.ForeColor = System.Drawing.Color.DimGray;
            this.txtObservacion.Location = new System.Drawing.Point(4, 94);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(255, 74);
            this.txtObservacion.TabIndex = 218;
            this.txtObservacion.Text = "Escriba una observación...";
            this.txtObservacion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtObservacion_MouseClick);
            this.txtObservacion.Leave += new System.EventHandler(this.txtObservacion_Leave);
            // 
            // dgvVacunas
            // 
            this.dgvVacunas.AllowUserToAddRows = false;
            this.dgvVacunas.AllowUserToDeleteRows = false;
            this.dgvVacunas.AllowUserToOrderColumns = true;
            this.dgvVacunas.AllowUserToResizeRows = false;
            this.dgvVacunas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(209)))));
            this.dgvVacunas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVacunas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(104)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVacunas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVacunas.EnableHeadersVisualStyles = false;
            this.dgvVacunas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.dgvVacunas.Location = new System.Drawing.Point(279, 53);
            this.dgvVacunas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVacunas.Name = "dgvVacunas";
            this.dgvVacunas.ReadOnly = true;
            this.dgvVacunas.RowHeadersVisible = false;
            this.dgvVacunas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVacunas.Size = new System.Drawing.Size(338, 166);
            this.dgvVacunas.TabIndex = 224;
            // 
            // lblAgregarVacuna
            // 
            this.lblAgregarVacuna.AutoSize = true;
            this.lblAgregarVacuna.Location = new System.Drawing.Point(324, 36);
            this.lblAgregarVacuna.Name = "lblAgregarVacuna";
            this.lblAgregarVacuna.Size = new System.Drawing.Size(195, 13);
            this.lblAgregarVacuna.TabIndex = 225;
            this.lblAgregarVacuna.TabStop = true;
            this.lblAgregarVacuna.Text = "¿Desea agregar una vacuna al control?";
            this.lblAgregarVacuna.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAgregarVacuna_LinkClicked);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(45, 37);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(121, 20);
            this.txtPeso.TabIndex = 226;
            this.txtPeso.Text = "0,00";
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPeso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPeso_MouseClick);
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(45, 64);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(121, 20);
            this.txtTalla.TabIndex = 227;
            this.txtTalla.Text = "0,00";
            this.txtTalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTalla.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTalla_MouseClick);
            this.txtTalla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTalla_KeyPress);
            // 
            // paneAgregarVacuna
            // 
            this.paneAgregarVacuna.Controls.Add(this.lblAgregar);
            this.paneAgregarVacuna.Controls.Add(this.llblCerrarAgragarVacuna);
            this.paneAgregarVacuna.Controls.Add(this.txtVacuna);
            this.paneAgregarVacuna.Controls.Add(this.label6);
            this.paneAgregarVacuna.Controls.Add(this.cbbDosis);
            this.paneAgregarVacuna.Controls.Add(this.label4);
            this.paneAgregarVacuna.Controls.Add(this.cbbNombreVacuna);
            this.paneAgregarVacuna.Location = new System.Drawing.Point(327, 75);
            this.paneAgregarVacuna.Name = "paneAgregarVacuna";
            this.paneAgregarVacuna.Size = new System.Drawing.Size(251, 132);
            this.paneAgregarVacuna.TabIndex = 228;
            this.paneAgregarVacuna.Visible = false;
            this.paneAgregarVacuna.Paint += new System.Windows.Forms.PaintEventHandler(this.paneAgregarVacuna_Paint);
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(58, 112);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(44, 13);
            this.lblAgregar.TabIndex = 6;
            this.lblAgregar.TabStop = true;
            this.lblAgregar.Text = "Agregar";
            this.lblAgregar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAgregar_LinkClicked);
            // 
            // llblCerrarAgragarVacuna
            // 
            this.llblCerrarAgragarVacuna.AutoSize = true;
            this.llblCerrarAgragarVacuna.Location = new System.Drawing.Point(141, 112);
            this.llblCerrarAgragarVacuna.Name = "llblCerrarAgragarVacuna";
            this.llblCerrarAgragarVacuna.Size = new System.Drawing.Size(35, 13);
            this.llblCerrarAgragarVacuna.TabIndex = 5;
            this.llblCerrarAgragarVacuna.TabStop = true;
            this.llblCerrarAgragarVacuna.Text = "Cerrar";
            this.llblCerrarAgragarVacuna.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCerrarAgragarVacuna_LinkClicked);
            // 
            // txtVacuna
            // 
            this.txtVacuna.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVacuna.ForeColor = System.Drawing.Color.DimGray;
            this.txtVacuna.Location = new System.Drawing.Point(6, 64);
            this.txtVacuna.Multiline = true;
            this.txtVacuna.Name = "txtVacuna";
            this.txtVacuna.Size = new System.Drawing.Size(235, 45);
            this.txtVacuna.TabIndex = 4;
            this.txtVacuna.Text = "Escriba una observación...";
            this.txtVacuna.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtVacuna_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Dosis:";
            // 
            // cbbDosis
            // 
            this.cbbDosis.FormattingEnabled = true;
            this.cbbDosis.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.cbbDosis.Location = new System.Drawing.Point(61, 37);
            this.cbbDosis.Name = "cbbDosis";
            this.cbbDosis.Size = new System.Drawing.Size(180, 21);
            this.cbbDosis.TabIndex = 2;
            this.cbbDosis.Text = "Seleccione la dosis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre:";
            // 
            // cbbNombreVacuna
            // 
            this.cbbNombreVacuna.FormattingEnabled = true;
            this.cbbNombreVacuna.Items.AddRange(new object[] {
            "Vacuna A",
            "Vacuna B",
            "Vacuna C",
            "Vacuna G"});
            this.cbbNombreVacuna.Location = new System.Drawing.Point(61, 10);
            this.cbbNombreVacuna.Name = "cbbNombreVacuna";
            this.cbbNombreVacuna.Size = new System.Drawing.Size(180, 21);
            this.cbbNombreVacuna.TabIndex = 0;
            this.cbbNombreVacuna.Text = "Seleccione la vacuna";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(225)))), ((int)(((byte)(216)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(140, 173);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 46);
            this.btnCancelar.TabIndex = 230;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(225)))), ((int)(((byte)(216)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(9, 173);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 46);
            this.btnAgregar.TabIndex = 229;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbxNuevoControl
            // 
            this.gbxNuevoControl.Controls.Add(this.paneAgregarVacuna);
            this.gbxNuevoControl.Controls.Add(this.btnCancelar);
            this.gbxNuevoControl.Controls.Add(this.lblAgregarVacuna);
            this.gbxNuevoControl.Controls.Add(this.label2);
            this.gbxNuevoControl.Controls.Add(this.dgvVacunas);
            this.gbxNuevoControl.Controls.Add(this.btnAgregar);
            this.gbxNuevoControl.Controls.Add(this.label5);
            this.gbxNuevoControl.Controls.Add(this.label9);
            this.gbxNuevoControl.Controls.Add(this.txtTalla);
            this.gbxNuevoControl.Controls.Add(this.label1);
            this.gbxNuevoControl.Controls.Add(this.txtPeso);
            this.gbxNuevoControl.Controls.Add(this.txtObservacion);
            this.gbxNuevoControl.Location = new System.Drawing.Point(16, 177);
            this.gbxNuevoControl.Name = "gbxNuevoControl";
            this.gbxNuevoControl.Size = new System.Drawing.Size(624, 231);
            this.gbxNuevoControl.TabIndex = 231;
            this.gbxNuevoControl.TabStop = false;
            this.gbxNuevoControl.Text = "Nuevo Control";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(16, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 232;
            this.pictureBox1.TabStop = false;
            // 
            // FrmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxNuevoControl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvListado);
            this.Name = "FrmControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:::NUEVO CONTROL:::.";
            this.Load += new System.EventHandler(this.FrmControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunas)).EndInit();
            this.paneAgregarVacuna.ResumeLayout(false);
            this.paneAgregarVacuna.PerformLayout();
            this.gbxNuevoControl.ResumeLayout(false);
            this.gbxNuevoControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.DataGridView dgvVacunas;
        private System.Windows.Forms.LinkLabel lblAgregarVacuna;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.Panel paneAgregarVacuna;
        private System.Windows.Forms.LinkLabel llblCerrarAgragarVacuna;
        private System.Windows.Forms.TextBox txtVacuna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbDosis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbNombreVacuna;
        private System.Windows.Forms.LinkLabel lblAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbxNuevoControl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}