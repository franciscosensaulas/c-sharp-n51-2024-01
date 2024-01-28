namespace SupermercadoForm.Telas
{
    partial class CategoriaForm
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
            buttonCadastrar = new Button();
            labelNome = new Label();
            textBoxNome = new TextBox();
            buttonListar = new Button();
            richTextBoxCategorias = new RichTextBox();
            buttonApagar = new Button();
            labelCodigoApagar = new Label();
            textBoxCodigoApagar = new TextBox();
            labelCodigoParaAlterar = new Label();
            textBoxCodigoParaAlterar = new TextBox();
            textBoxNomeParaAlterar = new TextBox();
            labelNomeParaAlterar = new Label();
            buttonAlterar = new Button();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(747, 10);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(94, 29);
            buttonCadastrar.TabIndex = 2;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += button1_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 14);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(68, 12);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(673, 27);
            textBoxNome.TabIndex = 1;
            textBoxNome.KeyDown += textBoxNome_KeyDown;
            textBoxNome.KeyPress += textBoxNome_KeyPress;
            // 
            // buttonListar
            // 
            buttonListar.Location = new Point(747, 59);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(94, 225);
            buttonListar.TabIndex = 3;
            buttonListar.Text = "Listar";
            buttonListar.UseVisualStyleBackColor = true;
            buttonListar.Click += buttonListar_Click;
            // 
            // richTextBoxCategorias
            // 
            richTextBoxCategorias.Location = new Point(12, 60);
            richTextBoxCategorias.Name = "richTextBoxCategorias";
            richTextBoxCategorias.ReadOnly = true;
            richTextBoxCategorias.Size = new Size(729, 224);
            richTextBoxCategorias.TabIndex = 4;
            richTextBoxCategorias.TabStop = false;
            richTextBoxCategorias.Text = "";
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(747, 298);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(94, 29);
            buttonApagar.TabIndex = 5;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // labelCodigoApagar
            // 
            labelCodigoApagar.AutoSize = true;
            labelCodigoApagar.Location = new Point(12, 298);
            labelCodigoApagar.Name = "labelCodigoApagar";
            labelCodigoApagar.Size = new Size(58, 20);
            labelCodigoApagar.TabIndex = 6;
            labelCodigoApagar.Text = "Código";
            // 
            // textBoxCodigoApagar
            // 
            textBoxCodigoApagar.Location = new Point(76, 295);
            textBoxCodigoApagar.Name = "textBoxCodigoApagar";
            textBoxCodigoApagar.Size = new Size(665, 27);
            textBoxCodigoApagar.TabIndex = 4;
            // 
            // labelCodigoParaAlterar
            // 
            labelCodigoParaAlterar.AutoSize = true;
            labelCodigoParaAlterar.Location = new Point(17, 357);
            labelCodigoParaAlterar.Name = "labelCodigoParaAlterar";
            labelCodigoParaAlterar.Size = new Size(58, 20);
            labelCodigoParaAlterar.TabIndex = 8;
            labelCodigoParaAlterar.Text = "Código";
            // 
            // textBoxCodigoParaAlterar
            // 
            textBoxCodigoParaAlterar.Location = new Point(76, 350);
            textBoxCodigoParaAlterar.Name = "textBoxCodigoParaAlterar";
            textBoxCodigoParaAlterar.Size = new Size(125, 27);
            textBoxCodigoParaAlterar.TabIndex = 6;
            // 
            // textBoxNomeParaAlterar
            // 
            textBoxNomeParaAlterar.Location = new Point(263, 350);
            textBoxNomeParaAlterar.Name = "textBoxNomeParaAlterar";
            textBoxNomeParaAlterar.Size = new Size(478, 27);
            textBoxNomeParaAlterar.TabIndex = 7;
            // 
            // labelNomeParaAlterar
            // 
            labelNomeParaAlterar.AutoSize = true;
            labelNomeParaAlterar.Location = new Point(207, 357);
            labelNomeParaAlterar.Name = "labelNomeParaAlterar";
            labelNomeParaAlterar.Size = new Size(50, 20);
            labelNomeParaAlterar.TabIndex = 11;
            labelNomeParaAlterar.Text = "Nome";
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(747, 348);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(94, 29);
            buttonAlterar.TabIndex = 8;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // CategoriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 450);
            Controls.Add(buttonAlterar);
            Controls.Add(labelNomeParaAlterar);
            Controls.Add(textBoxNomeParaAlterar);
            Controls.Add(textBoxCodigoParaAlterar);
            Controls.Add(labelCodigoParaAlterar);
            Controls.Add(textBoxCodigoApagar);
            Controls.Add(labelCodigoApagar);
            Controls.Add(buttonApagar);
            Controls.Add(richTextBoxCategorias);
            Controls.Add(buttonListar);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Controls.Add(buttonCadastrar);
            Name = "CategoriaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            Load += CategoriaForm_Load;
            Shown += CategoriaForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCadastrar;
        private Label labelNome;
        private TextBox textBoxNome;
        private Button buttonListar;
        private RichTextBox richTextBoxCategorias;
        private Button buttonApagar;
        private Label labelCodigoApagar;
        private TextBox textBoxCodigoApagar;
        private Label labelCodigoParaAlterar;
        private TextBox textBoxCodigoParaAlterar;
        private TextBox textBoxNomeParaAlterar;
        private Label labelNomeParaAlterar;
        private Button buttonAlterar;
    }
}