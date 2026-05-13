using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contfy.DAL
{
    internal class UsuarioDAL
    {
        private static SqlConnection cn = ConexaoDAL.getConexao();
        public static void conectar()
        {
            try
            {
                cn.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        public static void desconectar()
        {
            try
            {
                cn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }
    }
}
