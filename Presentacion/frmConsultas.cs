using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Negocio.BLL;

namespace Presentacion
{
    public partial class frmConsultas : Form
    {
        private readonly EmpleadoBLL _bll = new EmpleadoBLL();
        public frmConsultas()
        {
            InitializeComponent();
            this.Load += frmConsultas_Load;
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            cboOpciones.Items.Add("Salario >3000");
            cboOpciones.Items.Add("Ordenar por nombre");
            cboOpciones.Items.Add("solo nombre y salario");
            cboOpciones.Items.Add("Agrupar por area");

            cboOpciones.SelectedIndex = 0;

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            var lista = _bll.ObtenerTodos();


            switch (cboOpciones.SelectedIndex)
                {
                    case 0:
                    dvgDatos.DataSource = lista
                    .Where(e => e.Salario > 3000)
                       .ToList();
                        break;  

                    case 1:
                    dvgDatos.DataSource = lista
                    .OrderBy(e => e.Nombres)
                       .ToList();
                        break;

                    case 2:
                    dvgDatos.DataSource = lista
                    .Select(e => new
                    { e.Nombres, e.Salario })
                        .ToList();
                        break;

                    case 3:
                    dvgDatos.DataSource = lista
                    .GroupBy(e => e.NombreArea)
                    .Select(g => new
                    { Area = g.Key, Cantidad = g.Count() })
                      .ToList();
                        break; 
            }
        }
    }
}
