namespace login1
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
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt0 = new Label();
            txt3 = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.BackColor = Color.White;
            txt1.ForeColor = Color.DarkGray;
            txt1.Location = new Point(171, 83);
            txt1.Name = "txt1";
            txt1.Size = new Size(400, 27);
            txt1.TabIndex = 1;
            txt1.Text = "USUARIO ";
            txt1.Enter += txt1_Enter;
            txt1.Leave += txt1_Leave;
            // 
            // txt2
            // 
            txt2.BackColor = Color.White;
            txt2.ForeColor = Color.LightGray;
            txt2.Location = new Point(171, 140);
            txt2.Name = "txt2";
            txt2.Size = new Size(400, 27);
            txt2.TabIndex = 2;
            txt2.Text = "CONTRASEÑA";
            txt2.Enter += txt2_Enter;
            txt2.Leave += txt2_Leave;
            // 
            // txt0
            // 
            txt0.AutoSize = true;
            txt0.Location = new Point(325, 26);
            txt0.Name = "txt0";
            txt0.Size = new Size(51, 20);
            txt0.TabIndex = 2;
            txt0.Text = "LOGIN";
            // 
            // txt3
            // 
            txt3.BackColor = Color.DarkGray;
            txt3.Location = new Point(171, 202);
            txt3.Name = "txt3";
            txt3.Size = new Size(400, 29);
            txt3.TabIndex = 3;
            txt3.Text = "ACCEDER";
            txt3.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(275, 251);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(198, 20);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿se olvido de su contraseña?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.para_proyecto;
            pictureBox1.Location = new Point(12, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 148);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(txt3);
            Controls.Add(txt0);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1;
        private TextBox txt2;
        private Label txt0;
        private Button txt3;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}
