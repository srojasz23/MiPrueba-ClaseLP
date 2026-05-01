using Entidad;
using Negocio;
using Negocio.BLL;

namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        private readonly EmpleadoBLL _bll = new EmpleadoBLL();


        private string _rol;
        private string _usuario;
        public frmPrincipal(string usuario, string rol)
        {
            InitializeComponent();
            _rol = rol;
            _usuario = usuario;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarAreas();

            CargarTipoContrato();


            //aca aplico el tema de controles segun el rol del usuario


            if (_rol == "Supervisor")
            {
                btnGuardar.Enabled = false;
                // otros controles que quieras deshabilitar para el operador
            }
        }


        private void CargarAreas()
        {
            var bll = new AreaBLL();
            var lista = bll.ObtenerAreas();

            cboArea.DataSource = lista;
            cboArea.DisplayMember = "Nombre";
            cboArea.ValueMember = "IdArea";
        }

        private void CargarEmpleados()
        {
            dvgEmpleados.DataSource = _bll.ObtenerTodos();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtSalario.Text, out _))
                {
                    MessageBox.Show("El salario debe ser un número válido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                if (cboArea.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un área válida",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var emp = new Empleado
                {
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text,
                    DNI = txtDNI.Text,
                    Correo = txtCorreo.Text,
                    Salario = double.Parse(txtSalario.Text),
                    FechaIngreso = dtpFecha.Value,
                    IdArea = (int)cboArea.SelectedValue!
                };

                DateTime inicio = dtpFecha.Value;
                DateTime? fin = dtpFin.Value;
                string tipo = cboTipoContrato.SelectedItem.ToString();


                if (_bll.RegistrarConContrato(emp, inicio, fin, tipo, _rol))
                {
                    MessageBox.Show("Empleado y contrato registrado",
                        "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarEmpleados();
                    LimpiarCampos();

                }

                else
                {
                    MessageBox.Show("Error al registrar empleado y contrato",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                /*
                if (_bll.Registrar(emp))
                {
                    MessageBox.Show("Empleado registrado.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEmpleados();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al registrar el empleado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }*/

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarCampos()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDNI.Clear();
            txtCorreo.Clear();
            txtSalario.Clear();
            dtpFecha.Value = DateTime.Now;
            cboArea.SelectedIndex = -1;

        }


        private void CargarTipoContrato()
        {
            cboTipoContrato.Items.Clear();

            cboTipoContrato.Items.Add("Indefinido");
            cboTipoContrato.Items.Add("Temporal");
            cboTipoContrato.Items.Add("Practicante");

            cboTipoContrato.SelectedIndex = 0;



        }

        private void btnMonitorAsync_Click(object sender, EventArgs e)
        {
            new frmMonitorAsync().Show();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            new frmConsultas().Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            new frmReportes(_usuario, _rol).Show();
        }
    }
}