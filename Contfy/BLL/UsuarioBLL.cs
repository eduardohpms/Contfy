using Contfy.BLL.Utils;
using Contfy.DAL;
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

        public static void validaDadosLogin(UsuarioMdl umUsuario)
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

        public static void ValidaDadosCadastro(UsuarioMdl usuario, char op)
        {
            Erro.setErro(false);

            // NOME
            if (usuario.getNome().Trim().Equals(""))
            {
                Erro.setMens("O nome é obrigatório!");
                return;
            }
            //// USUÁRIO
            //if (usuario.getUsuario().Trim().Equals(""))
            //{
            //    Erro.setMens("O usuário é obrigatório!");
            //    return;
            //}

            // EMAIL
            if (usuario.getEmail().Trim().Equals(""))
            {
                Erro.setMens("O email é obrigatório!");
                return;
            }

            // SENHA
            if (usuario.getSenha().Trim().Equals(""))
            {
                Erro.setMens("A senha é obrigatória!");
                return;
            }

            if (usuario.getSenha().Length < 6)
            {
                Erro.setMens("A senha deve ter no mínimo 6 caracteres!");
                return;
            }

            ////TELEFONE
            //if (usuario.getTelefone().Trim().Equals(""))
            //{
            //    Erro.setMens("O telefone é obrigatório!");
            //    return;
            //}

            if (usuario.getTelefone().Length < 10)
            {
                Erro.setMens("Telefone inválido!");
                return;
            }

            //CEP
            if (usuario.getCep().Trim().Equals(""))
            {
                Erro.setMens("O CEP é obrigatório!");
                return;
            }

            if (!long.TryParse(usuario.getCep(), out _))
            {
                Erro.setMens("O CEP deve conter apenas números!");
                return;
            }

            // CRIPTOGRAFAR SENHA
            usuario.setSenha(
                Criptografia.criptografarSenha(usuario.getSenha())
            );

            // CRIAR OBJETO DAL
            UsuarioDAL dal = new UsuarioDAL();

            //// INSERIR
            //if (op == 'i')
            //{
            //    dal.Cadastrar(usuario);
            //}

            //// ALTERAR
            //if (op == 'a')
            //{
            //    dal.Alterar(usuario);
            //}
        }

    }
}
