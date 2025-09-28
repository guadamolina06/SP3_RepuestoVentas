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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepuestoVentas));
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
            grupboxConsult = new GroupBox();
            lstRespuestas = new ListBox();
            btnConsultar = new Button();
            cmbOrigenConsult = new ComboBox();
            lblOrigenConsul = new Label();
            cmbMarcaOrigen = new ComboBox();
            lblMarcaconsulta = new Label();
            grupboxRegRep.SuspendLayout();
            grupboxConsult.SuspendLayout();
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
            grupboxRegRep.Size = new Size(373, 359);
            grupboxRegRep.TabIndex = 0;
            grupboxRegRep.TabStop = false;
            grupboxRegRep.Text = "Registro Repuesto";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(258, 305);
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
            btnCancelar.Location = new Point(152, 305);
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
            mskPrecio.Location = new Point(206, 252);
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
            txtDescrip.Location = new Point(206, 197);
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
            mskNumRepuest.Location = new Point(206, 139);
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
            cmbOrigen.Location = new Point(206, 89);
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
            lblPrecio.Location = new Point(24, 252);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // lblDecripRepuesto
            // 
            lblDecripRepuesto.AutoSize = true;
            lblDecripRepuesto.Location = new Point(24, 197);
            lblDecripRepuesto.Name = "lblDecripRepuesto";
            lblDecripRepuesto.Size = new Size(178, 20);
            lblDecripRepuesto.TabIndex = 3;
            lblDecripRepuesto.Text = "Descripcion del Repuesto";
            // 
            // lblNumRepuesto
            // 
            lblNumRepuesto.AutoSize = true;
            lblNumRepuesto.Location = new Point(24, 143);
            lblNumRepuesto.Name = "lblNumRepuesto";
            lblNumRepuesto.Size = new Size(154, 20);
            lblNumRepuesto.TabIndex = 2;
            lblNumRepuesto.Text = "Numero del Repuesto";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(24, 89);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(54, 20);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Origen";
            // 
            // lblMarca
            // 
            lblMarca.Location = new Point(24, 40);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(54, 24);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // grupboxConsult
            // 
            grupboxConsult.Controls.Add(lstRespuestas);
            grupboxConsult.Controls.Add(btnConsultar);
            grupboxConsult.Controls.Add(cmbOrigenConsult);
            grupboxConsult.Controls.Add(lblOrigenConsul);
            grupboxConsult.Controls.Add(cmbMarcaOrigen);
            grupboxConsult.Controls.Add(lblMarcaconsulta);
            grupboxConsult.Location = new Point(14, 383);
            grupboxConsult.Margin = new Padding(3, 4, 3, 4);
            grupboxConsult.Name = "grupboxConsult";
            grupboxConsult.Padding = new Padding(3, 4, 3, 4);
            grupboxConsult.Size = new Size(373, 260);
            grupboxConsult.TabIndex = 1;
            grupboxConsult.TabStop = false;
            grupboxConsult.Text = "Consulta de Datos";
            // 
            // lstRespuestas
            // 
            lstRespuestas.FormattingEnabled = true;
            lstRespuestas.Location = new Point(6, 189);
            lstRespuestas.Name = "lstRespuestas";
            lstRespuestas.Size = new Size(357, 64);
            lstRespuestas.TabIndex = 5;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(252, 148);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(92, 28);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // cmbOrigenConsult
            // 
            cmbOrigenConsult.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigenConsult.FormattingEnabled = true;
            cmbOrigenConsult.Location = new Point(193, 96);
            cmbOrigenConsult.Name = "cmbOrigenConsult";
            cmbOrigenConsult.Size = new Size(151, 28);
            cmbOrigenConsult.TabIndex = 3;
            cmbOrigenConsult.SelectedIndexChanged += cmbOrigenConsult_SelectedIndexChanged;
            // 
            // lblOrigenConsul
            // 
            lblOrigenConsul.AutoSize = true;
            lblOrigenConsul.Location = new Point(48, 104);
            lblOrigenConsul.Name = "lblOrigenConsul";
            lblOrigenConsul.Size = new Size(54, 20);
            lblOrigenConsul.TabIndex = 2;
            lblOrigenConsul.Text = "Origen";
            // 
            // cmbMarcaOrigen
            // 
            cmbMarcaOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarcaOrigen.FormattingEnabled = true;
            cmbMarcaOrigen.Location = new Point(193, 38);
            cmbMarcaOrigen.Name = "cmbMarcaOrigen";
            cmbMarcaOrigen.Size = new Size(151, 28);
            cmbMarcaOrigen.TabIndex = 1;
            cmbMarcaOrigen.SelectedIndexChanged += cmbMarcaOrigen_SelectedIndexChanged;
            // 
            // lblMarcaconsulta
            // 
            lblMarcaconsulta.AutoSize = true;
            lblMarcaconsulta.Location = new Point(48, 41);
            lblMarcaconsulta.Name = "lblMarcaconsulta";
            lblMarcaconsulta.Size = new Size(50, 20);
            lblMarcaconsulta.TabIndex = 0;
            lblMarcaconsulta.Text = "Marca";
            // 
            // frmRepuestoVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 656);
            Controls.Add(grupboxConsult);
            Controls.Add(grupboxRegRep);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRepuestoVentas";
            Text = "Repuestos Ventas";
            Load += frmRepuestoVentas_Load;
            grupboxRegRep.ResumeLayout(false);
            grupboxRegRep.PerformLayout();
            grupboxConsult.ResumeLayout(false);
            grupboxConsult.PerformLayout();
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
        private GroupBox grupboxConsult;
        private TextBox txtDescrip;
        private MaskedTextBox mskNumRepuest;
        private ComboBox cmbOrigen;
        private MaskedTextBox mskPrecio;
        private Button btnCancelar;
        private Button btnRegistrar;
        private Label lblOrigenConsul;
        private ComboBox cmbMarcaOrigen;
        private Label lblMarcaconsulta;
        private Button btnConsultar;
        private ComboBox cmbOrigenConsult;
        private ListBox lstRespuestas;
    }
}
