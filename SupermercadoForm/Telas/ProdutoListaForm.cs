﻿using SupermercadoForm.Modelos;
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
        private int posicaoPaginacao = 0;
        private int QuantidadeRegistros = 0;

        public ProdutoListaForm()
        {
            InitializeComponent();
            comboBoxExibir.SelectedIndex = 0;
            comboBoxOrdenar.SelectedIndex = 0;
            comboBoxQuantidade.SelectedIndex = 0;
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

            // Obter o que foi preenchido no campo de pesquisa
            var produtoFiltros = new ProdutoFiltros();

            produtoFiltros.Pesquisa = textBoxPesquisa.Text.Trim();
            produtoFiltros.Quantidade = ObterQuantidadeParaExibir();
            produtoFiltros.OrdenacaoCampo = comboBoxExibir.SelectedItem.ToString();
            produtoFiltros.OrdenacaoOrdem = comboBoxOrdenar.SelectedItem.ToString();
            produtoFiltros.Pagina = posicaoPaginacao;

            // Instanciado um objeto do ProdutoRepositorio, para obtermos a lista de produtos
            var produtoRepositorio = new ProdutoRepositorio();
            // Obter a lista de produtos (SELECT no BD)
            var produtos = produtoRepositorio.ObterTodos(produtoFiltros);

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

            PreencherLabelQuantidadeTotalRegistros();
            DesabilitarBotaoPaginacaoAnteriorNegativa();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            PreencherDataGridViewComProdutos();
        }

        private void textBoxPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PreencherDataGridViewComProdutos();
            }
        }

        private void comboBoxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherDataGridViewComProdutosCasoComboBoxEstiverPreenchido();
        }

        private void comboBoxExibir_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherDataGridViewComProdutosCasoComboBoxEstiverPreenchido();
        }

        private void PreencherDataGridViewComProdutosCasoComboBoxEstiverPreenchido()
        {
            if (comboBoxExibir.SelectedIndex != -1 &&
               comboBoxOrdenar.SelectedIndex != -1 &&
               comboBoxQuantidade.SelectedIndex != -1)
            {
                posicaoPaginacao = 0;
                PreencherDataGridViewComProdutos();
            }
        }

        private void comboBoxQuantidade_SelectedIndexChanged(object sender, EventArgs e)
        {

            PreencherDataGridViewComProdutosCasoComboBoxEstiverPreenchido();
        }

        private void buttonPaginacaoProximo_Click(object sender, EventArgs e)
        {
            int quantidadeParaExibir = ObterQuantidadeParaExibir();
            posicaoPaginacao += quantidadeParaExibir;
            PreencherDataGridViewComProdutos();
        }

        private void buttonPaginacaoAnterior_Click(object sender, EventArgs e)
        {
            int quantidadeParaExibir = ObterQuantidadeParaExibir();
            posicaoPaginacao -= quantidadeParaExibir;
            PreencherDataGridViewComProdutos();
        }

        private void DesabilitarBotaoPaginacaoAnteriorNegativa()
        {
            int quantidadeParaExibir = ObterQuantidadeParaExibir();
            if (posicaoPaginacao - quantidadeParaExibir < 0)
            {
                buttonPaginacaoAnterior.Enabled = false;
            }
            if (posicaoPaginacao - quantidadeParaExibir >= 0)
            {
                buttonPaginacaoAnterior.Enabled = true;
            }

            if (posicaoPaginacao + quantidadeParaExibir >= QuantidadeRegistros)
            {
                buttonPaginacaoProximo.Enabled = false;
            }

            if (posicaoPaginacao + quantidadeParaExibir < QuantidadeRegistros)
            {
                buttonPaginacaoProximo.Enabled = true;
            }
        }

        private void PreencherLabelQuantidadeTotalRegistros()
        {
            var produtoRepositorio = new ProdutoRepositorio();
            QuantidadeRegistros = produtoRepositorio.ObterQuantidadeTotalRegistros();
            labelQuantidadeTotalValor.Text = QuantidadeRegistros.ToString();
        }

        private int ObterQuantidadeParaExibir()
        {
            var quantidadeSelecionada = comboBoxQuantidade.SelectedItem.ToString();

            var campoQuantidade = 10;
            if (quantidadeSelecionada == "25 itens")
                campoQuantidade = 25;
            else if (quantidadeSelecionada == "50 itens")
                campoQuantidade = 50;
            else if (quantidadeSelecionada == "100 itens")
                campoQuantidade = 100;

            return campoQuantidade;
        }

        private void buttonLimparFiltros_Click(object sender, EventArgs e)
        {
            comboBoxExibir.SelectedIndex = 0;
            comboBoxOrdenar.SelectedIndex = 0;
            comboBoxQuantidade.SelectedIndex = 0;
            textBoxPesquisa.Clear();
            PreencherDataGridViewComProdutos();
        }
    }
}
