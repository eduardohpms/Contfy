using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contfy.BLL
{
    internal class CadastrBLL
    {
        public static void conectar()
        {
            DAL.UsuarioDAL.conectar();
        }
        public static void desconectar()
        {
            DAL.UsuarioDAL.desconectar();
        }
    }
}
