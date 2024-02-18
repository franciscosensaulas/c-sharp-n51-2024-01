using SupermercadoRepositorios.BancoDados;
using SupermercadoRepositorios.Entidades;
using System.Data;

namespace SupermercadoForm.Repositorios
{
    public class CategoriaRepositorio
    {
        public List<Categoria> ObterTodos()
        {
            // Instanciado um objeto que realiza a conexão com o banco de dados
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizando a conexão
            var comando = conexao.Conectar();
            // Definir o comando que será executado para buscar as categorias ordenadas
            comando.CommandText = "SELECT id, nome FROM categorias ORDER BY nome ASC";
            // Instanciado uma tabela em memória para armazenar os registros retornados do BD na consulta SELECT
            var tabelaEmMemoria = new DataTable();
            // Executar a consulta SELECT carregando os dados na tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());
            // Fechar conexão com o BD
            comando.Connection.Close();

            // Instanciado uma lista para armazenar as categorias
            var categorias = new List<Categoria>();
            // Percorrer cada um dos registros da consulta SELECT
            for (var i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                // Obter o registro percorrido
                var registro = tabelaEmMemoria.Rows[i];
                var id = Convert.ToInt32(registro["id"]);
                var nome = registro["nome"].ToString();

                // Instanciado um objeto de categoria para que seja possível adicionar na lista de categorias
                var categoria = new Categoria();
                categoria.Id = id;
                categoria.Nome = nome;

                // Adicionar a categoria na lista de categorias
                categorias.Add(categoria);
            }
            // Retornar a lista de categorias obtidas na consulta SELECT
            return categorias;
        }

        // Assinatura do método Cadastrar
        // encapsulamento + TipoRetorno + NomeMetodo(TipoParametro nomeParametro, ....)
        public void Cadastrar(Categoria categoria)
        {
            // Instanciado um objeto que realiza a conexão com o banco de dados
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizando a conexão
            var comando = conexao.Conectar();
            // Definir o comando de insert
            comando.CommandText = "INSERT INTO categorias (nome) VALUES (@NOME)";
            // Definir todos os parâmetros do insert
            comando.Parameters.AddWithValue("@NOME", categoria.Nome);
            // Executa o comando de insert
            comando.ExecuteNonQuery();
            // Fechar a conexão com o BD
            comando.Connection.Close();
        }

        public void Atualizar(Categoria categoria)
        {
            // Instanciado um objeto que realiza a conexão com o banco de dados
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizando a conexão
            var comando = conexao.Conectar();
            // Definir o comando de update
            comando.CommandText = "UPDATE categorias SET nome = @NOME WHERE id = @ID";
            // Definir todos os parâmetros do insert
            comando.Parameters.AddWithValue("@NOME", categoria.Nome);
            comando.Parameters.AddWithValue("@ID", categoria.Id);
            // Executa o comando de update
            comando.ExecuteNonQuery();
            // Fechar a conexão com o BD
            comando.Connection.Close();
        }

        public void Apagar(int id)
        {
            // Instanciado um objeto que realiza a conexão com o banco de dados
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizando a conexão
            var comando = conexao.Conectar();
            // Definir o comando de delete
            comando.CommandText = "DELETE FROM categorias WHERE id = @ID";
            // Definir todos os parâmetros do delete
            comando.Parameters.AddWithValue("@ID", id);
            // Executa o comando de delete
            comando.ExecuteNonQuery();
            // Fechar a conexão com o BD
            comando.Connection.Close();
        }

        public Categoria ObterPorId(int id)
        {
            // Instanciado um objeto que realiza a conexão com o banco de dados
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizando a conexão
            var comando = conexao.Conectar();
            // Definir o comando que será executado para buscar a categoria filtrada por id
            comando.CommandText = "SELECT id, nome FROM categorias WHERE id = @ID";
            // Instanciado uma tabela em memória para armazenar os registros retornados do BD na consulta SELECT
            var tabelaEmMemoria = new DataTable();
            // Executar a consulta SELECT carregando os dados na tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());
            // Fechar conexão com o BD
            comando.Connection.Close();

            // Obtém os dados do registro da consulta SELECT
            var registro = tabelaEmMemoria.Rows[0];
            var nome = registro["nome"].ToString();

            // Instanciado um objeto de categoria para que seja possível adicionar na lista de categorias
            var categoria = new Categoria();
            categoria.Id = id;
            categoria.Nome = nome;
            return categoria;
        }
    }
}
