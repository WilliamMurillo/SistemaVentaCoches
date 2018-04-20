using System;
using System.Windows.Forms;
using Control;
using System.Drawing;

namespace Vista
{
    public partial class fmResumen : Form
    {

        clsControl objControl = null;
        clsVariables objVariables = null;
        string[,] vectorr= null;
       
        System.Windows.Forms.Control[,] vectorObj = new System.Windows.Forms.Control[6,6];
        
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

        private void fmResumen_Load(object sender, EventArgs e)
        {
            
            //Metodo para organizar los controles dentro de una matriz
            //y así ahorra muchisimo código
            mtOrganizarControles();

            //metodo para cargar los datos en los paneles
             mtEstablecerPredeterminado();

           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //Metodo para organizar los controles dentro de una matriz
        //y así ahorra muchisimo código
        private void mtOrganizarControles()
        {

            /*matriz para contener los controles de cada panel
               |precio1,marca ,rutaImagen ,Ciudad ,fecha , kilometraje|
               |precio2,marca2,rutaImagen2,Ciudad2,fecha2, kilometraje2|
               | ..        ..      ..        ...       ...    n        |*/
            vectorObj = new System.Windows.Forms.Control[6, 6];

            //Controles panel 1
            vectorObj[0, 0] = pbFoto1; vectorObj[0, 1] = lblPrecio; vectorObj[0, 2] = lblFecha; vectorObj[0, 3] = lblKilometraje;
            vectorObj[0, 4] = lblMarca; vectorObj[0, 5] = lblCiudad;
            //Controles panel 2
            vectorObj[1, 0] = pbFoto2; vectorObj[1, 1] = lblPrecio2; vectorObj[1, 2] = lblFecha2; vectorObj[1, 3] = lblKilometraje2;
            vectorObj[1, 4] = lblMarca2; vectorObj[1, 5] = lblCiudad2;
            //Controles panel 3
            vectorObj[2, 0] = pbFoto3; vectorObj[2, 1] = lblPrecio3; vectorObj[2, 2] = lblFecha3; vectorObj[2, 3] = lblKilometraje3;
            vectorObj[2, 4] = lblMarca3; vectorObj[2, 5] = lblCiudad3;
            //Controles panel 4
            vectorObj[3, 0] = pbFoto4; vectorObj[3, 1] = lblPrecio4; vectorObj[3, 2] = lblFecha4; vectorObj[3, 3] = lblKilometraje4;
            vectorObj[3, 4] = lblMarca4; vectorObj[3, 5] = lblCiudad4;
            //Controlespanel 5
            vectorObj[4, 0] = pbFoto5; vectorObj[4, 1] = lblPrecio5; vectorObj[4, 2] = lblFecha5; vectorObj[4, 3] = lblKilometraje5;
            vectorObj[4, 4] = lblMarca5; vectorObj[4, 5] = lblCiudad5;
            //Controles panel 6 
            vectorObj[5, 0] = pbFoto6; vectorObj[5, 1] = lblPrecio6; vectorObj[5, 2] = lblFecha6; vectorObj[5, 3] = lblKilometraje6;
            vectorObj[5, 4] = lblMarca6; vectorObj[5, 5] = lblCiudad6;


        }

        //metodo para establecer los valores predeterminados a cada panel
        private void mtEstablecerPredeterminado()
        {
            try
            {

                objControl = new clsControl();
                vectorr = new string[6, 6];
                vectorr = objControl.mtConsultarDatosBasicos();
                
                
                    for (int j = 0; j <= 5; j++)
                    {
                    //cargar datos de los coches
                    //  vectorObj[j, 0].Text = vector[4];
                    vectorObj[j, 0].BackgroundImage = Image.FromFile(vectorr[j,2]); 
                         vectorObj[j, 1].Text = vectorr[j,0];
                         vectorObj[j,2].Text= vectorr[j,4];
                         vectorObj[j,3].Text = vectorr[j,5] + " KM";
                         vectorObj[j,4].Text = vectorr[j,1];
                         vectorObj[j, 5].Text = vectorr[j,3];
                         }
                                         

            }catch(Exception e)
            {
                MessageBox.Show("Ocurrio un error fatal", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
