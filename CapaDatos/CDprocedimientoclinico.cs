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
    public class CDprocedimientoclinico
    {
        private int dIdprocedimiento,didconsulta,didanalisis,dcantidad;
        
        public CDprocedimientoclinico()
        { }

        public CDprocedimientoclinico(int pIdprocedimiento, int pidconsulta, int pidanalisis, int pcantidad)
        {
            dIdprocedimiento = pIdprocedimiento;
            didconsulta = pidconsulta;
            didanalisis = pidanalisis;
            dcantidad = pcantidad;


        }

        public int IdProcedimiento
        {
            get { return dIdprocedimiento; }
            set { dIdprocedimiento = value; }
        }

        public int IdConsulta
        {
            get { return didconsulta; }
            set { didconsulta = value; }
        }
        public int IdAnalisis
        {
            get { return didanalisis; }
            set { didanalisis = value; }
        }
        public int Cantidad
        {
            get { return dcantidad; }
            set { dcantidad = value; }
        }
        //método para insertar un nuevo Suplidor. Recibirá el objeto objSuplidor como parámetro
        public string Insertar(CDprocedimientoclinico objProcedimientoclinico)
        {
            string mensaje = "";
            //creamos un nuevo objeto de tipo SqlConnection
            SqlConnection sqlCon = new SqlConnection();
            //trataremos de hacer algunas operaciones con la tabla
            try
            {
                //asignamos a sqlCon la conexión con las base de datos a traves de la clase que creamos
                sqlCon.ConnectionString = Conexionconsultorio.miconexion;
                //Escribo el nombre del procedimiento almacenado que utilizaré, en este caso SuplidorInsertar
                SqlCommand micomando = new SqlCommand("Insertar_ProcedimientoClinico", sqlCon);
                sqlCon.Open(); //Abro la conexión
                               //indico que se ejecutara un procedimiento almacenado
                micomando.CommandType = CommandType.StoredProcedure;

                /*Envío los parámetros al procedimiento almacenado.
                - Los nombres que aparece con el signo @ delante son los parámetros que hemos
                creado en el procedimiento almacenado de la base de datos y debemos escribirlos tal cual
               aparecen en dicho procedimiento almacenado (respetar mayúsculas y mnúsculas).
                - Los nombres que aparecen al lado son las propiedades del objeto objSuplidor que se pasará
                como parámetro con los valores deseados. Puede usarse como lo declaramos en la clase
               (usando el prefijo ( d ), por ejemplo: dSuplidor, o bien , hacerlo como se declaran en los métodos Get y
               Set.
                */

                micomando.Parameters.AddWithValue("@pidconsulta", objProcedimientoclinico.IdConsulta);
                micomando.Parameters.AddWithValue("@pidanalisis", objProcedimientoclinico.IdAnalisis);
                micomando.Parameters.AddWithValue("@pcantidad", objProcedimientoclinico.Cantidad);




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
        public string Actualizar(CDprocedimientoclinico objProcedimientoclinico)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexionconsultorio.miconexion;
                SqlCommand micomando = new SqlCommand("ProcedimientoActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pidprocedimiento", objProcedimientoclinico.IdProcedimiento);
                micomando.Parameters.AddWithValue("@pidconsulta", objProcedimientoclinico.IdConsulta);
                micomando.Parameters.AddWithValue("@pidanalisis", objProcedimientoclinico.IdAnalisis);
                micomando.Parameters.AddWithValue("@pcantidad", objProcedimientoclinico.Cantidad);




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
        public DataTable ProcedimientoClinicoConsultar(String miparametro)
        {
            DataTable dt = new DataTable(); //Se Crea DataTable que tomará los datos de los Suplidores
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Establecer el comando
                sqlCmd.Connection = new Conexionconsultorio().dbconexion; //Conexión que va a usar el comando
                sqlCmd.Connection.Open(); //Se abre la conexión
                sqlCmd.CommandText = "ProcedimientoClinicoConsultar"; //Nombre del Proc. Almacenado a usar
                sqlCmd.CommandType = CommandType.StoredProcedure; //Se trata de un proc. almacenado
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro); //Se pasa el valor a buscar
                leerDatos = sqlCmd.ExecuteReader(); //Llenamos el SqlDataReader con los datos resultantes
                dt.Load(leerDatos); //Se cargan los registros devueltos al DataTable
                sqlCmd.Connection.Close(); //Se cierra la conexión
            }
            catch (Exception ex)
            {
                dt = null; //Si ocurre algun error se anula el DataTable
            }
            return dt; ////Se retorna el DataTable segun lo ocurrido arriba
        } //Fin del método Mos
    }
}
