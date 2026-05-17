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

namespace Contfy
{
    public partial class AdminContainerForm : Form
    {
        public AdminContainerForm()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ContainerMdl container = new ContainerMdl();

            container.setCodigo(tbCodigo.Text);
            container.setNome(tbNome.Text);
            container.setStatus(cbStatus.Text);
            container.setLocalizacao(tbLocalizacao.Text);
            container.setResponsavel(tbResponsavel.Text);

            ContainerAdminBLL.validaDadosAdicionar(container, 'i');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
                return;
            }
            else
            {
                MessageBox.Show("Cadastro do container realizado com sucesso!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ContainerMdl container = new ContainerMdl();

            container.setCodigo(tbCodigo.Text);
            container.setNome(tbNome.Text);
            container.setStatus(cbStatus.Text);
            container.setLocalizacao(tbLocalizacao.Text);
            container.setResponsavel(tbResponsavel.Text);

            ContainerAdminBLL.validaDadosAlterar(container, 'a');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
                return;
            }
            else
            {
                MessageBox.Show("Alteração do container realizada com sucesso!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ContainerMdl container = new ContainerMdl();

            container.setCodigo(tbCodigo.Text);
            container.setNome(tbNome.Text);
            container.setStatus(cbStatus.Text);
            container.setLocalizacao(tbLocalizacao.Text);
            container.setResponsavel(tbResponsavel.Text);

            ContainerAdminBLL.validaDadosDeletar(container, 'd');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
                return;
            }
            else
            {
                MessageBox.Show("Exclusão do container realizada com sucesso!");
            }
        }
    }
}
