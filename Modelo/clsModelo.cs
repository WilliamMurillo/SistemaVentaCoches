using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class clsModelo
    {
        //variables 

            //Login
        string usuario = "admin";
        string contraseña = "1234";
        string nombre = "Arnold McGregor";

        //Venta Vehiculo
        string tipoCoche = string.Empty;
        string marca = string.Empty;
        string linea = string.Empty;
        string imagenRua = string.Empty;
        string ciudad  =string.Empty;
        string modelo =string.Empty;
        string placa =string.Empty;
        string kilometraje =string.Empty;
        string motor =string.Empty;
        string accesorios =string.Empty;
        string precio =string.Empty;

        public clsModelo()
        {

        }

        //metodos
        public void mtIngresarVehiculo(string coche, string marca,string linea,
            string ciudad, string modelo, string placa, string kilome, string mot, 
            string acce, string preci)
        {
            try
            {
                tipoCoche = coche; this.marca = marca; this.linea = linea; this.ciudad = ciudad;
                this.modelo = modelo; this.placa = placa; kilometraje = kilome; motor = mot;
                accesorios = acce; precio = preci;

            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Metodo para confirmar los datos del login
        public string mtLogin(string user, string contra)
        {
            try
            {
                var confirmacion = string.Empty;
                if (user == usuario && contra == contraseña)
                {
                    confirmacion = nombre;
                }
                return confirmacion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
