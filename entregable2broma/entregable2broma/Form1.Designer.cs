namespace entregable2broma
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
            txtpregunta = new TextBox();
            txtaceptar = new Button();
            txtcancelar = new Button();
            SuspendLayout();
            // 
            // txtpregunta
            // 
            txtpregunta.BackColor = SystemColors.Highlight;
            txtpregunta.Font = new Font("Bahnschrift", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpregunta.Location = new Point(192, 40);
            txtpregunta.Name = "txtpregunta";
            txtpregunta.Size = new Size(400, 40);
            txtpregunta.TabIndex = 0;
            txtpregunta.Text = "¿quieres formatear el sistema ?";
            // 
            // txtaceptar
            // 
            txtaceptar.BackColor = SystemColors.ActiveCaption;
            txtaceptar.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtaceptar.ForeColor = SystemColors.ActiveCaptionText;
            txtaceptar.Location = new Point(115, 283);
            txtaceptar.Name = "txtaceptar";
            txtaceptar.Size = new Size(200, 40);
            txtaceptar.TabIndex = 1;
            txtaceptar.Text = "Aceptar";
            txtaceptar.UseVisualStyleBackColor = false;
            txtaceptar.Click += txtaceptar_Click;
            // 
            // txtcancelar
            // 
            txtcancelar.BackColor = SystemColors.ActiveCaption;
            txtcancelar.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcancelar.Location = new Point(470, 283);
            txtcancelar.Name = "txtcancelar";
            txtcancelar.Size = new Size(200, 40);
            txtcancelar.TabIndex = 2;
            txtcancelar.Text = "Cancelar";
            txtcancelar.UseVisualStyleBackColor = false;
            txtcancelar.Click += txtcancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(txtcancelar);
            Controls.Add(txtaceptar);
            Controls.Add(txtpregunta);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtpregunta;
        private Button txtaceptar;
        private Button txtcancelar;
    }
}
