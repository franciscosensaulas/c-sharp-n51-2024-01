﻿using SupermercadoForm.BancoDados;
using SupermercadoForm.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    internal class ProdutoRepositorio
    {
        /*
         * Orientação a Objetos
             - Classe
                - Proprieades
                - Métodos => public void Executar(int numero1)
                     - Com(string,int) e sem retorno(void)
                     - Com e sem parâmetros => int numero1, o que fica dentro dos parênteses
        */
        public void Cadastrar(string nome, int idCategoria, decimal precoUnitario)
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
            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@ID_CATEGORIA", idCategoria);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", precoUnitario);
            comando.ExecuteNonQuery();
            // Fechar a conexão com o banco de dados
            comando.Connection.Close();
        }

        public List<Produto> ObterTodos()
        {

            // Instanciado um objeto que realiza a conexão com o banco de dados
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizando a conexão
            var comando = conexao.Conectar();
            // Definir o comando de criar produto na tabela de produtos
            comando.CommandText = """
                SELECT 
	                produtos.id, 
	                produtos.nome,
                    produtos.id_categoria AS 'categoriaId',
                    produtos.preco_unitario,
	                categorias.nome AS 'categoriaNome'

            FROM produtos

            -- JOIN: consulta multi tabelas;
            INNER JOIN categorias ON (produtos.id_categoria = categorias.id);
""";
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
    }
}