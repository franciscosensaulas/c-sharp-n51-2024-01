using SupermercadoRepositorios.BancoDados;
using SupermercadoRepositorios.Entidades;
using System.Data;

namespace SupermercadoForm.Repositorios
{
    public class EstanteRepositorio : IEstanteRepositorio
    {
        private ConexaoBancoDados conexao;

        // Construtor tem como objetivo definir/construir tudo que é necessário para que a classe funcione corretametne
        // Encapsulamento + NomeClasseAtual()
        public EstanteRepositorio()
        {
            // Instanciando um objeto da classe ConexaoBancoDados, para que depois seja
            // possível abrir a conexão com o BD
            conexao = new ConexaoBancoDados();
        }

        public void Apagar(int id)
        {
            // Abrir conexão com o BD
            var comando = conexao.Conectar();
            // Definir o comando de apagar a estante
            comando.CommandText = "DELETE FROM estantes WHERE id = @ID";
            // Definir os parâmetros do comando
            comando.Parameters.AddWithValue("@ID", id);
            // Executar o comando de delete
            comando.ExecuteNonQuery();
            // Fechar a conexão com o BD
            comando.Connection.Close();
        }

        public void Atualizar(Estante estante)
        {
            // Abrir conexão com o BD
            var comando = conexao.Conectar();
            // Definir o comando de atualizar a estante
            comando.CommandText = "UPDATE estantes SET nome = @NOME, sigla = @SIGLA WHERE id = @ID";
            // Definir os parâmetros do comando
            comando.Parameters.AddWithValue("@ID", estante.Id);
            comando.Parameters.AddWithValue("@NOME", estante.Nome);
            comando.Parameters.AddWithValue("@SIGLA", estante.Sigla);
            // Executar o comando de update
            comando.ExecuteNonQuery();
            // Fechar a conexão com o BD
            comando.Connection.Close();
        }

        public void Cadastrar(Estante estante)
        {
            // Abrir conexão com o BD
            var comando = conexao.Conectar();
            // Definir o comando de criar a estante
            comando.CommandText = "INSERT INTO estantes (nome, sigla) VALUES (@NOME, @SIGLA)";
            // Definir os parâmetros do comando
            comando.Parameters.AddWithValue("@NOME", estante.Nome);
            comando.Parameters.AddWithValue("@SIGLA", estante.Sigla);
            // Executar o comando de insert
            comando.ExecuteNonQuery();
            // Fechar a conexão com o BD
            comando.Connection.Close();
        }

        public Estante ObterPorId(int id)
        {
            // Abrir conexão com o BD
            var comando = conexao.Conectar();
            // Definir o comando de obter a estante buscando por id
            comando.CommandText = "SELECT id, nome, sigla FROM estantes WHERE id = @ID";
            // Definir os parâmetros do comando
            comando.Parameters.AddWithValue("@ID", id);
            // Criar tabela em memória para carregar os registros da consulta (SELECT)
            var tabelaEmMemoria = new DataTable();
            // Carregar tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());
            // Fechar a conexão com o BD
            comando.Connection.Close();
            // Obter o primeiro registro que foi encontrado da consulta SELECT
            var registro = tabelaEmMemoria.Rows[0];
            // Criar o objeto de estante com os dados da consulta
            var estante = new Estante();
            estante.Id = id;
            estante.Nome = registro["nome"].ToString();
            estante.Sigla = registro["sigla"].ToString();
            return estante;
        }

        public List<Estante> ObterTodos(string pesquisa)
        {
            pesquisa = $"%{pesquisa}%";

            // Abrir conexão com o BD
            var comando = conexao.Conectar();
            // Definir o comando de obter a estante buscando por id
            comando.CommandText = "SELECT id, nome, sigla FROM estantes WHERE nome LIKE @PESQUISA";
            // Definir os parâmetros da consulta
            comando.Parameters.AddWithValue("@PESQUISA", pesquisa);
            // Criar tabela em memória para carregar os registros da consulta (SELECT)
            var tabelaEmMemoria = new DataTable();
            // Carregar tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());
            // Fechar a conexão com o BD
            comando.Connection.Close();
            // Criar lista de estantes para armazenar os registros da consulta
            var estantes = new List<Estante>();
            // Percorrer cada um dos registros
            foreach (DataRow registro in tabelaEmMemoria.Rows)
            {
                // Criar o objeto de estante com os dados da consulta
                var estante = new Estante();
                estante.Id = Convert.ToInt32(registro["id"]);
                estante.Nome = registro["nome"].ToString();
                estante.Sigla = registro["sigla"].ToString();
                estantes.Add(estante);
            }
            return estantes;
        }
    }
}
