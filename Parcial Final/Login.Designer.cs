namespace Parcial_Final
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            groupBox1 = new GroupBox();
            label3 = new Label();
            btnIngresar = new Button();
            pictureBox1 = new PictureBox();
            txtContraseña = new TextBox();
            label2 = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(84, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 334);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Iniciar Sesion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(156, 67);
            label3.Name = "label3";
            label3.Size = new Size(198, 45);
            label3.TabIndex = 7;
            label3.Text = "Bienvenido!";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(257, 262);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(97, 34);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(73, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(257, 216);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(144, 23);
            txtContraseña.TabIndex = 4;
            txtContraseña.Validating += txtContraseña_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 198);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(257, 172);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(144, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.Validating += txtUsuario_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 154);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(701, 407);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtContraseña;
        private Label label2;
        private TextBox txtUsuario;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnIngresar;
        private Label label3;
        private ErrorProvider errorProvider1;
    }
}