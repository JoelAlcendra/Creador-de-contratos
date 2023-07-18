namespace Parcial_Final
{
    partial class Menu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearContratoMenu = new System.Windows.Forms.Button();
            this.btnLLenarDatosMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCrearContratoMenu);
            this.groupBox1.Controls.Add(this.btnLLenarDatosMenu);
            this.groupBox1.Location = new System.Drawing.Point(70, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Principal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Para crear su contrato debe llenar los datos basicos.";
            // 
            // btnCrearContratoMenu
            // 
            this.btnCrearContratoMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrearContratoMenu.Location = new System.Drawing.Point(242, 106);
            this.btnCrearContratoMenu.Name = "btnCrearContratoMenu";
            this.btnCrearContratoMenu.Size = new System.Drawing.Size(147, 115);
            this.btnCrearContratoMenu.TabIndex = 1;
            this.btnCrearContratoMenu.Text = "CREAR CONTRATO LABORAL";
            this.btnCrearContratoMenu.UseVisualStyleBackColor = true;
            this.btnCrearContratoMenu.Click += new System.EventHandler(this.btnCrearContratoMenu_Click);
            // 
            // btnLLenarDatosMenu
            // 
            this.btnLLenarDatosMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLLenarDatosMenu.Location = new System.Drawing.Point(42, 106);
            this.btnLLenarDatosMenu.Name = "btnLLenarDatosMenu";
            this.btnLLenarDatosMenu.Size = new System.Drawing.Size(147, 115);
            this.btnLLenarDatosMenu.TabIndex = 0;
            this.btnLLenarDatosMenu.Text = "LLENAR DATOS BASICOS";
            this.btnLLenarDatosMenu.UseVisualStyleBackColor = true;
            this.btnLLenarDatosMenu.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnCrearContratoMenu;
        private Button btnLLenarDatosMenu;
    }
}