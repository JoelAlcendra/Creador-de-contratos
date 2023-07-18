namespace Parcial_Final
{
    partial class frmContratos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContratos));
            groupBox1 = new GroupBox();
            btnGuardarContrato = new Button();
            btnGrabarContrato = new Button();
            button1 = new Button();
            cmbEstadoContrato = new ComboBox();
            label11 = new Label();
            txtSueldoBasico = new TextBox();
            label10 = new Label();
            cmbFormaPago = new ComboBox();
            label9 = new Label();
            dtnFechaRetiro = new DateTimePicker();
            label8 = new Label();
            dtpFechaIngreso = new DateTimePicker();
            label7 = new Label();
            cmbTipoContrato = new ComboBox();
            label6 = new Label();
            cmbEstadoEmpleado = new ComboBox();
            label5 = new Label();
            txtApellidos = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtNumContrato = new TextBox();
            label1 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(btnGuardarContrato);
            groupBox1.Controls.Add(btnGrabarContrato);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cmbEstadoContrato);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtSueldoBasico);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cmbFormaPago);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dtnFechaRetiro);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpFechaIngreso);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbTipoContrato);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbEstadoEmpleado);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNumContrato);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(97, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 371);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Portal Contratos";
            // 
            // btnGuardarContrato
            // 
            btnGuardarContrato.Location = new Point(197, 314);
            btnGuardarContrato.Name = "btnGuardarContrato";
            btnGuardarContrato.Size = new Size(93, 38);
            btnGuardarContrato.TabIndex = 25;
            btnGuardarContrato.Text = "Guardar Contrato ";
            btnGuardarContrato.UseVisualStyleBackColor = true;
            btnGuardarContrato.Click += button3_Click;
            // 
            // btnGrabarContrato
            // 
            btnGrabarContrato.Location = new Point(197, 270);
            btnGrabarContrato.Name = "btnGrabarContrato";
            btnGrabarContrato.Size = new Size(93, 38);
            btnGrabarContrato.TabIndex = 24;
            btnGrabarContrato.Text = "Grabar Contrato";
            btnGrabarContrato.UseVisualStyleBackColor = true;
            btnGrabarContrato.Click += btnGrabarContrato_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(149, 103);
            button1.Name = "button1";
            button1.Size = new Size(30, 32);
            button1.TabIndex = 23;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbEstadoContrato
            // 
            cmbEstadoContrato.FormattingEnabled = true;
            cmbEstadoContrato.Items.AddRange(new object[] { "", "ACTIVO", "INACTIVO" });
            cmbEstadoContrato.Location = new Point(190, 235);
            cmbEstadoContrato.Name = "cmbEstadoContrato";
            cmbEstadoContrato.Size = new Size(130, 23);
            cmbEstadoContrato.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(190, 217);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 20;
            label11.Text = "Estado Contrato";
            // 
            // txtSueldoBasico
            // 
            txtSueldoBasico.Location = new Point(21, 279);
            txtSueldoBasico.Name = "txtSueldoBasico";
            txtSueldoBasico.Size = new Size(128, 23);
            txtSueldoBasico.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 261);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 18;
            label10.Text = "Sueldo Basico";
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.Items.AddRange(new object[] { "", "CHEQUE", "CONSIGNACION", "EFECTIVO" });
            cmbFormaPago.Location = new Point(22, 235);
            cmbFormaPago.Name = "cmbFormaPago";
            cmbFormaPago.Size = new Size(128, 23);
            cmbFormaPago.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 217);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 16;
            label9.Text = "Forma de Pago";
            // 
            // dtnFechaRetiro
            // 
            dtnFechaRetiro.Format = DateTimePickerFormat.Short;
            dtnFechaRetiro.Location = new Point(190, 191);
            dtnFechaRetiro.Name = "dtnFechaRetiro";
            dtnFechaRetiro.Size = new Size(130, 23);
            dtnFechaRetiro.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(190, 173);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 14;
            label8.Text = "Fecha Retiro";
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.Location = new Point(190, 147);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(130, 23);
            dtpFechaIngreso.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(190, 129);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 12;
            label7.Text = "Fecha Ingreso";
            // 
            // cmbTipoContrato
            // 
            cmbTipoContrato.FormattingEnabled = true;
            cmbTipoContrato.Items.AddRange(new object[] { "", "INDEFINIDO", "DEFINIDO", "ESTUDIANTE PRACTICA" });
            cmbTipoContrato.Location = new Point(190, 103);
            cmbTipoContrato.Name = "cmbTipoContrato";
            cmbTipoContrato.Size = new Size(130, 23);
            cmbTipoContrato.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(190, 85);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 10;
            label6.Text = "Tipo Contrato";
            // 
            // cmbEstadoEmpleado
            // 
            cmbEstadoEmpleado.BackColor = SystemColors.Control;
            cmbEstadoEmpleado.FormattingEnabled = true;
            cmbEstadoEmpleado.Items.AddRange(new object[] { "", "ACTIVO", "INACTIVO" });
            cmbEstadoEmpleado.Location = new Point(190, 59);
            cmbEstadoEmpleado.Name = "cmbEstadoEmpleado";
            cmbEstadoEmpleado.Size = new Size(130, 23);
            cmbEstadoEmpleado.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 41);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 8;
            label5.Text = "Estado del Empleado";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(22, 191);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(128, 23);
            txtApellidos.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 173);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 6;
            label4.Text = "Apellidos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 147);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(128, 23);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 129);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Location = new Point(22, 103);
            txtId.Name = "txtId";
            txtId.Size = new Size(128, 23);
            txtId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 85);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Identificacion ";
            // 
            // txtNumContrato
            // 
            txtNumContrato.Location = new Point(22, 59);
            txtNumContrato.Name = "txtNumContrato";
            txtNumContrato.Size = new Size(129, 23);
            txtNumContrato.TabIndex = 1;
            txtNumContrato.TextChanged += txtNumContrato_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 41);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero Contrato";
            // 
            // frmContratos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(579, 450);
            Controls.Add(groupBox1);
            Name = "frmContratos";
            Text = "formulario contratos";
            Load += frmContratos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNumContrato;
        private Label label1;
        private ComboBox cmbEstadoEmpleado;
        private Label label5;
        private TextBox txtApellidos;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtId;
        private Label label2;
        private ComboBox cmbTipoContrato;
        private Label label6;
        private ComboBox cmbFormaPago;
        private Label label9;
        private DateTimePicker dtnFechaRetiro;
        private Label label8;
        private DateTimePicker dtpFechaIngreso;
        private Label label7;
        private ComboBox cmbEstadoContrato;
        private Label label11;
        private TextBox txtSueldoBasico;
        private Label label10;
        private Button button1;
        private Button btnGrabarContrato;
        private Button btnGuardarContrato;
        private SaveFileDialog saveFileDialog1;
    }
}