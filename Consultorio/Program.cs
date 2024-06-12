using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//para poder utilizar las instrucciones de SQL
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
//Para acceder a la capa de negocio
using CapaNegocio;


namespace Consultorio
{
    public static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
           

        }
        public static int vidPaciente = 0; //variables que tomarán el valor de la clave
                                          //primaria de la tabla correspondiente
        public static int vidMedicamento = 0; //colocar una por cada clave primaria que tengamos
        public static int vidUsuario = 0;                             //en nuestra base de datos
        public static int vidAnalisis = 0;
        public static int tbcodpaciente = 0;
        public static int vidConsulta = 0;
        public static bool nuevo = false; //variable usada para identificar si se trabaja con
                                          //un nuevo dato o no
        public static bool modificar = false; //variable usada para identificar si se está
                                              //modificando un dato o no
    }
}
