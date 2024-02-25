using SupermercadoForm.Modelos;
using SupermercadoRepositorios.BancoDados;
using SupermercadoRepositorios.Entidades;
using SupermercadoRepositorios.Repositorios;
using System.Data;

namespace SupermercadoForm.Repositorios
{
    // Repositório: tem a responsabilidade de
    // intermediar a camadas anteriores (tela) com o Banco de Dados, ou seja, ele é responsável 
    // por executar comandos de SQL (SELECT,INSERT,UPDATE,DELETE) 
    // CRUD => 
    // Create => INSERT
    // Read => SELECT
    // Update => UPDATE
    // Delete => DELETE
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        /*
         * Orientação a Objetos
             - Classe
                - Proprieades
                - Métodos => public void Executar(int numero1)
                     - Com(string,int) e sem retorno(void)
                     - Com e sem parâmetros => int numero1, o que fica dentro dos parênteses
        */
        public void Cadastrar(Produto produto)
        {
            // Instanciado um objeto que realiza a conexão com o banco de dados
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizando a conexão
            var comando = conexao.Conectar();
            // Definir o comando de criar produto na tabela de produtos
            comando.CommandText = """
                INSERT INTO produtos (nome, id_categoria, preco_unitario) VALUES
                (@NOME, @ID_CATEGORIA, @PRECO_UNITARIO)
            """;
            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@ID_CATEGORIA", produto.Categoria.Id);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", produto.PrecoUnitario);
            comando.ExecuteNonQuery();
            // Fechar a conexão com o banco de dados
            comando.Connection.Close();
        }

        public List<Produto> ObterTodos(ProdutoFiltros produtoFiltros)
        {
            // Instanciado um objeto que realiza a conexão com o banco de dados
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizando a conexão
            var comando = conexao.Conectar();
            // Definir o comando de criar produto na tabela de produtos
            comando.CommandText = $"""
                SELECT 
	                produtos.id, 
	                produtos.nome,
                    produtos.id_categoria AS 'categoriaId',
                    produtos.preco_unitario,
	                categorias.nome AS 'categoriaNome'

            FROM produtos

            -- JOIN: consulta multi tabelas;
            INNER JOIN categorias ON (produtos.id_categoria = categorias.id)

            WHERE produtos.nome LIKE @PESQUISA
            ORDER BY {produtoFiltros.OrdenacaoCampo} {produtoFiltros.OrdenacaoOrdem}
            OFFSET @POSICAO_PAGINACAO ROWS -- Determinar qual será a página
            FETCH NEXT @QUANTIDADE ROWS ONLY -- Determinar a quantidade de registros consultados
""";
            comando.Parameters.AddWithValue("@PESQUISA", produtoFiltros.Pesquisa);
            comando.Parameters.AddWithValue("@QUANTIDADE", produtoFiltros.Quantidade);
            comando.Parameters.AddWithValue("@POSICAO_PAGINACAO", produtoFiltros.Pagina);

            // Instanciado uma tabela em memória para armazenar os registros retornados do BD na consulta SELECT
            var tabelaEmMemoria = new DataTable();
            // Executar a consulta SELECT carregando os dados na tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());
            // Fechar conexão com o BD
            comando.Connection.Close();

            // Instanciado uma lista para armazenar as produtos
            var produtos = new List<Produto>();
            // Percorrer os registros armazenados na tabela em memória
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                // Obter o registro percorrido
                var registro = tabelaEmMemoria.Rows[i];

                var produto = new Produto();
                produto.Id = Convert.ToInt32(registro["id"]);
                produto.Nome = registro["nome"].ToString();
                produto.PrecoUnitario = Convert.ToDecimal(registro["preco_unitario"]);

                // Instanciar um objeto preenchendo os dados da categoria
                var categoria = new Categoria();
                categoria.Id = Convert.ToInt32(registro["categoriaId"]);
                categoria.Nome = registro["categoriaNome"].ToString();

                // Definir a categoria para o objeto do produto, para que seja possível visualizar na tela a categoria do produto
                produto.Categoria = categoria;

                produtos.Add(produto);
            }

            return produtos;
        }

        public int ObterQuantidadeTotalRegistros()
        {
            // Instanciado um objeto que realiza a conexão com o banco de dados
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizando a conexão
            var comando = conexao.Conectar();
            // Definir o comando de criar produto na tabela de produtos
            comando.CommandText = "SELECT COUNT(id) FROM produtos";
            // ExecuteScalar executará o comando no banco de dados com o objetivo de obter um número inteiro
            var registroQuantidade = Convert.ToInt32(comando.ExecuteScalar());
            // Fechar conexão
            comando.Connection.Close();
            return registroQuantidade;
        }

        public void Apagar(int id)
        {
            // Instanciado um objeto que realiza a conexão com o banco de dados
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizando a conexão
            var comando = conexao.Conectar();
            // Definir o comando de apagar o produto
            comando.CommandText = "DELETE FROM produtos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            // Fechar a conexão com o banco de dados
            comando.Connection.Close();
        }

        public Produto ObterPorId(int id)
        {// Instanciado um objeto que realiza a conexão com o banco de dados
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizando a conexão
            var comando = conexao.Conectar();
            // Definir o comando de consultar produto na tabela de produtos
            comando.CommandText = "SELECT * FROM produtos WHERE id = @ID";
            // Definir o valor do id para o select
            comando.Parameters.AddWithValue("@ID", id);
            // Instanciado uma tabela em memória para armazenar os registros retornados do BD na consulta SELECT
            var tabelaEmMemoria = new DataTable();
            // Executar a consulta SELECT carregando os dados na tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());
            // Fechar conexão com o BD
            comando.Connection.Close();
            // Obter o registro
            var registro = tabelaEmMemoria.Rows[0];
            var produto = new Produto();
            produto.Id = Convert.ToInt32(registro["id"]);
            produto.Nome = registro["nome"].ToString();
            produto.PrecoUnitario = Convert.ToDecimal(registro["preco_unitario"]);
            produto.Categoria = new Categoria();
            produto.Categoria.Id = Convert.ToInt32(registro["id_categoria"]);
            return produto;
        }

        public void Atualizar(Produto produto)
        {
            // Instanciado um objeto que realiza a conexão com o banco de dados
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizando a conexão
            var comando = conexao.Conectar();
            // Definir o comando de atualizar produto na tabela de produtos
            comando.CommandText = """
                UPDATE produtos SET 
                    nome = @NOME,
                    id_categoria = @ID_CATEGORIA,
                    preco_unitario = @PRECO_UNITARIO
                WHERE id = @ID
            """;
            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@ID_CATEGORIA", produto.Categoria.Id);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", produto.PrecoUnitario);
            comando.Parameters.AddWithValue("@ID", produto.Id);
            comando.ExecuteNonQuery();
            // Fechar a conexão com o banco de dados
            comando.Connection.Close();
        }
    }
}
