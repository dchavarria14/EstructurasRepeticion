namespace pjControlRegistroParticipantes
{
    public partial class frmParticipantes : Form
    {
        int num;
        int cJefe, cOperario, cAdministrativo, cPracticante;

        public frmParticipantes()
        {
            InitializeComponent();
            tHora.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estás seguro de salir?",
                                             "Participantes",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Exclamation);

        }

        private void tHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void frmParticipantes_Load(object sender, EventArgs e)
        {
            num++;
            lblNumero.Text = num.ToString("D4");
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Capturando los datos
            DateTime fecha, hora;
            string participante, cargo;
            int numero;
            participante = txtParticipantes.Text;
            numero = int.Parse(lblNumero.Text);
            fecha = DateTime.Parse(lblFecha.Text);
            hora = DateTime.Parse(lblHora.Text);
            cargo = cboCargo.Text;

            //Contabilizar la cantidad según los cargos
            switch (cargo)
            {
                case "Jefe": cJefe++; break;
                case "Operario": cOperario++; break;
                case "Administrativo": cAdministrativo++; break;
                case "Practicantes": cPracticante++; break;
            }

            //Imprimiendo el registro
            ListViewItem fila = new ListViewItem(numero.ToString());
            fila.SubItems.Add(participante);
            fila.SubItems.Add(cargo);
            fila.SubItems.Add(fecha.ToString("d"));
            fila.SubItems.Add(hora.ToString("hh:mm:ss"));
            lvParticipantes.Items.Add(fila);

            //Imprimiendo las estadísticas
            lvEstadisticas.Items.Clear();
            string[] elementosFila = new string[2];
            ListViewItem row;

            //Añadimos la segunda fila al lvEstadisticas
            elementosFila[0] = "Jefe";
            elementosFila[1] = cJefe.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            //Añadimos la segunda fila al lvEstadisticas
            elementosFila[0] = "Operario";
            elementosFila[1] = cOperario.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            //Añadimos la tercera fila al lvEstadisticas
            elementosFila[0] = "Administrativo";
            elementosFila[1] = cAdministrativo.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            //Añadimos la cuarta fila al lvEstadisticas
            elementosFila[0] = "Practicante";
            elementosFila[1] = cPracticante.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            //Mostrando el nuevo numero de registo
            num++;
            lblNumero.Text = num.ToString("D4");

            //Limpiando los controles
            txtParticipantes.Clear();
            cboCargo.SelectedIndex = -1;
            cboCargo.Text = "(Seleccione el cargo)";
            txtParticipantes.Focus();

        }
    }
}