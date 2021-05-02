using PBL3.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
            startMain1.BringToFront();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            startMain1.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
// hello hi My name cho'
        }
    }
}
