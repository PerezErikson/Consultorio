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
    public class CNconsulta
    {
        public static string Insertar(int pidconsulta, int  pidpaciente, string pMotivo, string pEnfermendades, string pSintomas, string pAntecendentes, string pFecha, string pDiagnotico)
        {
            CDconsulta objConsulta = new CDconsulta();
            objConsulta.IdConsulta = pidconsulta;
            objConsulta.IdPaciente = pidpaciente;
            objConsulta.Motivo = pMotivo ;
            objConsulta.Enfermedades = pEnfermendades;
            objConsulta.Sintomas = pSintomas;
            objConsulta.Antecedentes= pAntecendentes;
            objConsulta.Fecha = pFecha;
            objConsulta.Diagnostico= pDiagnotico;

            return objConsulta.Insertar(objConsulta); ;

        }
        public static string Actualizar (int pidConsulta, int pidPaciente, string pMotivo, string pEnfermendades, string pSintomas, string pAntecendentes, string pFecha, string pDiagnotico)
        {
            CDconsulta objConsulta = new CDconsulta();
            objConsulta.IdConsulta = pidConsulta;
            objConsulta.IdPaciente = pidPaciente;
            objConsulta.Motivo = pMotivo;
            objConsulta.Enfermedades = pEnfermendades;
            objConsulta.Sintomas = pSintomas;
            objConsulta.Antecedentes = pAntecendentes;
            objConsulta.Fecha = pFecha;
            objConsulta.Diagnostico = pDiagnotico;

            return objConsulta.Actualizar(objConsulta); ;

        }
        public DataTable ObtenerConsulta(string miparametro)
        {
            CDconsulta objConsulta = new CDconsulta();
            DataTable dt = new DataTable();

            dt = objConsulta.ConsultaConsultar(miparametro);
            return dt;
        }

       
    }
}
