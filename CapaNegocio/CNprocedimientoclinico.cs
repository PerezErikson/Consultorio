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
    public class CNprocedimientoclinico
    {

        public static string Insertar(int pIdprocedimiento, int pidconsulta, int pidanalisis, int pcantidad)
        {
            CDprocedimientoclinico objProcedimientoclinico = new CDprocedimientoclinico();
            objProcedimientoclinico.IdProcedimiento = pIdprocedimiento;
            objProcedimientoclinico.IdConsulta = pidconsulta;
            objProcedimientoclinico.IdAnalisis = pidanalisis;
            objProcedimientoclinico.Cantidad = pcantidad;
          


            return objProcedimientoclinico.Insertar(objProcedimientoclinico);

        }
        public static string Actualizar(int pIdprocedimiento, int pidconsulta, int pidanalisis, int pcantidad)
        {
            CDprocedimientoclinico objProcedimientoclinico = new CDprocedimientoclinico();
            objProcedimientoclinico.IdProcedimiento = pIdprocedimiento;
            objProcedimientoclinico.IdConsulta = pidconsulta;
            objProcedimientoclinico.IdAnalisis = pidanalisis;
            objProcedimientoclinico.Cantidad = pcantidad;



            return objProcedimientoclinico.Actualizar(objProcedimientoclinico);
        }

            public DataTable ObtenerProcedimientoclinico(string miparametro)
        {
            CDprocedimientoclinico objProcedimientoclinico = new CDprocedimientoclinico();
            DataTable dt = new DataTable();

            dt = objProcedimientoclinico.ProcedimientoClinicoConsultar(miparametro);
            return dt;
        }
    }
}
