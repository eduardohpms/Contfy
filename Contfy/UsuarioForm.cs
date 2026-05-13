using Contfy.BLL;
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
using System.Data.SqlClient;
using Contfy.DAL;

namespace Contfy
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            tbLoginSenha.UseSystemPasswordChar = !cbMostrarSenha.Checked;
        }

        private void lnkCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroForm telaCadastro = new CadastroForm();
            telaCadastro.Show();
            this.Hide();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            UsuarioMdl umUsuario = new UsuarioMdl();
            umUsuario.setUsuario(tbLoginUsuario.Text);
            umUsuario.setSenha(tbLoginSenha.Text);

            UsuarioBLL.validaDadosLogin(umUsuario);
            if (Erro.getErro())
                MessageBox.Show(Erro.getMens());
            else
                MessageBox.Show("Dados inseridos com sucesso!");
        }
    }
}
