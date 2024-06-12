using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class ModeloUsuario
    {
        Userdato userdato = new Userdato();
        public bool LoginUser(string user, string pass) 
        {
            return userdato.login(user, pass);

        }
    }
}
