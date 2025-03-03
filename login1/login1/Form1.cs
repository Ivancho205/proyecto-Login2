namespace login1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt1_Enter(object sender, EventArgs e)
        {
            if (txt1.Text == "USUARIO")
            {
                txt1.Text = "";
                txt1.ForeColor = Color.DarkGray;
            }
        }

        private void txt1_Leave(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                txt1.Text = "USUARIO";
                txt1.ForeColor = Color.DarkGray;
            }
        }

        private void txt2_Enter(object sender, EventArgs e)
        {
            if (txt2.Text == " CONTRASEÑA")
            {
                txt2.Text = "";
                txt2.ForeColor = Color.DarkGray;
                txt2.UseSystemPasswordChar = true;
            }
        }

        private void txt2_Leave(object sender, EventArgs e)
        {
            if( txt2.Text == "")
            {
                txt2.Text = "CONTRASEÑA";
                txt2.ForeColor = Color.DarkGray;
                txt2.UseSystemPasswordChar = false;
            }
        }
    }
}
