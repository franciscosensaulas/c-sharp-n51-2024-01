using SupermercadoForm.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermercadoForm.Telas
{
    public partial class ProdutoListaForm : Form
    {
        public ProdutoListaForm()
        {
            InitializeComponent();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            var formCadastro = new ProdutoCadastroForm();
            formCadastro.Text = "Cadastro de Produto";
            formCadastro.ShowDialog();
        }

        private void ProdutoListaForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComProdutos();
        }

        private void PreencherDataGridViewComProdutos()
        {
            // Remover todas as linhas do dataGridView (para n ficar lixo, pois iremos adicionar os registros novamente)
            dataGridViewProdutos.Rows.Clear();

            // Instanciado um objeto do ProdutoRepositorio, para obtermos a lista de produtos
            var produtoRepositorio = new ProdutoRepositorio();
            // Obter a lista de produtos (SELECT no BD)
            var produtos = produtoRepositorio.ObterTodos();

            // Percorrer cada um dos produtos adicionando no DataGridView
            for (int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];
                dataGridViewProdutos.Rows.Add(new object[]
                {
                    produto.Id,
                    produto.Nome,
                    produto.Categoria.Nome,
                    produto.PrecoUnitario
                });
            }
        }
    }
}
