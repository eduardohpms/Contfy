using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contfy.Models
{
    internal class ContainerMdl
    {
        public String codigo;
        public String nome;
        public String status;
        public String localizacao;
        public String responsavel;

        public void setCodigo(String _codigo) { codigo = _codigo; }
        public void setNome(String _nome) { nome = _nome; }
        public void setStatus(String _status) { status = _status; }
        public void setLocalizacao(String _localizacao) { localizacao = _localizacao; }
        public void setResponsavel(String _responsavel) { responsavel = _responsavel; }

        public String getCodigo() { return codigo; }
        public String getNome() { return nome; }
        public String getStatus() { return status; }
        public String getLocalizacao() { return localizacao; }
        public String getResponsavel() { return responsavel; }
    }
}
