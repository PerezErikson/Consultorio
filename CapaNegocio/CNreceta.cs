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
    public class CNreceta
    {
        public static string Insertar(int pIdReceta, int pIdConsulta, int pIdMedicamento, string pObservaciones, string pTiempo)
        {
            CDreceta objReceta = new CDreceta();
            objReceta.IdReceta = pIdReceta;
            objReceta.IdConsulta = pIdConsulta;
            objReceta.IdMedicamento = pIdMedicamento;
            objReceta.Observaciones = pObservaciones;
            objReceta.Tiempo = pTiempo;
            

            return objReceta.Insertar(objReceta);

        }
        public static string Actualizar(int pIdReceta, int pIdConsulta, int pIdMedicamento, string pObservaciones, string pTiempo)
        {
            CDreceta objReceta = new CDreceta();
            objReceta.IdReceta = pIdReceta;
            objReceta.IdConsulta = pIdConsulta;
            objReceta.IdMedicamento = pIdMedicamento;
            objReceta.Observaciones = pObservaciones;
            objReceta.Tiempo = pTiempo;


            return objReceta.Actualizar(objReceta);
        }
        public DataTable ObtenerReceta(string miparametro)
        {
            CDreceta objReceta = new CDreceta();
            DataTable dt = new DataTable();

            dt = objReceta.RecetaConsultar(miparametro);
            return dt;
        }
    }
}

