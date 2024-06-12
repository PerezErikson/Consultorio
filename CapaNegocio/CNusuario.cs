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
    public class CNusuario
    {
        public static string Insertar(int pIdUsuario, string pNombre, string pApellido, string pNUsuario, string pContrasena)
        {
            CDusuario objUsuario = new CDusuario();
            objUsuario.IdUsuario = pIdUsuario;
            objUsuario.Nombre = pNombre;
            objUsuario.Apellido = pApellido;
            objUsuario.NUsuario = pNUsuario;
            objUsuario.Contrasena = pContrasena;



            return objUsuario.Insertar(objUsuario);

        }
        public static string Actualizar(int pIdUsuario, string pNombre, string pApellido, string pNUsuario, string pContrasena)
        {
            CDusuario objUsuario = new CDusuario();
            objUsuario.IdUsuario = pIdUsuario;
            objUsuario.Nombre = pNombre;
            objUsuario.Apellido = pApellido;
            objUsuario.NUsuario = pNUsuario;
            objUsuario.Contrasena = pContrasena;



            return objUsuario.Actualizar(objUsuario);



        }
        public DataTable ObtenerUsuario(string miparametro)
        {
            CDusuario objUsuario = new CDusuario();
            DataTable dt = new DataTable();

            dt = objUsuario.ConsultaUsuario(miparametro);
            return dt;
        }
    }
}
