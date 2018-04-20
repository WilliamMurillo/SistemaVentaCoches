using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        string nombre = "Stiveen Restrepo";
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
        string rutai = "C:/Users/STIVENR/Downloads/Coches/Renault.jpg";

        //Variables para conexión
        SqlConnection cnBaseDatos = null;
        SqlCommand cmdBaseDatos = null;
        string strConexion = string.Empty;
        SqlDataReader drBaseDatos = null;
        DataTable dttBaseDatos = null;

        public clsModelo()
        {
            strConexion =" Data Source = STIVEN\\SQLEXPRESS; Initial Catalog = dbSistemaVentaCoches; Integrated Security = True";
        }

    

        //Metodo para confirmar los datos del login
        public string mtLogin(string user, string contra)
        {
            try
            {
                // conexión base de datos y preparación de consulta
                cnBaseDatos = new SqlConnection(strConexion);
                dttBaseDatos = new DataTable();
                cmdBaseDatos = new SqlCommand();
                cmdBaseDatos.Connection = cnBaseDatos;
                cmdBaseDatos.CommandType = CommandType.StoredProcedure;
                cmdBaseDatos.CommandText = "spLog";

               
                // ejecutar la consulta y almacenar datos
                cnBaseDatos.Open();
                drBaseDatos = cmdBaseDatos.ExecuteReader();
                dttBaseDatos.Load(drBaseDatos);

                string confirmacion = string.Empty;
                 if(user == dttBaseDatos.Rows[0]["strUser"].ToString() && contra == dttBaseDatos.Rows[0]["strCon"].ToString())
                {
                    confirmacion = "True";
                }

                return confirmacion; 
            
                /*  var confirmacion = string.Empty;
                  if (user == usuario && contra == contraseña)
                  {
                      confirmacion = nombre;
                  }*/

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
            }
        }

        //metodo para sacar la información completa para formulario resumen
        public string[] mtConsultarDatosResumen()
        {
            try
            {
                //Organizar
                //// conexión base de datos y preparación de consulta
                //cnBaseDatos = new SqlConnection(strConexion);
                //dttBaseDatos = new DataTable();
                //cmdBaseDatos = new SqlCommand();
                //cmdBaseDatos.Connection = cnBaseDatos;
                //cmdBaseDatos.CommandType = CommandType.StoredProcedure;
                //cmdBaseDatos.CommandText = "spLogin";


                //// ejecutar la consulta y almacenar datos
                //cnBaseDatos.Open();
                //drBaseDatos = cmdBaseDatos.ExecuteReader();
                //dttBaseDatos.Load(drBaseDatos);

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
            finally
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
            }
        }

        //metodo para sacar la información basico para formulario resumen
        public string[,] mtConsularDatosBasicos()
        {
            try
            {
                // conexión base de datos y preparación de consulta
                cnBaseDatos = new SqlConnection(strConexion);
                dttBaseDatos = new DataTable();
                cmdBaseDatos = new SqlCommand();
                cmdBaseDatos.Connection = cnBaseDatos;
                cmdBaseDatos.CommandType = CommandType.StoredProcedure;
                cmdBaseDatos.CommandText = "spConsultarDatosBasicos";


                // ejecutar la consulta y almacenar datos  voy a guardar el codigoooo
                cnBaseDatos.Open();
                drBaseDatos = cmdBaseDatos.ExecuteReader();
                dttBaseDatos.Load(drBaseDatos);

                
                vectorr = new string[6,6];
                //Sacar los datos del datagrid por cada vehículo y almacenarlos en una matriz
                //Cada filo guarda los datos de cada vehículo
                for(int i = 0; i<= 5; i++)
                {
                    int j = 0;  
                        vectorr[i, j] = dttBaseDatos.Rows[i]["strPrecio"].ToString();
                    j++;
                        vectorr[i, j] = dttBaseDatos.Rows[i]["strMarca"].ToString();
                    j++;
                    vectorr[i, j] = dttBaseDatos.Rows[i]["strRuta"].ToString();
                    j++;
                    vectorr[i, j] = dttBaseDatos.Rows[i]["strCiudad"].ToString();
                    j++;
                    vectorr[i, j] = dttBaseDatos.Rows[i]["strModelo"].ToString();
                    j++;
                    vectorr[i, j] = dttBaseDatos.Rows[i]["strKilometraje"].ToString();
                    
                }                

                return vectorr;
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //mt para guardar vehículos vendidos
        public void mtGuardar(string tipo, string marca, string linea, string ciudad, string modelo,
            string placa, string kilom, string motor, string acce, string precio, string ruta)
        {
            try
            {
                cnBaseDatos = new SqlConnection(strConexion);
                dttBaseDatos = new DataTable();
                cmdBaseDatos = new SqlCommand();
                cmdBaseDatos.Connection = cnBaseDatos;
                cmdBaseDatos.CommandType = CommandType.StoredProcedure;
                cmdBaseDatos.CommandText = "spGuardarVenta";
                cmdBaseDatos.Parameters.Add("@tipo", SqlDbType.VarChar,50).Value = tipo ;
                cmdBaseDatos.Parameters.Add("@marca", SqlDbType.VarChar, 50).Value = marca ;
                cmdBaseDatos.Parameters.Add("@linea", SqlDbType.VarChar, 50).Value = linea ;
                cmdBaseDatos.Parameters.Add("@ciudad", SqlDbType.VarChar, 50).Value = ciudad;
                cmdBaseDatos.Parameters.Add("@modelo", SqlDbType.VarChar, 50).Value = modelo ;
                cmdBaseDatos.Parameters.Add("@placa", SqlDbType.VarChar, 100).Value = placa ;
                cmdBaseDatos.Parameters.Add("@kilom", SqlDbType.VarChar, 100).Value = kilom;
                cmdBaseDatos.Parameters.Add("@motor", SqlDbType.VarChar, 100).Value = motor;
                cmdBaseDatos.Parameters.Add("@acce", SqlDbType.VarChar, 100).Value = acce;
                cmdBaseDatos.Parameters.Add("@precio", SqlDbType.VarChar, 100).Value = precio;
                cmdBaseDatos.Parameters.Add("@ruta", SqlDbType.VarChar, 100).Value = ruta;

                cnBaseDatos.Open();
                cmdBaseDatos.ExecuteReader();

            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
            }
        }
    }
}
