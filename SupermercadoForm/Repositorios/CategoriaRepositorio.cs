using SupermercadoForm.BancoDados;
using SupermercadoForm.Entidades;
using System.Data;

namespace SupermercadoForm.Repositorios
{
    internal class CategoriaRepositorio
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
    }
}
