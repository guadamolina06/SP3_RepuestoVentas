namespace SP3_RepuestoVentas
{
    partial class frmRepuestoVentas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grupboxRegRep = new GroupBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            mskPrecio = new MaskedTextBox();
            txtDescrip = new TextBox();
            mskNumRepuest = new MaskedTextBox();
            cmbOrigen = new ComboBox();
            cmbMarca = new ComboBox();
            lblPrecio = new Label();
            lblDecripRepuesto = new Label();
            lblNumRepuesto = new Label();
            lblOrigen = new Label();
            lblMarca = new Label();
            cmbOrgConsult = new GroupBox();
            lblMarcaC = new Label();
            lblOrigenC = new Label();
            cmbOrigenC = new ComboBox();
            cmbMarcaC = new ComboBox();
            dgvDatos = new DataGridView();
            Marca = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            numero = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            btnConsultar = new Button();
            grupboxRegRep.SuspendLayout();
            cmbOrgConsult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // grupboxRegRep
            // 
            grupboxRegRep.Controls.Add(btnRegistrar);
            grupboxRegRep.Controls.Add(btnCancelar);
            grupboxRegRep.Controls.Add(mskPrecio);
            grupboxRegRep.Controls.Add(txtDescrip);
            grupboxRegRep.Controls.Add(mskNumRepuest);
            grupboxRegRep.Controls.Add(cmbOrigen);
            grupboxRegRep.Controls.Add(cmbMarca);
            grupboxRegRep.Controls.Add(lblPrecio);
            grupboxRegRep.Controls.Add(lblDecripRepuesto);
            grupboxRegRep.Controls.Add(lblNumRepuesto);
            grupboxRegRep.Controls.Add(lblOrigen);
            grupboxRegRep.Controls.Add(lblMarca);
            grupboxRegRep.Location = new Point(14, 16);
            grupboxRegRep.Margin = new Padding(3, 4, 3, 4);
            grupboxRegRep.Name = "grupboxRegRep";
            grupboxRegRep.Padding = new Padding(3, 4, 3, 4);
            grupboxRegRep.Size = new Size(698, 189);
            grupboxRegRep.TabIndex = 0;
            grupboxRegRep.TabStop = false;
            grupboxRegRep.Text = "Registro Repuesto";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(543, 134);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(86, 31);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(437, 134);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // mskPrecio
            // 
            mskPrecio.Enabled = false;
            mskPrecio.Location = new Point(206, 138);
            mskPrecio.Margin = new Padding(3, 4, 3, 4);
            mskPrecio.Mask = "999999";
            mskPrecio.Name = "mskPrecio";
            mskPrecio.Size = new Size(138, 27);
            mskPrecio.TabIndex = 9;
            mskPrecio.MaskInputRejected += mskPrecio_MaskInputRejected;
            // 
            // txtDescrip
            // 
            txtDescrip.Enabled = false;
            txtDescrip.Location = new Point(554, 86);
            txtDescrip.Margin = new Padding(3, 4, 3, 4);
            txtDescrip.MaxLength = 50;
            txtDescrip.Name = "txtDescrip";
            txtDescrip.Size = new Size(138, 27);
            txtDescrip.TabIndex = 8;
            txtDescrip.TextChanged += txtDescrip_TextChanged;
            // 
            // mskNumRepuest
            // 
            mskNumRepuest.Enabled = false;
            mskNumRepuest.Location = new Point(206, 82);
            mskNumRepuest.Margin = new Padding(3, 4, 3, 4);
            mskNumRepuest.Mask = "999999";
            mskNumRepuest.Name = "mskNumRepuest";
            mskNumRepuest.Size = new Size(138, 27);
            mskNumRepuest.TabIndex = 7;
            mskNumRepuest.ValidatingType = typeof(int);
            mskNumRepuest.MaskInputRejected += mskNumRepuest_MaskInputRejected;
            // 
            // cmbOrigen
            // 
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigen.Enabled = false;
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(554, 40);
            cmbOrigen.Margin = new Padding(3, 4, 3, 4);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(138, 28);
            cmbOrigen.TabIndex = 6;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(206, 36);
            cmbMarca.Margin = new Padding(3, 4, 3, 4);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(138, 28);
            cmbMarca.TabIndex = 5;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(24, 138);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // lblDecripRepuesto
            // 
            lblDecripRepuesto.AutoSize = true;
            lblDecripRepuesto.Location = new Point(372, 86);
            lblDecripRepuesto.Name = "lblDecripRepuesto";
            lblDecripRepuesto.Size = new Size(178, 20);
            lblDecripRepuesto.TabIndex = 3;
            lblDecripRepuesto.Text = "Descripcion del Repuesto";
            // 
            // lblNumRepuesto
            // 
            lblNumRepuesto.AutoSize = true;
            lblNumRepuesto.Location = new Point(24, 86);
            lblNumRepuesto.Name = "lblNumRepuesto";
            lblNumRepuesto.Size = new Size(154, 20);
            lblNumRepuesto.TabIndex = 2;
            lblNumRepuesto.Text = "Numero del Repuesto";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(372, 40);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(54, 20);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Origen";
            // 
            // lblMarca
            // 
            lblMarca.Location = new Point(24, 40);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(61, 24);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // cmbOrgConsult
            // 
            cmbOrgConsult.Controls.Add(lblMarcaC);
            cmbOrgConsult.Controls.Add(lblOrigenC);
            cmbOrgConsult.Controls.Add(cmbOrigenC);
            cmbOrgConsult.Controls.Add(cmbMarcaC);
            cmbOrgConsult.Controls.Add(dgvDatos);
            cmbOrgConsult.Controls.Add(btnConsultar);
            cmbOrgConsult.Location = new Point(14, 228);
            cmbOrgConsult.Margin = new Padding(3, 4, 3, 4);
            cmbOrgConsult.Name = "cmbOrgConsult";
            cmbOrgConsult.Padding = new Padding(3, 4, 3, 4);
            cmbOrgConsult.Size = new Size(704, 305);
            cmbOrgConsult.TabIndex = 1;
            cmbOrgConsult.TabStop = false;
            cmbOrgConsult.Text = "Consulta de Datos";
            // 
            // lblMarcaC
            // 
            lblMarcaC.AutoSize = true;
            lblMarcaC.Location = new Point(34, 30);
            lblMarcaC.Name = "lblMarcaC";
            lblMarcaC.Size = new Size(50, 20);
            lblMarcaC.TabIndex = 10;
            lblMarcaC.Text = "Marca";
            // 
            // lblOrigenC
            // 
            lblOrigenC.AutoSize = true;
            lblOrigenC.Location = new Point(262, 30);
            lblOrigenC.Name = "lblOrigenC";
            lblOrigenC.Size = new Size(54, 20);
            lblOrigenC.TabIndex = 9;
            lblOrigenC.Text = "Origen";
            // 
            // cmbOrigenC
            // 
            cmbOrigenC.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigenC.FormattingEnabled = true;
            cmbOrigenC.Location = new Point(322, 27);
            cmbOrigenC.Name = "cmbOrigenC";
            cmbOrigenC.Size = new Size(151, 28);
            cmbOrigenC.TabIndex = 8;
            // 
            // cmbMarcaC
            // 
            cmbMarcaC.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarcaC.FormattingEnabled = true;
            cmbMarcaC.Location = new Point(85, 27);
            cmbMarcaC.Name = "cmbMarcaC";
            cmbMarcaC.Size = new Size(151, 28);
            cmbMarcaC.TabIndex = 7;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { Marca, Origen, numero, Precio, descripcion });
            dgvDatos.Location = new Point(6, 71);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(692, 216);
            dgvDatos.TabIndex = 6;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.Width = 125;
            // 
            // Origen
            // 
            Origen.HeaderText = "Origen";
            Origen.MinimumWidth = 6;
            Origen.Name = "Origen";
            Origen.Width = 125;
            // 
            // numero
            // 
            numero.HeaderText = "numero";
            numero.MinimumWidth = 6;
            numero.Name = "numero";
            numero.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "descripcion";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            descripcion.Width = 125;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(543, 21);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(86, 39);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // frmRepuestoVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 538);
            Controls.Add(cmbOrgConsult);
            Controls.Add(grupboxRegRep);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRepuestoVentas";
            Text = "Repuestos Ventas";
            Load += frmRepuestoVentas_Load;
            grupboxRegRep.ResumeLayout(false);
            grupboxRegRep.PerformLayout();
            cmbOrgConsult.ResumeLayout(false);
            cmbOrgConsult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grupboxRegRep;
        private Label lblNumRepuesto;
        private Label lblOrigen;
        private Label lblMarca;
        private ComboBox cmbMarca;
        private Label lblPrecio;
        private Label lblDecripRepuesto;
        private GroupBox cmbOrgConsult;
        private TextBox txtDescrip;
        private MaskedTextBox mskNumRepuest;
        private ComboBox cmbOrigen;
        private MaskedTextBox mskPrecio;
        private Button btnCancelar;
        private Button btnRegistrar;
        private Button btnConsultar;
        private DataGridView dgvDatos;
        private ComboBox cmbMarcaC;
        private ComboBox cmbOrigenC;
        private Label lblMarcaC;
        private Label lblOrigenC;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn numero;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn descripcion;
    }
}
