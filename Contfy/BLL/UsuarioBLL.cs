using Contfy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Contfy.BLL
{
    
    internal class UsuarioBLL
    {
        public static void conectar()
        {
            DAL.UsuarioDAL.conectar();
        }
        public static void desconectar()
        {
            DAL.UsuarioDAL.desconectar();
        }

        public static void validaDados(UsuarioMdl umUsuario, char op)
        {
            Erro.setErro(false);
            if (umUsuario.getUsuario().Equals(""))
            {
                Erro.setMens("O usuário é obrigatório!");
                return;
            }

            if (umUsuario.getSenha().Equals(""))
            {
                Erro.setMens("A senha é obrigatória!");
                return;
            }
        }

    }
}
