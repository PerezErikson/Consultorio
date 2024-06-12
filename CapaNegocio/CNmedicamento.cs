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
    public class CNmedicamento
    {
        public static string Insertar(int pIdmedicamento, string pNombre, string pComponentes, string pLaboratorio, string pDosis, string pContraindicaciones)
        {
            CDmedicamentos objMedicamentos = new CDmedicamentos();
            objMedicamentos.IdMedicamentos = pIdmedicamento;
            objMedicamentos.Nombre = pNombre;
            objMedicamentos.Componentes = pComponentes;
            objMedicamentos.Laboratorio = pLaboratorio;
            objMedicamentos.Dosis = pDosis;
            objMedicamentos.Contraindicaciones = pContraindicaciones;


            return objMedicamentos.Insertar(objMedicamentos);

        }
        public static string Actualizar(int pIdmedicamento, string pNombre, string pComponentes, string pLaboratorio, string pDosis, string pContraindicaciones)
        {
            CDmedicamentos objMedicamentos = new CDmedicamentos();
            objMedicamentos.IdMedicamentos = pIdmedicamento;
            objMedicamentos.Nombre = pNombre;
            objMedicamentos.Componentes = pComponentes;
            objMedicamentos.Laboratorio = pLaboratorio;
            objMedicamentos.Dosis = pDosis;
            objMedicamentos.Contraindicaciones = pContraindicaciones;

            return objMedicamentos.Actualizar(objMedicamentos); ;

        }
        public DataTable ObtenerMedicamento(string miparametro)
        {
            CDmedicamentos objMedicamentos = new CDmedicamentos();
            DataTable dt = new DataTable();

            dt = objMedicamentos.MedicamentosConsultar(miparametro);
            return dt;
        }
    }
}


