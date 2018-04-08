using System;using System.Windows.Forms;

namespace Vista
{
    public partial class fmResumen : Form
    {
        public fmResumen()
        {
            InitializeComponent();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            fmVender fm = new fmVender();
            fm.Show();
            this.Hide();
        }
    }
}
