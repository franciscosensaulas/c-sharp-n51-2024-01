using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoForm.Repositorios
{
    internal class EstanteRepositorio
    {
        public void ConectarBancoDados()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "";
            conexao.Open();
        }
    }
}
