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
using Entidad;


using ClosedXML.Excel; // esto es para excel    
using iText.Kernel.Pdf; // esto es para pdf
using iText.Layout; // esto es para pdf
using iText.Layout.Element; // esto es para pdf
using iText.Layout.Properties; // esto es para pdf
using iText.Kernel.Font;
using iText.IO.Font.Constants; // esto es para pdf

namespace Presentacion
{
    public partial class frmReportes : Form
    {
        private readonly ReporteBLL _bll = new ReporteBLL();
        private string _rol;
        private string _usuario;
        public frmReportes(string usuario, string rol)
        {
            InitializeComponent();

            _rol = rol;
            _usuario = usuario;

            this.Load += frmReportes_Load;
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            cboTipo.Items.Clear();
            cboTipo.Items.Add("Por Área");
            cboTipo.Items.Add("Contratos Activos");
            cboTipo.Items.Add("Contratos Vencidos");
            cboTipo.Items.Add("Alertas");

            cboTipo.SelectedIndex = 0;

            if (_rol != "Operador")

                btnExcel.Enabled = false;

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            switch (cboTipo.SelectedIndex)
            {
                case 0:
                    dgv.DataSource = _bll.PorArea();
                    _bll.RegistrarLog("Generó reporte por área", _usuario);
                    break;
                case 1:
                    dgv.DataSource = _bll.Activos();
                    _bll.RegistrarLog("Generó reporte de contratos activos", _usuario);
                    break;
                case 2:
                    dgv.DataSource = _bll.Vencidos();
                    _bll.RegistrarLog("Generó reporte de contratos vencidos", _usuario);
                    break;
                case 3:
                    dgv.DataSource = _bll.Alertas();
                    _bll.RegistrarLog("Generó reporte de alertas", _usuario);
                    break;
            }
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using var sw = new StreamWriter(sfd.FileName);
                foreach (DataGridViewColumn col in dgv.Columns)
                    sw.Write(col.HeaderText + ",");
                sw.WriteLine();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)

                        sw.Write(cell.Value + ",");

                    sw.WriteLine();
                }

                MessageBox.Show("CSV Generado correctamente ");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }


            using var sfd = new SaveFileDialog();
            sfd.Filter = "Excel files (*.xlsx)|*.xlsx";
            sfd.FileName = $"Reporte_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("Reporte");

                // aca empieza el encabezado

                for (int i = 0; i < dgv.Columns.Count; i++)
                    ws.Cell(1, i + 1).Value = dgv.Columns[i].HeaderText;

                // dats
                for (int i = 0; i < dgv.Rows.Count; i++)

                {
                    if (dgv.Rows[i].IsNewRow) continue;
                    for (int j = 0; j < dgv.Columns.Count; j++)

                        ws.Cell(i + 2, j + 1).Value =

                          dgv.Rows[i].Cells[j].Value?.ToString();

                }

                wb.SaveAs(sfd.FileName);
                MessageBox.Show("Excel generado correctamente");

                wb.SaveAs(sfd.FileName);
                MessageBox.Show("Excel generado correctamente.");

            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {

        }
    }
}
