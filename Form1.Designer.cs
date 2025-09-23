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
            grupboxConsult = new GroupBox();
            grupboxRegRep.SuspendLayout();
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
            grupboxRegRep.Location = new Point(12, 12);
            grupboxRegRep.Name = "grupboxRegRep";
            grupboxRegRep.Size = new Size(340, 269);
            grupboxRegRep.TabIndex = 0;
            grupboxRegRep.TabStop = false;
            grupboxRegRep.Text = "Registro Repuesto";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(226, 229);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(133, 229);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // mskPrecio
            // 
            mskPrecio.Enabled = false;
            mskPrecio.Location = new Point(180, 189);
            mskPrecio.Mask = "999999";
            mskPrecio.Name = "mskPrecio";
            mskPrecio.Size = new Size(121, 23);
            mskPrecio.TabIndex = 9;
            mskPrecio.MaskInputRejected += mskPrecio_MaskInputRejected;
            // 
            // txtDescrip
            // 
            txtDescrip.Enabled = false;
            txtDescrip.Location = new Point(180, 148);
            txtDescrip.MaxLength = 50;
            txtDescrip.Name = "txtDescrip";
            txtDescrip.Size = new Size(121, 23);
            txtDescrip.TabIndex = 8;
            txtDescrip.TextChanged += txtDescrip_TextChanged;
            // 
            // mskNumRepuest
            // 
            mskNumRepuest.Enabled = false;
            mskNumRepuest.Location = new Point(180, 104);
            mskNumRepuest.Mask = "999999";
            mskNumRepuest.Name = "mskNumRepuest";
            mskNumRepuest.Size = new Size(121, 23);
            mskNumRepuest.TabIndex = 7;
            mskNumRepuest.ValidatingType = typeof(int);
            mskNumRepuest.MaskInputRejected += mskNumRepuest_MaskInputRejected;
            // 
            // cmbOrigen
            // 
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigen.Enabled = false;
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(180, 67);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(121, 23);
            cmbOrigen.TabIndex = 6;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(180, 27);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(121, 23);
            cmbMarca.TabIndex = 5;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(21, 189);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // lblDecripRepuesto
            // 
            lblDecripRepuesto.AutoSize = true;
            lblDecripRepuesto.Location = new Point(21, 148);
            lblDecripRepuesto.Name = "lblDecripRepuesto";
            lblDecripRepuesto.Size = new Size(140, 15);
            lblDecripRepuesto.TabIndex = 3;
            lblDecripRepuesto.Text = "Descripcion del Repuesto";
            // 
            // lblNumRepuesto
            // 
            lblNumRepuesto.AutoSize = true;
            lblNumRepuesto.Location = new Point(21, 107);
            lblNumRepuesto.Name = "lblNumRepuesto";
            lblNumRepuesto.Size = new Size(122, 15);
            lblNumRepuesto.TabIndex = 2;
            lblNumRepuesto.Text = "Numero del Repuesto";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(21, 67);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Origen";
            // 
            // lblMarca
            // 
            lblMarca.Location = new Point(21, 30);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 18);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // grupboxConsult
            // 
            grupboxConsult.Location = new Point(12, 287);
            grupboxConsult.Name = "grupboxConsult";
            grupboxConsult.Size = new Size(348, 180);
            grupboxConsult.TabIndex = 1;
            grupboxConsult.TabStop = false;
            grupboxConsult.Text = "Consulta de Datos";
            // 
            // frmRepuestoVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 492);
            Controls.Add(grupboxConsult);
            Controls.Add(grupboxRegRep);
            Name = "frmRepuestoVentas";
            Text = "Repuestos Ventas";
            Load += frmRepuestoVentas_Load;
            grupboxRegRep.ResumeLayout(false);
            grupboxRegRep.PerformLayout();
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
    }
}
