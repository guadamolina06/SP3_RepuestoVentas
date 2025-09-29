namespace SP3_RepuestoVentas
{
    public partial class frmRepuestoVentas : Form
    {
        public frmRepuestoVentas()
        {
            InitializeComponent();
        }

        int indice = 0;
        string[] vectorRepuesto = new string[100];
        int vMarca = 0;
        int vOrigen = 0;
        decimal vPrecio = 0;
        int vNumRepuesto = 0;
        string vDescripcion = "";
        private void frmRepuestoVentas_Load(object sender, EventArgs e)
        {
            // Cargar los combos al iniciar el formulario
            cmbMarca.Items.Add("(P) Peugeot");
            cmbMarca.Items.Add("(F) Fiat");
            cmbMarca.Items.Add("(R)Renault");
            // Cargar el combo Origen
            cmbOrigen.Items.Add("Importado");
            cmbOrigen.Items.Add("Nacional");
            //Cargar combos de consulta
            cmbMarConsult.Items.Add("(P) Peugeot");
            cmbMarConsult.Items.Add("(F) Fiat");
            cmbMarConsult.Items.Add("(R)Renault");

            cmbOrgConsul.Items.Add("Importado");
            cmbOrgConsul.Items.Add("Nacional");
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
            vMarca = cmbMarca.SelectedIndex;
            vOrigen = cmbOrigen.SelectedIndex;
            vNumRepuesto = int.Parse(mskNumRepuest.Text);
            vDescripcion = txtDescrip.Text;
            vPrecio = decimal.Parse(mskPrecio.Text);

            vectorRepuesto[indice] = vMarca + " " + vOrigen + " " + vNumRepuesto + " " + vDescripcion + " " + vPrecio;
            indice++;
            cmbMarca.SelectedIndex = -1;
            cmbOrigen.SelectedIndex = -1;
            mskNumRepuest.Clear();
            txtDescrip.Clear();
            mskPrecio.Clear();
            cmbOrigen.Enabled = false;
            mskNumRepuest.Enabled = false;
            txtDescrip.Enabled = false;
            mskPrecio.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           if (cmbMarConsult.SelectedIndex != -1 && cmbOrgConsul.SelectedIndex != -1)
            {
                // Realizar la consulta
                int marcaConsulta = cmbMarConsult.SelectedIndex;
                int origenConsulta = cmbOrgConsul.SelectedIndex;
                lblConsultarResul
                for (int i = 0; i < indice; i++)
                {
                    string[] datosRepuesto = vectorRepuesto[i].Split(' ');
                    int marcaRepuesto = int.Parse(datosRepuesto[0]);
                    int origenRepuesto = int.Parse(datosRepuesto[1]);
                    if (marcaRepuesto == marcaConsulta && origenRepuesto == origenConsulta)
                    {
                        lstResultados.Items.Add(vectorRepuesto[i]);
                    }
                }
                if (lstResultados.Items.Count == 0)
                {
                    lstResultados.Items.Add("No se encontraron repuestos para los criterios seleccionados.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione ambos criterios de consulta.", "Criterios incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}