﻿using SupermercadoRepositorios.Entidades;
using SupermercadoRepositorios.Repositorios;

namespace SupermercadoForm.Telas
{
    public partial class ProdutoCadastroForm : Form
    {
        private int IdProdutoEditar = -1;

        public ProdutoCadastroForm()
        {
            InitializeComponent();
            PreencherDadosCategorias();
        }

        public ProdutoCadastroForm(Produto produto)
        {
            InitializeComponent();
            PreencherDadosCategorias();

            IdProdutoEditar = produto.Id;
            textBoxNome.Text = produto.Nome;
            textBoxPrecoUnitario.Text = produto.PrecoUnitario.ToString();

            foreach (var item in comboBoxCategoria.Items)
            {
                var categoria = (Categoria)item;
                var categoriaId = categoria.Id;
                if (categoriaId == produto.Categoria.Id)
                {
                    comboBoxCategoria.SelectedItem = categoria;
                    break;
                }
            }

        }

        private void PreencherDadosCategorias()
        {
            // Instanciado um objeto do CategoriaRepositorio, para obtermos a lista de categorias,
            // para permitir o usuário escolher a categoria desejada no ComboBox da Categoria
            var categoriaRepositorio = new CategoriaRepositorio();
            // Obter a lista de categorias (SELECT no BD)
            var categorias = categoriaRepositorio.ObterTodos();
            // Percorrer cada uma das categorias obtidas na consulta (SELECT), adicionando no ComboBox da Categoria
            for (int i = 0; i < categorias.Count; i++)
            {
                // Categoria percorrida
                var categoria = categorias[i];
                // Adicionar a categoria percorrida no ComboBox da Categoria
                comboBoxCategoria.Items.Add(categoria);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter a Categoria Selecionada
            var categoria = (Categoria)comboBoxCategoria.SelectedItem;

            var nome = textBoxNome.Text;
            var precoUnitario = Convert.ToDecimal(textBoxPrecoUnitario.Text);

            var repositorio = new ProdutoRepositorio();

            Produto produto;

            if (IdProdutoEditar == -1)
            {
                produto = new Produto()
                {
                    Nome = nome,
                    PrecoUnitario = precoUnitario,
                    CategoriaId = categoria.Id
                };

                repositorio.Cadastrar(produto);
                MessageBox.Show("Produto cadastrado com sucesso");
                return;
            }

            produto = repositorio.ObterPorId(IdProdutoEditar);
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Categoria = categoria;
            
            repositorio.Atualizar(produto);
            MessageBox.Show("Produto atualizado com sucesso");

        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
