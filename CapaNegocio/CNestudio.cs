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
    public class CNestudio
    {


        public static string Insertar(int pIdEstudio, string pNombre)
        {
            CDestudio objEstudio = new CDestudio();
            objEstudio.IdEstudio = pIdEstudio;
            objEstudio.Nombre = pNombre;
          


            return objEstudio.Insertar(objEstudio);

        }
        public static string Actualizar(int pIdEstudio, string pNombre)
        {
            CDestudio objEstudio = new CDestudio();
            objEstudio.IdEstudio = pIdEstudio;
            objEstudio.Nombre = pNombre;



            return objEstudio.Actualizar(objEstudio);


        }
        public DataTable ObtenerEstudio(string miparametro)
        {
            CDestudio objEstudio = new CDestudio();
            DataTable dt = new DataTable();

            dt = objEstudio.EstudioConsultar(miparametro);
            return dt;
        }
    }
}
