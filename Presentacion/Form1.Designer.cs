namespace Presentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnGuardar = new Button();
            dvgEmpleados = new DataGridView();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtCorreo = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            txtSalario = new TextBox();
            txtDNI = new TextBox();
            dtpFecha = new DateTimePicker();
            cboArea = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPrueba = new TextBox();
            label8 = new Label();
            dtpFin = new DateTimePicker();
            label9 = new Label();
            cboTipoContrato = new ComboBox();
            btnMonitorAsync = new Button();
            btnConsultas = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(223, 358);
            btnGuardar.Margin = new Padding(2, 1, 2, 1);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(81, 22);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dvgEmpleados
            // 
            dvgEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgEmpleados.Location = new Point(23, 13);
            dvgEmpleados.Margin = new Padding(2, 1, 2, 1);
            dvgEmpleados.Name = "dvgEmpleados";
            dvgEmpleados.RowHeadersWidth = 82;
            dvgEmpleados.Size = new Size(711, 141);
            dvgEmpleados.TabIndex = 1;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(93, 181);
            txtNombres.Margin = new Padding(2, 1, 2, 1);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(110, 23);
            txtNombres.TabIndex = 2;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(93, 216);
            txtApellidos.Margin = new Padding(2, 1, 2, 1);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(110, 23);
            txtApellidos.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(329, 218);
            txtCorreo.Margin = new Padding(2, 1, 2, 1);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(110, 23);
            txtCorreo.TabIndex = 4;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(93, 254);
            txtSalario.Margin = new Padding(2, 1, 2, 1);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(110, 23);
            txtSalario.TabIndex = 5;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(329, 184);
            txtDNI.Margin = new Padding(2, 1, 2, 1);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(110, 23);
            txtDNI.TabIndex = 6;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(360, 253);
            dtpFecha.Margin = new Padding(2, 1, 2, 1);
            dtpFecha.MaxDate = new DateTime(2054, 12, 31, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 7;
            // 
            // cboArea
            // 
            cboArea.FormattingEnabled = true;
            cboArea.Location = new Point(93, 295);
            cboArea.Margin = new Padding(2, 1, 2, 1);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(132, 23);
            cboArea.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 179);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 216);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 10;
            label2.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 257);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 11;
            label3.Text = "Fecha Ingreso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 219);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 12;
            label4.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(254, 184);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 13;
            label5.Text = "DNI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 254);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 14;
            label6.Text = "Salario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 297);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 15;
            label7.Text = "Area";
            // 
            // txtPrueba
            // 
            txtPrueba.Location = new Point(93, 342);
            txtPrueba.Name = "txtPrueba";
            txtPrueba.Size = new Size(100, 23);
            txtPrueba.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(259, 298);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 17;
            label8.Text = "Fecha FIN";
            // 
            // dtpFin
            // 
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(360, 291);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(200, 23);
            dtpFin.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(259, 331);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 19;
            label9.Text = "Tipo de Contrato";
            // 
            // cboTipoContrato
            // 
            cboTipoContrato.FormattingEnabled = true;
            cboTipoContrato.Location = new Point(360, 328);
            cboTipoContrato.Name = "cboTipoContrato";
            cboTipoContrato.Size = new Size(121, 23);
            cboTipoContrato.TabIndex = 20;
            // 
            // btnMonitorAsync
            // 
            btnMonitorAsync.Location = new Point(643, 184);
            btnMonitorAsync.Name = "btnMonitorAsync";
            btnMonitorAsync.Size = new Size(141, 23);
            btnMonitorAsync.TabIndex = 21;
            btnMonitorAsync.Text = "Monitor Async";
            btnMonitorAsync.UseVisualStyleBackColor = true;
            btnMonitorAsync.Click += btnMonitorAsync_Click;
            // 
            // btnConsultas
            // 
            btnConsultas.Location = new Point(645, 229);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Size = new Size(139, 23);
            btnConsultas.TabIndex = 22;
            btnConsultas.Text = "Consultas LINQ";
            btnConsultas.UseVisualStyleBackColor = true;
            btnConsultas.Click += btnConsultas_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 390);
            Controls.Add(btnConsultas);
            Controls.Add(btnMonitorAsync);
            Controls.Add(cboTipoContrato);
            Controls.Add(label9);
            Controls.Add(dtpFin);
            Controls.Add(label8);
            Controls.Add(txtPrueba);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboArea);
            Controls.Add(dtpFecha);
            Controls.Add(txtDNI);
            Controls.Add(txtSalario);
            Controls.Add(txtCorreo);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(dvgEmpleados);
            Controls.Add(btnGuardar);
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmPrincipal";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dvgEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private DataGridView dvgEmpleados;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtCorreo;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtSalario;
        private TextBox txtDNI;
        private DateTimePicker dtpFecha;
        private ComboBox cboArea;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPrueba;
        private Label label8;
        private DateTimePicker dtpFin;
        private Label label9;
        private ComboBox cboTipoContrato;
        private Button btnMonitorAsync;
        private Button btnConsultas;
    }
}
