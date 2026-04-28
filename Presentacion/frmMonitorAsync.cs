using Negocio;
using Negocio.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmMonitorAsync : Form
    {
        private readonly EmpleadoBLL _bll = new EmpleadoBLL();
        private System.Windows.Forms.Timer timer;
        public frmMonitorAsync()
        {
            InitializeComponent();
            this.Load += frmMonitorAsync_Load;
        }

        private void frmMonitorAsync_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000; // esto equivale como 5 segundos 
            timer.Tick += async (s, ev) => await CargarAsync();

            // aca configuramos el evento del timer 
            timer.Tick += async (s, ev) =>
            {
                lblEstado.Text = "Cargar datos...";
                await CargarAsync();
                lblEstado.Text = "Actualizado";


            };
        }


        /*
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (timer == null)
            {
                MessageBox.Show("El timer no esta inicializado");
                return;
            }

            timer.Start();

        }*/

     



        private async Task CargarAsync()
        {
            var lista = await Task.Run(() => _bll.ObtenerTodos());
            dgvEmpleados.DataSource = lista;
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            if (timer == null)
            {
                MessageBox.Show("El timer no esta inicializado");
                return;
            }

            timer.Start();

        }
    }
}
