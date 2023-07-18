namespace Parcial_Final
{
    partial class frmDatosBasicos
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btnCrearContrato = new Button();
            btnGuardarDatos = new Button();
            btnGrabarDatos = new Button();
            txtCorreo = new TextBox();
            label10 = new Label();
            txtCelular = new TextBox();
            label9 = new Label();
            txtDireccion = new TextBox();
            label8 = new Label();
            cmbEstadoCivil = new ComboBox();
            label7 = new Label();
            rdbFemenino = new RadioButton();
            rdbMasculino = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            dtpFechaNac = new DateTimePicker();
            txtApellidos = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            cmbTipoId = new ComboBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(btnCrearContrato);
            groupBox1.Controls.Add(btnGuardarDatos);
            groupBox1.Controls.Add(btnGrabarDatos);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtCelular);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmbEstadoCivil);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(rdbFemenino);
            groupBox1.Controls.Add(rdbMasculino);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpFechaNac);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbTipoId);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(78, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 363);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Portal Datos Basicos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnCrearContrato
            // 
            btnCrearContrato.Location = new Point(351, 273);
            btnCrearContrato.Name = "btnCrearContrato";
            btnCrearContrato.Size = new Size(91, 41);
            btnCrearContrato.TabIndex = 23;
            btnCrearContrato.Text = "Crear Contrato";
            btnCrearContrato.UseVisualStyleBackColor = true;
            btnCrearContrato.Click += btnCrearContrato_Click;
            // 
            // btnGuardarDatos
            // 
            btnGuardarDatos.Location = new Point(351, 219);
            btnGuardarDatos.Name = "btnGuardarDatos";
            btnGuardarDatos.Size = new Size(91, 41);
            btnGuardarDatos.TabIndex = 22;
            btnGuardarDatos.Text = "Guardar Datos";
            btnGuardarDatos.UseVisualStyleBackColor = true;
            btnGuardarDatos.Click += btnGuardarDatos_Click;
            // 
            // btnGrabarDatos
            // 
            btnGrabarDatos.Location = new Point(351, 164);
            btnGrabarDatos.Name = "btnGrabarDatos";
            btnGrabarDatos.Size = new Size(91, 41);
            btnGrabarDatos.TabIndex = 21;
            btnGrabarDatos.Text = "Grabar Datos";
            btnGrabarDatos.UseVisualStyleBackColor = true;
            btnGrabarDatos.Click += button1_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(29, 273);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(127, 23);
            txtCorreo.TabIndex = 20;
            txtCorreo.Validating += txtCorreo_Validating;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 255);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 19;
            label10.Text = "Correo";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(29, 229);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(127, 23);
            txtCelular.TabIndex = 18;
            txtCelular.Validating += txtCelular_Validating;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 211);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 17;
            label9.Text = "Celular";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(29, 185);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(127, 23);
            txtDireccion.TabIndex = 16;
            txtDireccion.Validating += txtDireccion_Validating;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 169);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 15;
            label8.Text = "Direccion";
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Items.AddRange(new object[] { "", "SOLTERO ", "CASADO", "VIUDO", "UNION LIBRE", "DIVORCIADO" });
            cmbEstadoCivil.Location = new Point(191, 203);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(127, 23);
            cmbEstadoCivil.TabIndex = 14;
            cmbEstadoCivil.Validating += cmbEstadoCivil_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(191, 185);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 13;
            label7.Text = "Estado Civil";
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.Location = new Point(191, 163);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(78, 19);
            rdbFemenino.TabIndex = 12;
            rdbFemenino.TabStop = true;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(191, 143);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 11;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            rdbMasculino.CheckedChanged += rdbMasculino_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(191, 125);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 10;
            label6.Text = "Sexo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(191, 81);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 9;
            label5.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(191, 99);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(127, 23);
            dtpFechaNac.TabIndex = 8;
            dtpFechaNac.ValueChanged += dtpFechaNac_ValueChanged;
            dtpFechaNac.Validating += dtpFechaNac_Validating;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(29, 143);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(127, 23);
            txtApellidos.TabIndex = 7;
            txtApellidos.Validating += txtApellidos_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 125);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 6;
            label4.Text = "Apelidos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(29, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(127, 23);
            txtNombre.TabIndex = 5;
            txtNombre.Validating += txtNombre_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 81);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // cmbTipoId
            // 
            cmbTipoId.FormattingEnabled = true;
            cmbTipoId.Items.AddRange(new object[] { "", "CEDULA", "TARJETA IDENTIDAD", "PASAPORTE" });
            cmbTipoId.Location = new Point(191, 55);
            cmbTipoId.Name = "cmbTipoId";
            cmbTipoId.Size = new Size(127, 23);
            cmbTipoId.TabIndex = 3;
            cmbTipoId.Validating += cmbTipoId_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 37);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo Identificacion ";
            // 
            // txtId
            // 
            txtId.Location = new Point(29, 55);
            txtId.Name = "txtId";
            txtId.Size = new Size(127, 23);
            txtId.TabIndex = 1;
            txtId.Validating += txtId_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 37);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Identificacion ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmDatosBasicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(605, 450);
            Controls.Add(groupBox1);
            Name = "frmDatosBasicos";
            Text = "frmDatosBasicos";
            Load += frmDatosBasicos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtId;
        private Label label1;
        private ComboBox cmbTipoId;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtApellidos;
        private Label label4;
        private RadioButton rdbMasculino;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpFechaNac;
        private ComboBox cmbEstadoCivil;
        private Label label7;
        private RadioButton rdbFemenino;
        private TextBox txtCelular;
        private Label label9;
        private TextBox txtDireccion;
        private Label label8;
        private TextBox txtCorreo;
        private Label label10;
        private Button btnGrabarDatos;
        private Button btnCrearContrato;
        private Button btnGuardarDatos;
        private SaveFileDialog saveFileDialog1;
        private ErrorProvider errorProvider1;
    }
}