using ClosedXML.Excel;
using Entidad;
using iText.Kernel.Pdf;
using Negocio;
using Negocio.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font.Constants;


namespace Presentacion

{

    public partial class frmReportes : Form

    {

        private readonly ReporteBLL _bll = new ReporteBLL();

        private string _usuario;

        private string _rol;

        public frmReportes(string usuario, string rol)

        {

            InitializeComponent();
            _usuario = usuario;

            _rol = rol;
            this.Load += frmReportes_Load;

        }





        private void frmReportes_Load(object sender, EventArgs e)

        {

            cboTipo.Items.Add("Por Área");
            cboTipo.Items.Add("Contratos Activos");
            cboTipo.Items.Add("Contratos Vencidos");
            cboTipo.Items.Add("Alertas");
            cboTipo.SelectedIndex = 0;



            if (_rol == "Operador")

                btnExcel.Enabled = false;

        }



        private void btnGenerar_Click(object sender, EventArgs e)

        {

            switch (cboTipo.SelectedIndex)

            {

                case 0:

                    dgv.DataSource = _bll.PorArea();

                    _bll.RegistrarLog("Por Área", _usuario);

                    break;



                case 1:

                    dgv.DataSource = _bll.Activos();
                    _bll.RegistrarLog("Activos", _usuario);

                    break;



                case 2:

                    dgv.DataSource = _bll.Vencidos();

                    _bll.RegistrarLog("Vencidos", _usuario);

                    break;



                case 3:

                    dgv.DataSource = _bll.Alertas();

                    _bll.RegistrarLog("Alertas", _usuario);

                    break;

            }

        }



        private void btnCSV_Click(object sender, EventArgs e)

        {

            using var sfd = new SaveFileDialog();

            sfd.Filter = "CSV (*.csv)|*.csv";



            if (sfd.ShowDialog() == DialogResult.OK)

            {

                using var sw = new StreamWriter(sfd.FileName);



                foreach (DataGridViewColumn col in dgv.Columns)

                    sw.Write(col.HeaderText + ";");



                sw.WriteLine();



                foreach (DataGridViewRow row in dgv.Rows)

                {

                    if (row.IsNewRow) continue;





                    foreach (DataGridViewCell cell in row.Cells)

                        sw.Write(cell.Value + ";");



                    sw.WriteLine();

                }



                MessageBox.Show("CSV generado");

            }

        }



        private void btnExcel_Click(object sender, EventArgs e)

        {

            if (dgv.Rows.Count == 0)

            {

                MessageBox.Show("No hay datos para exportar");

                return;

            }



            using var sfd = new SaveFileDialog();

            sfd.Filter = "Excel (*.xlsx)|*.xlsx";

            sfd.FileName = $"Reporte_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";



            if (sfd.ShowDialog() == DialogResult.OK)

            {

                var wb = new XLWorkbook();

                var ws = wb.Worksheets.Add("Reporte");



                // Encabezados

                for (int i = 0; i < dgv.Columns.Count; i++)

                    ws.Cell(1, i + 1).Value = dgv.Columns[i].HeaderText;



                // Datos

                for (int i = 0; i < dgv.Rows.Count; i++)

                {

                    if (dgv.Rows[i].IsNewRow) continue;



                    for (int j = 0; j < dgv.Columns.Count; j++)

                        ws.Cell(i + 2, j + 1).Value =

                          dgv.Rows[i].Cells[j].Value?.ToString();

                }



                wb.SaveAs(sfd.FileName);



                MessageBox.Show("Excel generado correctamente");

            }

        }



        private void btnPDF_Click(object sender, EventArgs e)

        {

            if (dgv.Rows.Count == 0)

            {

                MessageBox.Show("No hay datos para exportar");

                return;

            }



            using var sfd = new SaveFileDialog();

            sfd.Filter = "PDF (*.pdf)|*.pdf";

            sfd.FileName = $"Reporte_{DateTime.Now:yyyyMMdd_HHmm}.pdf";


            if (sfd.ShowDialog() != DialogResult.OK) return;


            var writer = new PdfWriter(sfd.FileName);

            var pdf = new PdfDocument(writer);

            var document = new Document(pdf);





            var fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            var fontBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);





            document.Add(new Paragraph("REPORTE DE EMPLEADOS")

              .SetFont(fontBold)

              .SetFontSize(16)

              .SetTextAlignment(TextAlignment.CENTER));





            document.Add(new Paragraph($"Usuario: {_usuario}")

              .SetFont(fontNormal));



            document.Add(new Paragraph($"Fecha: {DateTime.Now}")

              .SetFont(fontNormal));



            document.Add(new Paragraph(" ")); // espacio





            var table = new Table(dgv.Columns.Count);



            // Encabezados

            foreach (DataGridViewColumn col in dgv.Columns)

            {

                table.AddHeaderCell(

                  new Cell().Add(

                    new Paragraph(col.HeaderText)

                    .SetFont(fontBold)

                  )

                );

            }



            int totalRegistros = 0;



            // Filas

            foreach (DataGridViewRow row in dgv.Rows)

            {

                if (row.IsNewRow) continue;



                foreach (DataGridViewCell cell in row.Cells)

                {

                    table.AddCell(

                      new Cell().Add(

                        new Paragraph(cell.Value?.ToString() ?? "")

                        .SetFont(fontNormal)

                      )

                    );

                }



                totalRegistros++;

            }



            document.Add(table);





            document.Add(new Paragraph(" "));

            document.Add(new Paragraph($"TOTAL REGISTROS: {totalRegistros}")

              .SetFont(fontBold));





            document.Close();



            MessageBox.Show("PDF generado correctamente");

        }

    }



}