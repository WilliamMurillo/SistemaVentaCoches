using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
namespace Control
{
    public class clsControl
    {
        //Variables 
        clsModelo objModelo = null;
        clsVariables objVariables = null;

        public clsControl(clsVariables objVar)
        {
            objVariables = objVar; 
        }

        //metodos
        public void mtIngresarVehiculo()
        {
            try
            {
                objModelo = new clsModelo();

                objModelo.mtIngresarVehiculo(objVariables.tipoCoche, objVariables.marca, objVariables.linea,
                    objVariables.ciudad, objVariables.modelo, objVariables.placa, objVariables.kilometraje,
                    objVariables.motor, objVariables.accesorios, objVariables.precio, objVariables.imagenRura);
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public string mtLogin()
        {
            try
            {
                objModelo = new clsModelo();
                var confirmacion = string.Empty;

                confirmacion = objModelo.mtLogin(objVariables.usuario, objVariables.contraseña);

                return confirmacion;
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
       
    }
}
