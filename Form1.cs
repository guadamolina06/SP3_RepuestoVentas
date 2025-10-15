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

        string [,] matRepuesto = new string[100, 5];
        int indiceGrabar = 0;

        private void frmRepuestoVentas_Load(object sender, EventArgs e)
        {
            CargadorDatos();
            MessageBox.Show("Datos Cargados");
            List<string> origenes = new List<string>();
            List<string> listaMarcas = new List<string>();

            for (int filas = 0; filas < matRepuesto.GetLength(0); filas++)
            {
                dgvDatos.Rows.Add(
                    matRepuesto[filas, 0],
                    matRepuesto[filas, 1],
                    matRepuesto[filas, 2],
                    matRepuesto[filas, 3],
                    matRepuesto[filas, 4]
                );

                // Evitar duplicados
                if (!listaMarcas.Contains(matRepuesto[filas, 0]))
                    listaMarcas.Add(matRepuesto[filas, 0]);

                if (!origenes.Contains(matRepuesto[filas, 1]))
                    origenes.Add(matRepuesto[filas, 1]);
            }

            // 👇 Esto debe ir fuera del bucle
            cmbMarcaC.DataSource = null;
            cmbMarcaC.DataSource = listaMarcas;

            cmbOrigenC.DataSource = null;
            cmbOrigenC.DataSource = origenes;



            // Cargar los combos al iniciar el formulario
            cmbMarca.Items.Add("(P) Peugeot");
            cmbMarca.Items.Add("(F) Fiat");
            cmbMarca.Items.Add("(R)Renault");
            // Cargar el combo Origen
            cmbOrigen.Items.Add("Importado");
            cmbOrigen.Items.Add("Nacional");
            //Cargar combos de consulta
            

          
        }

        private void CargadorDatos()
        {

            matRepuesto[1, 0] = "BMW"; matRepuesto[1, 1] = "España"; matRepuesto[1, 2] = "10001"; matRepuesto[1, 3] = "21022"; matRepuesto[1, 4] = "Pastillas de freno";
            matRepuesto[2, 0] = "Peugeot"; matRepuesto[2, 1] = "Corea del Sur"; matRepuesto[2, 2] = "10002"; matRepuesto[2, 3] = "73797"; matRepuesto[2, 4] = "Pastillas de freno";
            matRepuesto[3, 0] = "Ford"; matRepuesto[3, 1] = "México"; matRepuesto[3, 2] = "10003"; matRepuesto[3, 3] = "27146"; matRepuesto[3, 4] = "Amortiguador";
            matRepuesto[4, 0] = "Chevrolet"; matRepuesto[4, 1] = "Italia"; matRepuesto[4, 2] = "10004"; matRepuesto[4, 3] = "54485"; matRepuesto[4, 4] = "Bujía de encendido";
            matRepuesto[5, 0] = "Chevrolet"; matRepuesto[5, 1] = "Japón"; matRepuesto[5, 2] = "10005"; matRepuesto[5, 3] = "52727"; matRepuesto[5, 4] = "Pastillas de freno";
            matRepuesto[6, 0] = "Hyundai"; matRepuesto[6, 1] = "Brasil"; matRepuesto[6, 2] = "10006"; matRepuesto[6, 3] = "28917"; matRepuesto[6, 4] = "Correa de distribución";
            matRepuesto[7, 0] = "Nissan"; matRepuesto[7, 1] = "Francia"; matRepuesto[7, 2] = "10007"; matRepuesto[7, 3] = "68523"; matRepuesto[7, 4] = "Radiador";
            matRepuesto[8, 0] = "Suzuki"; matRepuesto[8, 1] = "España"; matRepuesto[8, 2] = "10008"; matRepuesto[8, 3] = "84353"; matRepuesto[8, 4] = "Disco de freno";
            matRepuesto[9, 0] = "Mitsubishi"; matRepuesto[9, 1] = "Francia"; matRepuesto[9, 2] = "10009"; matRepuesto[9, 3] = "90775"; matRepuesto[9, 4] = "Radiador";
            matRepuesto[10, 0] = "Ford"; matRepuesto[10, 1] = "Corea del Sur"; matRepuesto[10, 2] = "10010"; matRepuesto[10, 3] = "88546"; matRepuesto[10, 4] = "Compresor de aire";
            matRepuesto[11, 0] = "BMW"; matRepuesto[11, 1] = "Brasil"; matRepuesto[11, 2] = "10011"; matRepuesto[11, 3] = "34414"; matRepuesto[11, 4] = "Pastillas de freno";
            matRepuesto[12, 0] = "Renault"; matRepuesto[12, 1] = "Alemania"; matRepuesto[12, 2] = "10012"; matRepuesto[12, 3] = "67459"; matRepuesto[12, 4] = "Correa de distribución";
            matRepuesto[13, 0] = "Mercedes-Benz"; matRepuesto[13, 1] = "Brasil"; matRepuesto[13, 2] = "10013"; matRepuesto[13, 3] = "68494"; matRepuesto[13, 4] = "Alternador";
            matRepuesto[14, 0] = "Volkswagen"; matRepuesto[14, 1] = "Italia"; matRepuesto[14, 2] = "10014"; matRepuesto[14, 3] = "31730"; matRepuesto[14, 4] = "Bujía de encendido";
            matRepuesto[15, 0] = "Mercedes-Benz"; matRepuesto[15, 1] = "Francia"; matRepuesto[15, 2] = "10015"; matRepuesto[15, 3] = "51646"; matRepuesto[15, 4] = "Faro delantero";
            matRepuesto[16, 0] = "Hyundai"; matRepuesto[16, 1] = "Italia"; matRepuesto[16, 2] = "10016"; matRepuesto[16, 3] = "29300"; matRepuesto[16, 4] = "Amortiguador";
            matRepuesto[17, 0] = "Suzuki"; matRepuesto[17, 1] = "Francia"; matRepuesto[17, 2] = "10017"; matRepuesto[17, 3] = "92818"; matRepuesto[17, 4] = "Espejo lateral";
            matRepuesto[18, 0] = "Mercedes-Benz"; matRepuesto[18, 1] = "Argentina"; matRepuesto[18, 2] = "10018"; matRepuesto[18, 3] = "27130"; matRepuesto[18, 4] = "Embrague";
            matRepuesto[19, 0] = "Renault"; matRepuesto[19, 1] = "España"; matRepuesto[19, 2] = "10019"; matRepuesto[19, 3] = "52102"; matRepuesto[19, 4] = "Pastillas de freno";
            matRepuesto[20, 0] = "Nissan"; matRepuesto[20, 1] = "España"; matRepuesto[20, 2] = "10020"; matRepuesto[20, 3] = "63687"; matRepuesto[20, 4] = "Sensor ABS";
            matRepuesto[21, 0] = "Volkswagen"; matRepuesto[21, 1] = "Francia"; matRepuesto[21, 2] = "10021"; matRepuesto[21, 3] = "82035"; matRepuesto[21, 4] = "Amortiguador";
            matRepuesto[22, 0] = "Jeep"; matRepuesto[22, 1] = "México"; matRepuesto[22, 2] = "10022"; matRepuesto[22, 3] = "48120"; matRepuesto[22, 4] = "Filtro de aceite";
            matRepuesto[23, 0] = "Hyundai"; matRepuesto[23, 1] = "Italia"; matRepuesto[23, 2] = "10023"; matRepuesto[23, 3] = "76240"; matRepuesto[23, 4] = "Compresor de aire";
            matRepuesto[24, 0] = "Kia"; matRepuesto[24, 1] = "Corea del Sur"; matRepuesto[24, 2] = "10024"; matRepuesto[24, 3] = "36882"; matRepuesto[24, 4] = "Paragolpe";
            matRepuesto[25, 0] = "BMW"; matRepuesto[25, 1] = "Japón"; matRepuesto[25, 2] = "10025"; matRepuesto[25, 3] = "28627"; matRepuesto[25, 4] = "Faro delantero";
            matRepuesto[26, 0] = "Volkswagen"; matRepuesto[26, 1] = "Francia"; matRepuesto[26, 2] = "10026"; matRepuesto[26, 3] = "90193"; matRepuesto[26, 4] = "Amortiguador";
            matRepuesto[27, 0] = "Kia"; matRepuesto[27, 1] = "Italia"; matRepuesto[27, 2] = "10027"; matRepuesto[27, 3] = "75174"; matRepuesto[27, 4] = "Filtro de aceite";
            matRepuesto[28, 0] = "Suzuki"; matRepuesto[28, 1] = "México"; matRepuesto[28, 2] = "10028"; matRepuesto[28, 3] = "98600"; matRepuesto[28, 4] = "Alternador";
            matRepuesto[29, 0] = "Kia"; matRepuesto[29, 1] = "Corea del Sur"; matRepuesto[29, 2] = "10029"; matRepuesto[29, 3] = "62256"; matRepuesto[29, 4] = "Correa de distribución";
            matRepuesto[30, 0] = "Nissan"; matRepuesto[30, 1] = "México"; matRepuesto[30, 2] = "10030"; matRepuesto[30, 3] = "64483"; matRepuesto[30, 4] = "Amortiguador";
            matRepuesto[31, 0] = "Jeep"; matRepuesto[31, 1] = "Italia"; matRepuesto[31, 2] = "10031"; matRepuesto[31, 3] = "67389"; matRepuesto[31, 4] = "Batería";
            matRepuesto[32, 0] = "Chevrolet"; matRepuesto[32, 1] = "Argentina"; matRepuesto[32, 2] = "10032"; matRepuesto[32, 3] = "26012"; matRepuesto[32, 4] = "Sensor ABS";
            matRepuesto[33, 0] = "Nissan"; matRepuesto[33, 1] = "España"; matRepuesto[33, 2] = "10033"; matRepuesto[33, 3] = "47820"; matRepuesto[33, 4] = "Amortiguador";
            matRepuesto[34, 0] = "Fiat"; matRepuesto[34, 1] = "Alemania"; matRepuesto[34, 2] = "10034"; matRepuesto[34, 3] = "58653"; matRepuesto[34, 4] = "Batería";
            matRepuesto[35, 0] = "Suzuki"; matRepuesto[35, 1] = "Argentina"; matRepuesto[35, 2] = "10035"; matRepuesto[35, 3] = "46254"; matRepuesto[35, 4] = "Filtro de aire";
            matRepuesto[36, 0] = "Toyota"; matRepuesto[36, 1] = "Corea del Sur"; matRepuesto[36, 2] = "10036"; matRepuesto[36, 3] = "27555"; matRepuesto[36, 4] = "Amortiguador";
            matRepuesto[37, 0] = "Renault"; matRepuesto[37, 1] = "Japón"; matRepuesto[37, 2] = "10037"; matRepuesto[37, 3] = "69585"; matRepuesto[37, 4] = "Paragolpe";
            matRepuesto[38, 0] = "Nissan"; matRepuesto[38, 1] = "España"; matRepuesto[38, 2] = "10038"; matRepuesto[38, 3] = "88984"; matRepuesto[38, 4] = "Compresor de aire";
            matRepuesto[39, 0] = "Mercedes-Benz"; matRepuesto[39, 1] = "Japón"; matRepuesto[39, 2] = "10039"; matRepuesto[39, 3] = "65147"; matRepuesto[39, 4] = "Batería";
            matRepuesto[40, 0] = "Nissan"; matRepuesto[40, 1] = "Italia"; matRepuesto[40, 2] = "10040"; matRepuesto[40, 3] = "61779"; matRepuesto[40, 4] = "Bujía de encendido";
            matRepuesto[41, 0] = "Hyundai"; matRepuesto[41, 1] = "Corea del Sur"; matRepuesto[41, 2] = "10041"; matRepuesto[41, 3] = "46138"; matRepuesto[41, 4] = "Sensor ABS";
            matRepuesto[42, 0] = "Mercedes-Benz"; matRepuesto[42, 1] = "Brasil"; matRepuesto[42, 2] = "10042"; matRepuesto[42, 3] = "94153"; matRepuesto[42, 4] = "Espejo lateral";
            matRepuesto[43, 0] = "Chevrolet"; matRepuesto[43, 1] = "Japón"; matRepuesto[43, 2] = "10043"; matRepuesto[43, 3] = "85713"; matRepuesto[43, 4] = "Filtro de aceite";
            matRepuesto[44, 0] = "Fiat"; matRepuesto[44, 1] = "España"; matRepuesto[44, 2] = "10044"; matRepuesto[44, 3] = "23592"; matRepuesto[44, 4] = "Filtro de aceite";
            matRepuesto[45, 0] = "Toyota"; matRepuesto[45, 1] = "España"; matRepuesto[45, 2] = "10045"; matRepuesto[45, 3] = "49974"; matRepuesto[45, 4] = "Pastillas de freno";
            matRepuesto[46, 0] = "Toyota"; matRepuesto[46, 1] = "España"; matRepuesto[46, 2] = "10046"; matRepuesto[46, 3] = "21708"; matRepuesto[46, 4] = "Espejo lateral";
            matRepuesto[47, 0] = "BMW"; matRepuesto[47, 1] = "Japón"; matRepuesto[47, 2] = "10047"; matRepuesto[47, 3] = "60349"; matRepuesto[47, 4] = "Disco de freno";
            matRepuesto[48, 0] = "Toyota"; matRepuesto[48, 1] = "Italia"; matRepuesto[48, 2] = "10048"; matRepuesto[48, 3] = "40123"; matRepuesto[48, 4] = "Faro delantero";
            matRepuesto[49, 0] = "Hyundai"; matRepuesto[49, 1] = "Japón"; matRepuesto[49, 2] = "10049"; matRepuesto[49, 3] = "28676"; matRepuesto[49, 4] = "Bujía de encendido";
            matRepuesto[50, 0] = "Renault"; matRepuesto[50, 1] = "Francia"; matRepuesto[50, 2] = "10050"; matRepuesto[50, 3] = "63806"; matRepuesto[50, 4] = "Radiador";
            matRepuesto[51, 0] = "Nissan"; matRepuesto[51, 1] = "México"; matRepuesto[51, 2] = "10051"; matRepuesto[51, 3] = "39231"; matRepuesto[51, 4] = "Amortiguador";
            matRepuesto[52, 0] = "Peugeot"; matRepuesto[52, 1] = "Brasil"; matRepuesto[52, 2] = "10052"; matRepuesto[52, 3] = "44303"; matRepuesto[52, 4] = "Bujía de encendido";
            matRepuesto[53, 0] = "Renault"; matRepuesto[53, 1] = "México"; matRepuesto[53, 2] = "10053"; matRepuesto[53, 3] = "66326"; matRepuesto[53, 4] = "Embrague";
            matRepuesto[54, 0] = "Mercedes-Benz"; matRepuesto[54, 1] = "Italia"; matRepuesto[54, 2] = "10054"; matRepuesto[54, 3] = "36492"; matRepuesto[54, 4] = "Espejo lateral";
            matRepuesto[55, 0] = "Ford"; matRepuesto[55, 1] = "Japón"; matRepuesto[55, 2] = "10055"; matRepuesto[55, 3] = "43591"; matRepuesto[55, 4] = "Disco de freno";
            matRepuesto[56, 0] = "Nissan"; matRepuesto[56, 1] = "México"; matRepuesto[56, 2] = "10056"; matRepuesto[56, 3] = "76855"; matRepuesto[56, 4] = "Alternador";
            matRepuesto[57, 0] = "Nissan"; matRepuesto[57, 1] = "España"; matRepuesto[57, 2] = "10057"; matRepuesto[57, 3] = "73267"; matRepuesto[57, 4] = "Filtro de aire";
            matRepuesto[58, 0] = "Suzuki"; matRepuesto[58, 1] = "España"; matRepuesto[58, 2] = "10058"; matRepuesto[58, 3] = "49078"; matRepuesto[58, 4] = "Sensor ABS";
            matRepuesto[59, 0] = "BMW"; matRepuesto[59, 1] = "Italia"; matRepuesto[59, 2] = "10059"; matRepuesto[59, 3] = "93720"; matRepuesto[59, 4] = "Amortiguador";
            matRepuesto[60, 0] = "Nissan"; matRepuesto[60, 1] = "EEUU"; matRepuesto[60, 2] = "10060"; matRepuesto[60, 3] = "21466"; matRepuesto[60, 4] = "Faro delantero";
            matRepuesto[61, 0] = "Peugeot"; matRepuesto[61, 1] = "Italia"; matRepuesto[61, 2] = "10061"; matRepuesto[61, 3] = "61586"; matRepuesto[61, 4] = "Filtro de aceite";
            matRepuesto[62, 0] = "Mitsubishi"; matRepuesto[62, 1] = "Alemania"; matRepuesto[62, 2] = "10062"; matRepuesto[62, 3] = "79929"; matRepuesto[62, 4] = "Embrague";
            matRepuesto[63, 0] = "Chevrolet"; matRepuesto[63, 1] = "Argentina"; matRepuesto[63, 2] = "10063"; matRepuesto[63, 3] = "54266"; matRepuesto[63, 4] = "Radiador";
            matRepuesto[64, 0] = "Mitsubishi"; matRepuesto[64, 1] = "Italia"; matRepuesto[64, 2] = "10064"; matRepuesto[64, 3] = "51708"; matRepuesto[64, 4] = "Amortiguador";
            matRepuesto[65, 0] = "Mercedes-Benz"; matRepuesto[65, 1] = "Francia"; matRepuesto[65, 2] = "10065"; matRepuesto[65, 3] = "83890"; matRepuesto[65, 4] = "Filtro de aceite";
            matRepuesto[66, 0] = "BMW"; matRepuesto[66, 1] = "Argentina"; matRepuesto[66, 2] = "10066"; matRepuesto[66, 3] = "67754"; matRepuesto[66, 4] = "Bujía de encendido";
            matRepuesto[67, 0] = "Kia"; matRepuesto[67, 1] = "Italia"; matRepuesto[67, 2] = "10067"; matRepuesto[67, 3] = "83894"; matRepuesto[67, 4] = "Sensor ABS";
            matRepuesto[68, 0] = "Hyundai"; matRepuesto[68, 1] = "Argentina"; matRepuesto[68, 2] = "10068"; matRepuesto[68, 3] = "75369"; matRepuesto[68, 4] = "Radiador";
            matRepuesto[69, 0] = "Toyota"; matRepuesto[69, 1] = "Japón"; matRepuesto[69, 2] = "10069"; matRepuesto[69, 3] = "48073"; matRepuesto[69, 4] = "Filtro de aceite";
            matRepuesto[70, 0] = "BMW"; matRepuesto[70, 1] = "Francia"; matRepuesto[70, 2] = "10070"; matRepuesto[70, 3] = "98258"; matRepuesto[70, 4] = "Radiador";
            matRepuesto[71, 0] = "Nissan"; matRepuesto[71, 1] = "Argentina"; matRepuesto[71, 2] = "10071"; matRepuesto[71, 3] = "84007"; matRepuesto[71, 4] = "Paragolpe";
            matRepuesto[72, 0] = "Hyundai"; matRepuesto[72, 1] = "Japón"; matRepuesto[72, 2] = "10072"; matRepuesto[72, 3] = "87826"; matRepuesto[72, 4] = "Bujía de encendido";
            matRepuesto[73, 0] = "BMW"; matRepuesto[73, 1] = "Alemania"; matRepuesto[73, 2] = "10073"; matRepuesto[73, 3] = "23207"; matRepuesto[73, 4] = "Alternador";
            matRepuesto[74, 0] = "Mitsubishi"; matRepuesto[74, 1] = "Alemania"; matRepuesto[74, 2] = "10074"; matRepuesto[74, 3] = "99568"; matRepuesto[74, 4] = "Radiador";
            matRepuesto[75, 0] = "Ford"; matRepuesto[75, 1] = "España"; matRepuesto[75, 2] = "10075"; matRepuesto[75, 3] = "62329"; matRepuesto[75, 4] = "Compresor de aire";
            matRepuesto[76, 0] = "Peugeot"; matRepuesto[76, 1] = "Corea del Sur"; matRepuesto[76, 2] = "10076"; matRepuesto[76, 3] = "25642"; matRepuesto[76, 4] = "Radiador";
            matRepuesto[77, 0] = "Honda"; matRepuesto[77, 1] = "Argentina"; matRepuesto[77, 2] = "10077"; matRepuesto[77, 3] = "31502"; matRepuesto[77, 4] = "Sensor ABS";
            matRepuesto[78, 0] = "Renault"; matRepuesto[78, 1] = "Brasil"; matRepuesto[78, 2] = "10078"; matRepuesto[78, 3] = "91777"; matRepuesto[78, 4] = "Amortiguador";
            matRepuesto[79, 0] = "Nissan"; matRepuesto[79, 1] = "México"; matRepuesto[79, 2] = "10079"; matRepuesto[79, 3] = "27374"; matRepuesto[79, 4] = "Espejo lateral";
            matRepuesto[80, 0] = "Honda"; matRepuesto[80, 1] = "Alemania"; matRepuesto[80, 2] = "10080"; matRepuesto[80, 3] = "65525"; matRepuesto[80, 4] = "Correa de distribución";
            matRepuesto[81, 0] = "Renault"; matRepuesto[81, 1] = "México"; matRepuesto[81, 2] = "10081"; matRepuesto[81, 3] = "72686"; matRepuesto[81, 4] = "Filtro de aceite";
            matRepuesto[82, 0] = "Hyundai"; matRepuesto[82, 1] = "Brasil"; matRepuesto[82, 2] = "10082"; matRepuesto[82, 3] = "60799"; matRepuesto[82, 4] = "Embrague";
            matRepuesto[83, 0] = "Ford"; matRepuesto[83, 1] = "Japón"; matRepuesto[83, 2] = "10083"; matRepuesto[83, 3] = "94040"; matRepuesto[83, 4] = "Radiador";
            matRepuesto[84, 0] = "Peugeot"; matRepuesto[84, 1] = "México"; matRepuesto[84, 2] = "10084"; matRepuesto[84, 3] = "63815"; matRepuesto[84, 4] = "Alternador";
            matRepuesto[85, 0] = "Peugeot"; matRepuesto[85, 1] = "México"; matRepuesto[85, 2] = "10085"; matRepuesto[85, 3] = "91019"; matRepuesto[85, 4] = "Batería";
            matRepuesto[86, 0] = "Toyota"; matRepuesto[86, 1] = "Brasil"; matRepuesto[86, 2] = "10086"; matRepuesto[86, 3] = "89853"; matRepuesto[86, 4] = "Faro delantero";
            matRepuesto[87, 0] = "BMW"; matRepuesto[87, 1] = "Argentina"; matRepuesto[87, 2] = "10087"; matRepuesto[87, 3] = "28908"; matRepuesto[87, 4] = "Espejo lateral";
            matRepuesto[88, 0] = "Kia"; matRepuesto[88, 1] = "México"; matRepuesto[88, 2] = "10088"; matRepuesto[88, 3] = "49747"; matRepuesto[88, 4] = "Correa de distribución";
            matRepuesto[89, 0] = "Honda"; matRepuesto[89, 1] = "Italia"; matRepuesto[89, 2] = "10089"; matRepuesto[89, 3] = "36336"; matRepuesto[89, 4] = "Faro delantero";
            matRepuesto[90, 0] = "Jeep"; matRepuesto[90, 1] = "Corea del Sur"; matRepuesto[90, 2] = "10090"; matRepuesto[90, 3] = "79066"; matRepuesto[90, 4] = "Radiador";
            matRepuesto[91, 0] = "Fiat"; matRepuesto[91, 1] = "Japón"; matRepuesto[91, 2] = "10091"; matRepuesto[91, 3] = "60525"; matRepuesto[91, 4] = "Radiador";
            matRepuesto[92, 0] = "Nissan"; matRepuesto[92, 1] = "EEUU"; matRepuesto[92, 2] = "10092"; matRepuesto[92, 3] = "89603"; matRepuesto[92, 4] = "Disco de freno";
            matRepuesto[93, 0] = "Mercedes-Benz"; matRepuesto[93, 1] = "Alemania"; matRepuesto[93, 2] = "10093"; matRepuesto[93, 3] = "75479"; matRepuesto[93, 4] = "Disco de freno";
            matRepuesto[94, 0] = "Volkswagen"; matRepuesto[94, 1] = "Brasil"; matRepuesto[94, 2] = "10094"; matRepuesto[94, 3] = "62434"; matRepuesto[94, 4] = "Bujía de encendido";
            matRepuesto[95, 0] = "Hyundai"; matRepuesto[95, 1] = "Corea del Sur"; matRepuesto[95, 2] = "10095"; matRepuesto[95, 3] = "53754"; matRepuesto[95, 4] = "Compresor de aire";
            matRepuesto[96, 0] = "Ford"; matRepuesto[96, 1] = "Brasil"; matRepuesto[96, 2] = "10096"; matRepuesto[96, 3] = "54954"; matRepuesto[96, 4] = "Bujía de encendido";
            matRepuesto[97, 0] = "Chevrolet"; matRepuesto[97, 1] = "México"; matRepuesto[97, 2] = "10097"; matRepuesto[97, 3] = "80452"; matRepuesto[97, 4] = "Filtro de aire";
            matRepuesto[98, 0] = "Peugeot"; matRepuesto[98, 1] = "Alemania"; matRepuesto[98, 2] = "10098"; matRepuesto[98, 3] = "29180"; matRepuesto[98, 4] = "Pastillas de freno";
            matRepuesto[99, 0] = "Mercedes-Benz"; matRepuesto[99, 1] = "Francia"; matRepuesto[99, 2] = "10099"; matRepuesto[99, 3] = "99941"; matRepuesto[99, 4] = "Disco de freno";



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

            matRepuesto[indiceGrabar, 0] = "Marca";
            matRepuesto[indiceGrabar, 1] = "Origen";
            matRepuesto[indiceGrabar, 2] = "numero";
            matRepuesto[indiceGrabar, 3] = "precio";
            matRepuesto[indiceGrabar, 4] = "descripcion";
            indiceGrabar++;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
         
        }
    }
}