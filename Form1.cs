namespace SP3_RepuestoVentas
{
    public partial class frmRepuestoVentas : Form
    {
        public frmRepuestoVentas()
        {
            InitializeComponent();
        }
        // Variables globales
        string descripcion;
        int indice = 0;
        string[] vectorRepuesto = new string[100];
        string marca = "";
        string origen = "";
        string numRepuesto = "";
        string descripcionRepuesto = "";
        decimal precio = 0;

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
            marca = cmbMarca.Text;
            origen = cmbOrigen.Text;
            numRepuesto = mskNumRepuest.Text;
            descripcionRepuesto = txtDescrip.Text;
            precio = Convert.ToDecimal(mskPrecio.Text);
            vectorRepuesto[indice] = marca + " " + origen + " " + numRepuesto + " " + descripcionRepuesto + " " + precio.ToString("C");
            indice++;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMarcaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMarcaOrigen.Items.Add("(P) Peugeot");
            cmbMarcaOrigen.Items.Add("(F) Fiat");
            cmbMarcaOrigen.Items.Add("(R) Renault");
        }

        private void cmbOrigenConsult_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOrigenConsult.Items.Add("Importado");
            cmbOrigenConsult.Items.Add("Nacional");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
        }
    }
}