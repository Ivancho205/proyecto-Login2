using System;
using System.Drawing;
using System.Windows.Forms;

namespace entregable2broma
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1() { 
      

        
            InitializeComponent();

        }
        
        private void txtaceptar_Click(object sender, EventArgs e)
        {

        }

        private void txtcancelar_Click(object sender, EventArgs e)
        {
            int maxX = this.ClientSize.Width - txtcancelar.Width;
            int maxY = this.ClientSize.Height - txtcancelar.Height;

            
            txtcancelar.Location = new Point(random.Next(0, maxX), random.Next(0, maxY));
        }
    }
}
