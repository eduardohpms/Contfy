using Contfy.BLL;
using Contfy.BLL.Utils;
using Contfy.DAL;
using Contfy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contfy
{
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }
        private void btnCCriarConta_Click(object sender, EventArgs e)
        {
            UsuarioForm telaLogin = new UsuarioForm();
            telaLogin.Show();
            this.Close();

            UsuarioMdl umUsuario = new UsuarioMdl();

            umUsuario.setNome(tbNome.Text);
            umUsuario.setUsuario(tbUsuario.Text);

            string senhaCripto = Criptografia.criptografarSenha(tbSenha.Text);
            umUsuario.setSenha(senhaCripto);

            umUsuario.setEmail(tbEmail.Text);
            umUsuario.setTelefone(mtbTelefone.Text);
            umUsuario.setCep(mtbCEP.Text);
            umUsuario.setRua(tbRua.Text);
            umUsuario.setBairro(tbBairro.Text);
            umUsuario.setCidade(tbCidade.Text);
            umUsuario.setEstado(cbEstado.Text);

            UsuarioBLL.validaDados(umUsuario, 'i');
            if (Erro.getErro())
                MessageBox.Show(Erro.getMens());
            else
                //UsuarioDAL.salvar(umUsuario);
                MessageBox.Show("Cadastro realizado!");
        }
    }
}
