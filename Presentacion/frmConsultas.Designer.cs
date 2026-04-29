namespace Presentacion
{
    partial class frmConsultas
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
            cboOpciones = new ComboBox();
            btnEjecutar = new Button();
            dvgDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgDatos).BeginInit();
            SuspendLayout();
            // 
            // cboOpciones
            // 
            cboOpciones.FormattingEnabled = true;
            cboOpciones.Location = new Point(30, 23);
            cboOpciones.Name = "cboOpciones";
            cboOpciones.Size = new Size(216, 23);
            cboOpciones.TabIndex = 0;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(291, 23);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(124, 23);
            btnEjecutar.TabIndex = 1;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // dvgDatos
            // 
            dvgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDatos.Location = new Point(30, 74);
            dvgDatos.Name = "dvgDatos";
            dvgDatos.Size = new Size(621, 150);
            dvgDatos.TabIndex = 2;
            // 
            // frmConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 247);
            Controls.Add(dvgDatos);
            Controls.Add(btnEjecutar);
            Controls.Add(cboOpciones);
            Name = "frmConsultas";
            Text = "frmConsultas";
            Load += frmConsultas_Load;
            ((System.ComponentModel.ISupportInitialize)dvgDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboOpciones;
        private Button btnEjecutar;
        private DataGridView dvgDatos;
    }
}