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
        string[] vector = null;
        string[,] vectorr = null;
        //Venta Vehiculo
        string tipoCoche = "Automovíl";
        string marca = "Renault 4";
        string linea = "Clasica";
        string ciudad  = "Medellín";
        string modelo = "1991";
        string placa ="acb456";
        string kilometraje = "10000";
        string motor ="Viejo";
        string accesorios ="Aleta";
        string precio ="Gratis";
        string rutai = "C:\\Users\\User\\Downloads\\Coches\\Renault.jpg";

        public clsModelo()
        {

        }

        //metodos
        public void mtIngresarVehiculo(string coche, string marca,string linea,
            string ciudad, string modelo, string placa, string kilome, string mot, 
            string acce, string preci, string ruta)
        {
            try
            {
                tipoCoche = coche; this.marca = marca; this.linea = linea; this.ciudad = ciudad;
                this.modelo = modelo; this.placa = placa; kilometraje = kilome; motor = mot;
                accesorios = acce; precio = preci; rutai = ruta;

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

        //metodo para sacar la información completa para formulario resumen
        public string[] mtConsultarDatosResumen()
        {
            try
            {
                vector = new string[12];

                vector[0] = tipoCoche ;
                vector[1] = marca;
                vector[2] = linea;
                vector[3] = rutai;
                vector[4] = ciudad;
                vector[5] = modelo;
                vector[6] = placa;
                vector[7] = kilometraje;
                vector[8] = motor;
                vector[9] = accesorios;
                vector[10] = precio;

                return vector;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //metodo para sacar la información basico para formulario resumen
        public string[] mtConsularDatosBasicos()
        {
            try
            {
                vector = new string[6];

                vector[0] = precio;
                vector[1] = marca;
                vector[2] = rutai;
                vector[3] = ciudad;
                vector[4] = modelo;
                vector[5] = kilometraje;

                return vector;
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

     
    }
}
