using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contfy.Models
{
    internal class UsuarioMdl
    {
        public String nome;
        public String usuario;
        public String email;
        public String senha;
        public String telefone;
        public String cep;
        public String rua;
        public String bairro;
        public String cidade;
        public String estado;

        public void setNome(String _nome) { nome = _nome; }
        public void setUsuario(String _usuario) { usuario = _usuario; }
        public void setSenha(String _senha) { senha = _senha; }
        public void setEmail(String _email) { email = _email; } 
        public void setTelefone(String _telefone) { telefone = _telefone; }
        public void setCep(String _cep) { cep = _cep; }
        public void setRua(String _rua) { rua = _rua; }
        public void setBairro(String _bairro) { bairro = _bairro; }
        public void setCidade(String _cidade) { cidade = _cidade; }
        public void setEstado(String _estado) { estado = _estado; }

        public String getNome() { return nome; }
        public String getUsuario() { return usuario; }
        public String getSenha() { return senha; }
        public String getEmail() { return email; }
        public String getTelefone() { return telefone; }
        public String getCep() { return cep; }
        public String getRua() { return rua; }
        public String getBairro() { return bairro; }
        public String getCidade() { return cidade; }
        public String getEstado() { return estado; }

    }
}
