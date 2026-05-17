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
        public static void validaDadosAdicionar(ContainerMdl ADDContainer, char op)
        {
            Erro.setErro(false);
            if (ADDContainer.getCodigo().Trim().Equals(""))
            {
                Erro.setMens("O código é de preenchimento obrigatório!");
                return;
            }

            if (ADDContainer.getCodigo().Trim().Length == 10)
            {
                Erro.setMens("O código deve conter 10 caracteres!");
                return;
            }

            // NOME
            if (ADDContainer.getNome().Trim().Equals(""))
            {
                Erro.setMens("O nome é de preenchimento obrigatório!");
                return;
            }

            // STATUS
            if (ADDContainer.getStatus().Trim().Equals(""))
            {
                Erro.setMens("O status é de preenchimento obrigatório!");
                return;
            }

            // LOCALIZAÇÃO
            if (ADDContainer.getLocalizacao().Trim().Equals(""))
            {
                Erro.setMens("A localização é de preenchimento obrigatório!");
                return;
            }
        }

        public static void validaDadosAlterar(ContainerMdl ALContainer, char op)
        {
            Erro.setErro(false);
            if (ALContainer.getCodigo().Trim().Equals(""))
            {
                Erro.setMens("O código é de preenchimento obrigatório!");
                return;
            }
        }

        public static void validaDadosDeletar(ContainerMdl DELContainer, char op)
        {
            Erro.setErro(false);
            if (DELContainer.getCodigo().Trim().Equals(""))
            {
                Erro.setMens("O código é de preenchimento obrigatório!");
                return;
            }
        }
    }
}
