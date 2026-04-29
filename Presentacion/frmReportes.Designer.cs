namespace Presentacion
{
    partial class frmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboTipo = new ComboBox();
            btnGenerar = new Button();
            btnCSV = new Button();
            btnExcel = new Button();
            dgv = new DataGridView();
            btnPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(12, 32);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(183, 23);
            cboTipo.TabIndex = 0;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(12, 82);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(183, 23);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnCSV
            // 
            btnCSV.Location = new Point(12, 134);
            btnCSV.Name = "btnCSV";
            btnCSV.Size = new Size(183, 23);
            btnCSV.TabIndex = 2;
            btnCSV.Text = "CSV";
            btnCSV.UseVisualStyleBackColor = true;
            btnCSV.Click += btnCSV_Click;
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(12, 180);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(183, 23);
            btnExcel.TabIndex = 3;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(234, 32);
            dgv.Name = "dgv";
            dgv.Size = new Size(799, 212);
            dgv.TabIndex = 4;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(12, 221);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(183, 23);
            btnPDF.TabIndex = 5;
            btnPDF.Text = "PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 285);
            Controls.Add(btnPDF);
            Controls.Add(dgv);
            Controls.Add(btnExcel);
            Controls.Add(btnCSV);
            Controls.Add(btnGenerar);
            Controls.Add(cboTipo);
            Name = "frmReportes";
            Text = "frmReportes";
            Load += frmReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboTipo;
        private Button btnGenerar;
        private Button btnCSV;
        private Button btnExcel;
        private DataGridView dgv;
        private Button btnPDF;
    }
}