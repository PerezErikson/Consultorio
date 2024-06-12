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
    public class CNpaciente
    {
        public static string Insertar(int pidPaciente, string pNombre, string pApellido, string pTipoDocumento, string pNoDocumento, string pSexo, string pTipoSangre, string pFechaNacimiento, string pTelefono)
        {
            CDpaciente objPaciente = new CDpaciente();
            objPaciente.IdPaciente = pidPaciente;
            objPaciente.Nombre = pNombre;
            objPaciente.Apellido = pApellido;
            objPaciente.TipoDocumento = pTipoDocumento;
            objPaciente.NoDocumento = pNoDocumento;
            objPaciente.Sexo = pSexo;
            objPaciente.TipoSangre = pTipoSangre;
            objPaciente.FechaNacimiento = pFechaNacimiento;
            objPaciente.FechaNacimiento = pFechaNacimiento;
            objPaciente.Telefono = pTelefono;

            return objPaciente.Insertar(objPaciente);

        }
        public static string Actualizar(int pidPaciente, string pNombre, string pApellido, string pTipoDocumento, string pNoDocumento, string pSexo, string pTipoSangre, string pFechaNacimiento, string pTelefono)
        {
            CDpaciente objPaciente = new CDpaciente();
            objPaciente.IdPaciente = pidPaciente;
            objPaciente.Nombre = pNombre;
            objPaciente.Apellido = pApellido;
            objPaciente.TipoDocumento = pTipoDocumento;
            objPaciente.NoDocumento = pNoDocumento;
            objPaciente.Sexo = pSexo;
            objPaciente.TipoSangre = pTipoSangre;
            objPaciente.FechaNacimiento = pFechaNacimiento;
            objPaciente.FechaNacimiento = pFechaNacimiento;
            objPaciente.Telefono = pTelefono;

            return objPaciente.Actualizar(objPaciente);

        }
        public DataTable ObtenerPaciente(string miparametro)
        {
            CDpaciente objPaciente = new CDpaciente();
            DataTable dt = new DataTable();

            dt = objPaciente.PacienteConsultar(miparametro);
            return dt;
        }


    }
}
