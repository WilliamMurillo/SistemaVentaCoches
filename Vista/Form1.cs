using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace Vista
{
    public partial class Form1 : Form
    {

        clsControl objControl = null;
        clsVariables objVariables = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void mtLogin()
        {
            try
            {
                objVariables = new clsVariables();
                objControl = new clsControl(objVariables);

                objVariables.usuario = txtUser.Text.ToString();
                objVariables.contraseña = txtCon.Text.ToString();
                txtUser.Text = string.Empty;
                txtCon.Text = string.Empty;

                var nom = string.Empty;
                nom = objControl.mtLogin();

                if (nom != string.Empty)
                {
                    fmResumen fm = new fmResumen();
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ingrese un usuario y contraseña correctose","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error" + ex.Message,"Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            mtLogin();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
