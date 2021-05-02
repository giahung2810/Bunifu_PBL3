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
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            //AddOwnedForm(f);
            this.Hide();
            f.Show();
        }
    }
}
