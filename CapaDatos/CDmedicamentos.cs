using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace CapaDatos
{
    public class CDmedicamentos
    {
        private int dIdMedicamentos;
        private string dNombre, dComponentes, dLaboratorio, dDosis, dContraindicaciones;



        public CDmedicamentos()
        { }

        public CDmedicamentos(int pIdMedicamentos, string pNombre, string pComponentes, string
pLaboratorio, string pDosis, string pContraindicaciones)
        {
            dIdMedicamentos = pIdMedicamentos;
            dNombre = pNombre;
            dComponentes = pComponentes;
            dLaboratorio = pLaboratorio;
            dDosis = pDosis;
            dContraindicaciones = pContraindicaciones;
            
        }

        public int IdMedicamentos
        {
            get { return dIdMedicamentos; }
            set { dIdMedicamentos= value; }
        }
     
        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }
        public string Componentes
        {
            get { return dComponentes; }
            set { dComponentes= value; }
        }
        public string Laboratorio
        {
            get { return dLaboratorio; }
            set { dLaboratorio = value; }
        }
        public string Dosis
        {
            get { return dDosis; }
            set { dDosis = value; }
        }
        public string Contraindicaciones
        {
            get { return dContraindicaciones; }
            set { dContraindicaciones = value; }
        }
       

        
        public string Insertar(CDmedicamentos objMedicamentos)
        {
            string mensaje = "";
            //creamos un nuevo objeto de tipo SqlConnection
            SqlConnection sqlCon = new SqlConnection();
            //trataremos de hacer algunas operaciones con la tabla
            try
            {
                
                sqlCon.ConnectionString = Conexionconsultorio.miconexion;
                
                SqlCommand micomando = new SqlCommand("Insertar_medicamento", sqlCon);
                sqlCon.Open(); //Abro la conexión
                               //indico que se ejecutara un procedimiento almacenado
                micomando.CommandType = CommandType.StoredProcedure;

                
               
                micomando.Parameters.AddWithValue("@pnombre", objMedicamentos.Nombre);
                micomando.Parameters.AddWithValue("@pcomponentes", objMedicamentos.Componentes);
                micomando.Parameters.AddWithValue("@plaboratorio", objMedicamentos.Laboratorio);
                micomando.Parameters.AddWithValue("@pdosis", objMedicamentos.Dosis);
                micomando.Parameters.AddWithValue("@pcontraindicaciones", objMedicamentos.Contraindicaciones);
                


                //hasta aquí el pase de parámetros
                /*Ejecuto la instrucción. Si se devuelve el valor 1 significa que todo funcionó correctamente de lo
 * contrario se devuelve el mensaje indicando que fue incorrecto.
*/
                mensaje = micomando.ExecuteNonQuery() == 1 ? "Inserción de datos completada correctamente!" :
                "No se pudo insertar correctamente los nuevos datos!";
            }
            catch (Exception ex) //Si ocurre algún error se captura y se muestra el mensaje
            {
                mensaje = ex.Message;
            }
            finally//Luego de realizar el proceso de forma correcta o no
            {
                //Cierro la conexión si está abierta
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            //Devuelvo el mensaje correspondiente de acuerdo a lo que haya resultado del comando
            return mensaje;

        }

        //método para actualizar los datos del Suplidor. Recibirá el objeto objSuplidor como parámetro
        public string Actualizar(CDmedicamentos objMedicamentos)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexionconsultorio.miconexion;
                SqlCommand micomando = new SqlCommand("MedicamentosActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pidmedicamento", objMedicamentos.IdMedicamentos);
                micomando.Parameters.AddWithValue("@pnombre", objMedicamentos.Nombre);
                micomando.Parameters.AddWithValue("@pcomponentes", objMedicamentos.Componentes);
                micomando.Parameters.AddWithValue("@plaboratorio", objMedicamentos.Laboratorio);
                micomando.Parameters.AddWithValue("@pdosis", objMedicamentos.Dosis);
                micomando.Parameters.AddWithValue("@pcontraindicaciones", objMedicamentos.Contraindicaciones);
                mensaje = micomando.ExecuteNonQuery() == 1 ? "Datos actualizados correctamente!" :
                 "No se pudo actualizar correctamente los datos!";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return mensaje;
        }
        //Método para consultar datos filtrados de la tabla. Se recibe el valor del parámetro
        public DataTable MedicamentosConsultar(String miparametro)
        {
            DataTable dt = new DataTable(); //Se Crea DataTable que tomará los datos de los Suplidores
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Establecer el comando
                sqlCmd.Connection = new Conexionconsultorio().dbconexion; //Conexión que va a usar el comando
                sqlCmd.Connection.Open(); //Se abre la conexión
                sqlCmd.CommandText = "MedicamentosConsultar"; 
                sqlCmd.CommandType = CommandType.StoredProcedure; 
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro); 
                leerDatos = sqlCmd.ExecuteReader(); 
                dt.Load(leerDatos); 
                sqlCmd.Connection.Close(); 
            }
            catch (Exception ex)
            {
                dt = null; 
            }
            return dt; ////Se retorna el DataTable segun lo ocurrido arriba
        } //Fin d
    }
}
