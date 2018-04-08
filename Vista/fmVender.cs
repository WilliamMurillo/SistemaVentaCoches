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
    public partial class fmVender : Form
    {

        //Variables
        clsControl objControl = null;
        clsVariables objVariables = null;
        public fmVender()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccesorios_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        

        private void fmVender_Load(object sender, EventArgs e)
        {
            //TextBox configuracion
            cmbTipoCoche.Items.Add("Automovíl");
            cmbTipoCoche.Items.Add("Motocicleta");
            cmbTipoCoche.Text = "Automovíl";
            cmbTipoCoche.DropDownStyle = ComboBoxStyle.DropDownList;

            txtAccesorios.Multiline = true;
            txtAccesorios.ScrollBars = ScrollBars.Vertical;
        }

        //Metodo para llevar los datos ingresado a las variables globales
        private void mtLlevarDatos()
        {
            try
            {
                objVariables = new clsVariables();
                objControl = new clsControl(objVariables);

                objVariables.tipoCoche = cmbTipoCoche.SelectedItem.ToString();
                objVariables.marca = txtMarca.Text;
                objVariables.linea = txtLinea.Text;
                objVariables.ciudad = txtCiudad.Text;
                objVariables.modelo = txtModelo.Text;
                objVariables.placa = txtPlaca.Text.ToString();
                objVariables.kilometraje = txtKilometraje.Text.ToString();
                objVariables.motor = txtMotor.Text.ToString();
                objVariables.accesorios = txtAccesorios.Text;
                objVariables.precio = txtPrecio.Text.ToString();

                objControl.mtIngresarVehiculo();
            }
            catch (Exception e) {
                MessageBox.Show("Ocurrio un error: "+ e.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //metodo para garantizar el ingreso de solo numeros
        private void mtSoloNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        
        //mt para garantizar el ingreso de solo letras
        private void mtSoloLetras(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //mt para garantizar el ingreso de todos lo datos
        private bool mtGarantizarDatos()
        {
            bool com = false;
            if(txtAccesorios.Text != string.Empty && txtCiudad.Text != string.Empty
                && txtKilometraje.Text.ToString() != string.Empty && txtLinea.Text.ToString() != string.Empty
                && txtMarca.Text != string.Empty && txtModelo.Text.ToString() != string.Empty 
                && txtMotor.Text.ToString() != string.Empty && txtPlaca.Text.ToString() != string.Empty 
                && txtPrecio.Text.ToString() != string.Empty)
            {
                com = true;
            }
            return com;
        }

        //Eventos
        private void txtLinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            mtSoloLetras(e);
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            mtSoloLetras(e);
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            mtSoloLetras(e);
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            mtSoloNumeros(e);
        }

        private void txtKilometraje_KeyPress(object sender, KeyPressEventArgs e)
        {
            mtSoloNumeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            mtSoloNumeros(e);
        }

        private void txtAccesorios_KeyPress(object sender, KeyPressEventArgs e)
        {
            mtSoloLetras(e);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (mtGarantizarDatos())
            {
                

                MessageBox.Show("Vehículo publicado", "Comprobación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Ingrese todos los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }



    }
}
