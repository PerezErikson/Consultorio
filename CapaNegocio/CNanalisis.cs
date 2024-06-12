using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

using CapaDatos;

namespace CapaNegocio
{
    public class CNanalisis
    {


        public static string Insertar(int pIdAnalisis, string pNombre, string pDescripcion)
        {
            CDanalisis objAnalisis = new CDanalisis();
            objAnalisis.IdAnalisis = pIdAnalisis;
            objAnalisis.Nombre = pNombre;
            objAnalisis.Descripcion = pDescripcion;
           

            return objAnalisis.Insertar(objAnalisis);

        }
        public static string Actualizar(int pIdAnalisis, string pNombre, string pDescripcion)
        {
            CDanalisis objAnalisis = new CDanalisis();
            objAnalisis.IdAnalisis = pIdAnalisis;
            objAnalisis.Nombre = pNombre;
            objAnalisis.Descripcion = pDescripcion;


            return objAnalisis.Actualizar(objAnalisis);


        }
        public DataTable ObtenerAnalisis(string miparametro)
        {
            CDanalisis objAnalisis = new CDanalisis();
            DataTable dt = new DataTable();

            dt = objAnalisis.AnalisisConsultar(miparametro);
            return dt;
        }
    }
}

