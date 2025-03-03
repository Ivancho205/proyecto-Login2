namespace loginentregable2
{
    partial class Form1
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
            txtlogin = new TextBox();
            btnnombre = new Button();
            btnID = new Button();
            btnusuario = new Button();
            btncontraseña = new Button();
            btnapellidos = new Button();
            label1 = new Label();
            txtnombre = new TextBox();
            txtapellidos = new TextBox();
            txtid = new TextBox();
            txtusuario = new TextBox();
            txtcontraseña = new TextBox();
            btnregistro = new LinkLabel();
            btnacceder = new Button();
            SuspendLayout();
            // 
            // txtlogin
            // 
            txtlogin.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtlogin.Location = new Point(385, 24);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(125, 34);
            txtlogin.TabIndex = 0;
            txtlogin.Text = "LOGIN";
            txtlogin.TextChanged += txtlogin_TextChanged;
            // 
            // btnnombre
            // 
            btnnombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnombre.Location = new Point(121, 95);
            btnnombre.Name = "btnnombre";
            btnnombre.Size = new Size(122, 29);
            btnnombre.TabIndex = 1;
            btnnombre.Text = "Nombre";
            btnnombre.UseVisualStyleBackColor = true;
            btnnombre.Click += btnnombre_Click;
            // 
            // btnID
            // 
            btnID.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnID.Location = new Point(121, 191);
            btnID.Name = "btnID";
            btnID.Size = new Size(122, 29);
            btnID.TabIndex = 2;
            btnID.Text = "ID";
            btnID.UseVisualStyleBackColor = true;
            btnID.Click += btnID_Click;
            // 
            // btnusuario
            // 
            btnusuario.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnusuario.Location = new Point(121, 244);
            btnusuario.Name = "btnusuario";
            btnusuario.Size = new Size(122, 29);
            btnusuario.TabIndex = 3;
            btnusuario.Text = "Usuario";
            btnusuario.UseVisualStyleBackColor = true;
            btnusuario.Click += btnusuario_Click;
            // 
            // btncontraseña
            // 
            btncontraseña.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncontraseña.Location = new Point(121, 298);
            btncontraseña.Name = "btncontraseña";
            btncontraseña.Size = new Size(122, 29);
            btncontraseña.TabIndex = 4;
            btncontraseña.Text = "Contraseña";
            btncontraseña.UseVisualStyleBackColor = true;
            btncontraseña.Click += btncontraseña_Click;
            // 
            // btnapellidos
            // 
            btnapellidos.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnapellidos.Location = new Point(121, 146);
            btnapellidos.Name = "btnapellidos";
            btnapellidos.Size = new Size(122, 29);
            btnapellidos.TabIndex = 5;
            btnapellidos.Text = "Apellidos";
            btnapellidos.UseVisualStyleBackColor = true;
            btnapellidos.Click += btnapellidos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 101);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 6;
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnombre.Location = new Point(261, 95);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(388, 28);
            txtnombre.TabIndex = 7;
            txtnombre.TextChanged += txtnombre_TextChanged;
            txtnombre.KeyDown += txtnombre_KeyDown;
            txtnombre.KeyPress += txtnombre_KeyPress;
            // 
            // txtapellidos
            // 
            txtapellidos.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtapellidos.Location = new Point(261, 148);
            txtapellidos.Name = "txtapellidos";
            txtapellidos.Size = new Size(388, 28);
            txtapellidos.TabIndex = 8;
            txtapellidos.TextChanged += txtapellidos_TextChanged;
            txtapellidos.KeyDown += txtapellidos_KeyDown;
            txtapellidos.KeyPress += txtapellidos_KeyPress;
            // 
            // txtid
            // 
            txtid.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtid.Location = new Point(261, 191);
            txtid.Name = "txtid";
            txtid.Size = new Size(388, 28);
            txtid.TabIndex = 9;
            txtid.TextChanged += textBox2_TextChanged;
            txtid.KeyDown += txtid_KeyDown;
            txtid.KeyPress += txtid_KeyPress;
            // 
            // txtusuario
            // 
            txtusuario.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusuario.Location = new Point(261, 244);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(388, 28);
            txtusuario.TabIndex = 10;
            txtusuario.TextChanged += txtusuario_TextChanged;
            txtusuario.KeyDown += txtusuario_KeyDown;
            txtusuario.KeyPress += txtusuario_KeyPress;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcontraseña.Location = new Point(261, 298);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(388, 28);
            txtcontraseña.TabIndex = 11;
            txtcontraseña.TextChanged += txtcontraseña_TextChanged;
            txtcontraseña.KeyDown += txtcontraseña_KeyDown;
            // 
            // btnregistro
            // 
            btnregistro.AutoSize = true;
            btnregistro.BackColor = SystemColors.GradientInactiveCaption;
            btnregistro.Location = new Point(283, 404);
            btnregistro.Name = "btnregistro";
            btnregistro.Size = new Size(324, 20);
            btnregistro.TabIndex = 12;
            btnregistro.TabStop = true;
            btnregistro.Text = "Si no es un usuario registrado inicie sesion aqui.";
            // 
            // btnacceder
            // 
            btnacceder.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnacceder.Location = new Point(261, 346);
            btnacceder.Name = "btnacceder";
            btnacceder.Size = new Size(388, 29);
            btnacceder.TabIndex = 13;
            btnacceder.Text = "ACCEDER";
            btnacceder.UseVisualStyleBackColor = true;
            btnacceder.Click += btnacceder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(btnacceder);
            Controls.Add(btnregistro);
            Controls.Add(txtcontraseña);
            Controls.Add(txtusuario);
            Controls.Add(txtid);
            Controls.Add(txtapellidos);
            Controls.Add(txtnombre);
            Controls.Add(label1);
            Controls.Add(btnapellidos);
            Controls.Add(btncontraseña);
            Controls.Add(btnusuario);
            Controls.Add(btnID);
            Controls.Add(btnnombre);
            Controls.Add(txtlogin);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtlogin;
        private Button btnnombre;
        private Button btnID;
        private Button btnusuario;
        private Button btncontraseña;
        private Button btnapellidos;
        private Label label1;
        private TextBox txtnombre;
        private TextBox txtapellidos;
        private TextBox txtid;
        private TextBox txtusuario;
        private TextBox txtcontraseña;
        private LinkLabel btnregistro;
        private Button btnacceder;
    }
}
