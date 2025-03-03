namespace loginentregable2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {
            txtlogin.Text = "LOGIN";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            // Validación básica para asegurarse de que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtid.Text) ||
                string.IsNullOrWhiteSpace(txtnombre.Text) ||
                string.IsNullOrWhiteSpace(txtapellidos.Text) ||
                string.IsNullOrWhiteSpace(txtusuario.Text) ||
                string.IsNullOrWhiteSpace(txtcontraseña.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("¡Acceso concedido!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // Permitir solo letras, espacios y la tecla de retroceso
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la entrada no permitida
            }
        }

        private void txtapellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacios y la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido del Enter
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtapellidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido del Enter
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido del Enter
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido del Enter
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtcontraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido del Enter
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnnombre_Click(object sender, EventArgs e)
        {
            btnnombre.Text = "Nombre";
        }

        private void btnapellidos_Click(object sender, EventArgs e)
        {
            btnapellidos.Text = "Apellidos";
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            btnID.Text = "ID";
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            btnusuario.Text = "Usuario";
        }

        private void btncontraseña_Click(object sender, EventArgs e)
        {
            btncontraseña.Text = "Contraseña";
        }
    }
}
