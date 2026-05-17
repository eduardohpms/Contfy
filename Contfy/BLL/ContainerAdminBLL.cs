using Contfy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contfy.BLL
{
    internal class ContainerAdminBLL
    {
        public static void validaDadosAdicionar(UsuarioMdl umUsuario)
        {
            Erro.setErro(false);
            if (string.IsNullOrWhiteSpace(umUsuario.getUsuario()))
            {
                Erro.setMens("O usuário é obrigatório!");
                return;
            }

            if (string.IsNullOrWhiteSpace(umUsuario.getSenha()))
            {
                Erro.setMens("A senha é obrigatória!");
                return;
            }
        }
    }
}
