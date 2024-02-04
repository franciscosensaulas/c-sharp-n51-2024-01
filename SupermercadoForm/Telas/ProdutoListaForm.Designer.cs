namespace SupermercadoForm.Telas
{
    partial class ProdutoListaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewProdutos = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnCategoria = new DataGridViewTextBoxColumn();
            ColumnPrecoUnitario = new DataGridViewTextBoxColumn();
            buttonNovo = new Button();
            buttonEditar = new Button();
            buttonApagar = new Button();
            labelQuantidadeTotal = new Label();
            labelQuantidadeTotalValor = new Label();
            labelExibir = new Label();
            labelQuantidade = new Label();
            comboBoxQuantidade = new ComboBox();
            comboBoxExibir = new ComboBox();
            labelPesquisa = new Label();
            textBoxPesquisa = new TextBox();
            buttonPesquisar = new Button();
            buttonLimparFiltros = new Button();
            comboBoxOrdenar = new ComboBox();
            labelOrdenar = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.AllowUserToAddRows = false;
            dataGridViewProdutos.AllowUserToDeleteRows = false;
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNome, ColumnCategoria, ColumnPrecoUnitario });
            dataGridViewProdutos.Location = new Point(12, 106);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.ReadOnly = true;
            dataGridViewProdutos.RowHeadersWidth = 51;
            dataGridViewProdutos.Size = new Size(776, 411);
            dataGridViewProdutos.TabIndex = 0;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Código";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Width = 125;
            // 
            // ColumnNome
            // 
            ColumnNome.HeaderText = "Nome";
            ColumnNome.MinimumWidth = 6;
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            ColumnNome.Width = 125;
            // 
            // ColumnCategoria
            // 
            ColumnCategoria.HeaderText = "Categoria";
            ColumnCategoria.MinimumWidth = 6;
            ColumnCategoria.Name = "ColumnCategoria";
            ColumnCategoria.ReadOnly = true;
            ColumnCategoria.Width = 125;
            // 
            // ColumnPrecoUnitario
            // 
            ColumnPrecoUnitario.HeaderText = "Preço Unitário";
            ColumnPrecoUnitario.MinimumWidth = 6;
            ColumnPrecoUnitario.Name = "ColumnPrecoUnitario";
            ColumnPrecoUnitario.ReadOnly = true;
            ColumnPrecoUnitario.Width = 125;
            // 
            // buttonNovo
            // 
            buttonNovo.Location = new Point(794, 15);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(94, 85);
            buttonNovo.TabIndex = 1;
            buttonNovo.Text = "Novo";
            buttonNovo.UseVisualStyleBackColor = true;
            buttonNovo.Click += buttonNovo_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(794, 106);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(94, 29);
            buttonEditar.TabIndex = 2;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(794, 141);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(94, 29);
            buttonApagar.TabIndex = 3;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            // 
            // labelQuantidadeTotal
            // 
            labelQuantidadeTotal.AutoSize = true;
            labelQuantidadeTotal.Location = new Point(526, 520);
            labelQuantidadeTotal.Name = "labelQuantidadeTotal";
            labelQuantidadeTotal.Size = new Size(206, 20);
            labelQuantidadeTotal.TabIndex = 4;
            labelQuantidadeTotal.Text = "Quantidade total de Produtos";
            // 
            // labelQuantidadeTotalValor
            // 
            labelQuantidadeTotalValor.AutoSize = true;
            labelQuantidadeTotalValor.Location = new Point(738, 520);
            labelQuantidadeTotalValor.Name = "labelQuantidadeTotalValor";
            labelQuantidadeTotalValor.Size = new Size(40, 20);
            labelQuantidadeTotalValor.TabIndex = 5;
            labelQuantidadeTotalValor.Text = "total";
            // 
            // labelExibir
            // 
            labelExibir.AutoSize = true;
            labelExibir.Location = new Point(142, 9);
            labelExibir.Name = "labelExibir";
            labelExibir.Size = new Size(46, 20);
            labelExibir.TabIndex = 6;
            labelExibir.Text = "Exibir";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(12, 9);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(87, 20);
            labelQuantidade.TabIndex = 7;
            labelQuantidade.Text = "Quantidade";
            // 
            // comboBoxQuantidade
            // 
            comboBoxQuantidade.FormattingEnabled = true;
            comboBoxQuantidade.Items.AddRange(new object[] { "10 itens", "25 itens", "50 itens", "100 itens" });
            comboBoxQuantidade.Location = new Point(12, 37);
            comboBoxQuantidade.Name = "comboBoxQuantidade";
            comboBoxQuantidade.Size = new Size(116, 28);
            comboBoxQuantidade.TabIndex = 8;
            // 
            // comboBoxExibir
            // 
            comboBoxExibir.FormattingEnabled = true;
            comboBoxExibir.Items.AddRange(new object[] { "Código", "Nome", "Categoria", "Preço Unitário" });
            comboBoxExibir.Location = new Point(142, 37);
            comboBoxExibir.Name = "comboBoxExibir";
            comboBoxExibir.Size = new Size(164, 28);
            comboBoxExibir.TabIndex = 9;
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Location = new Point(471, 15);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(65, 20);
            labelPesquisa.TabIndex = 10;
            labelPesquisa.Text = "Pesquisa";
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Location = new Point(471, 38);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(317, 27);
            textBoxPesquisa.TabIndex = 11;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(694, 71);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(94, 29);
            buttonPesquisar.TabIndex = 12;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // buttonLimparFiltros
            // 
            buttonLimparFiltros.Location = new Point(553, 71);
            buttonLimparFiltros.Name = "buttonLimparFiltros";
            buttonLimparFiltros.Size = new Size(135, 29);
            buttonLimparFiltros.TabIndex = 13;
            buttonLimparFiltros.Text = "Limpar Filtros";
            buttonLimparFiltros.UseVisualStyleBackColor = true;
            // 
            // comboBoxOrdenar
            // 
            comboBoxOrdenar.FormattingEnabled = true;
            comboBoxOrdenar.Items.AddRange(new object[] { "A-Z", "Z-A" });
            comboBoxOrdenar.Location = new Point(312, 37);
            comboBoxOrdenar.Name = "comboBoxOrdenar";
            comboBoxOrdenar.Size = new Size(153, 28);
            comboBoxOrdenar.TabIndex = 15;
            // 
            // labelOrdenar
            // 
            labelOrdenar.AutoSize = true;
            labelOrdenar.Location = new Point(312, 9);
            labelOrdenar.Name = "labelOrdenar";
            labelOrdenar.Size = new Size(63, 20);
            labelOrdenar.TabIndex = 14;
            labelOrdenar.Text = "Ordenar";
            // 
            // ProdutoListaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 557);
            Controls.Add(comboBoxOrdenar);
            Controls.Add(labelOrdenar);
            Controls.Add(buttonLimparFiltros);
            Controls.Add(buttonPesquisar);
            Controls.Add(textBoxPesquisa);
            Controls.Add(labelPesquisa);
            Controls.Add(comboBoxExibir);
            Controls.Add(comboBoxQuantidade);
            Controls.Add(labelQuantidade);
            Controls.Add(labelExibir);
            Controls.Add(labelQuantidadeTotalValor);
            Controls.Add(labelQuantidadeTotal);
            Controls.Add(buttonApagar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonNovo);
            Controls.Add(dataGridViewProdutos);
            Name = "ProdutoListaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Produtos";
            Load += ProdutoListaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProdutos;
        private Button buttonNovo;
        private Button buttonEditar;
        private Button buttonApagar;
        private Label labelQuantidadeTotal;
        private Label labelQuantidadeTotalValor;
        private Label labelExibir;
        private Label labelQuantidade;
        private ComboBox comboBoxQuantidade;
        private ComboBox comboBoxExibir;
        private Label labelPesquisa;
        private TextBox textBoxPesquisa;
        private Button buttonPesquisar;
        private Button buttonLimparFiltros;
        private ComboBox comboBoxOrdenar;
        private Label labelOrdenar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnPrecoUnitario;
    }
}