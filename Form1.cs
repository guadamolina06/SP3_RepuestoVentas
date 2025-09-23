namespace SP3_RepuestoVentas
{
    public partial class frmRepuestoVentas : Form
    {
        public frmRepuestoVentas()
        {
            InitializeComponent();
        }
         string descripcion;
         int indice = 0;
         string[] vectorRepuesto = new string[100];
        private void frmRepuestoVentas_Load(object sender, EventArgs e)
        {
            // Cargar los combos al iniciar el formulario
            cmbMarca.Items.Add("(P) Peugeot");
            cmbMarca.Items.Add("(F) Fiat");
            cmbMarca.Items.Add("(R)Renault");
            // Cargar el combo Origen
            cmbOrigen.Items.Add("Importado");
            cmbOrigen.Items.Add("Nacional");
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una marca
            if (cmbMarca.SelectedIndex != -1)
            {
                // Habilitar el combo Origen
                cmbOrigen.Enabled = true;
            }
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un origen
            if (cmbOrigen.SelectedIndex != -1)
            {
                // Habilitar el campo Numero de Repuesto
                mskNumRepuest.Enabled = true;
            }
        }

        private void mskNumRepuest_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // Verificar si el campo Numero de Repuesto está completo
            if (mskNumRepuest.MaskFull)
            {
                // Habilitar el campo Descripcion del Repuesto
                txtDescrip.Enabled = true;
            }
        }

        private void txtDescrip_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el campo Descripcion del Repuesto tiene texto
            if (txtDescrip.Text.Length > 0)
            {
                // Habilitar el campo Precio
                mskPrecio.Enabled = true;
            }
        }

        private void mskPrecio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mskPrecio.MaskFull)
            {
                // Habilitar el boton Registrar
                btnRegistrar.Enabled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Almacena repuesto
            indice = 0;
            vectorRepuesto[indice] = cmbMarca.Text + " " + cmbOrigen.Text + " " + mskNumRepuest.Text + " " + txtDescrip.Text + " " + mskPrecio.Text;
            indice++;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}