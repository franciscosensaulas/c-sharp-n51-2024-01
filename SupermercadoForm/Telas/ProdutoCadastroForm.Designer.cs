namespace SupermercadoForm.Telas
{
    partial class ProdutoCadastroForm
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
            buttonSalvar = new Button();
            textBoxNome = new TextBox();
            labelNome = new Label();
            comboBoxCategoria = new ComboBox();
            labelCategoria = new Label();
            textBoxPrecoUnitario = new TextBox();
            labelPrecoUnitario = new Label();
            SuspendLayout();
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(235, 188);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 2;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 34);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(317, 27);
            textBoxNome.TabIndex = 13;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 11);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 12;
            labelNome.Text = "Nome";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(12, 96);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(317, 28);
            comboBoxCategoria.TabIndex = 15;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(12, 68);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(74, 20);
            labelCategoria.TabIndex = 14;
            labelCategoria.Text = "Categoria";
            // 
            // textBox1
            // 
            textBoxPrecoUnitario.Location = new Point(12, 155);
            textBoxPrecoUnitario.Name = "textBox1";
            textBoxPrecoUnitario.Size = new Size(317, 27);
            textBoxPrecoUnitario.TabIndex = 17;
            // 
            // labelPrecoUnitario
            // 
            labelPrecoUnitario.AutoSize = true;
            labelPrecoUnitario.Location = new Point(12, 132);
            labelPrecoUnitario.Name = "labelPrecoUnitario";
            labelPrecoUnitario.Size = new Size(103, 20);
            labelPrecoUnitario.TabIndex = 16;
            labelPrecoUnitario.Text = "Preço Unitário";
            // 
            // ProdutoCadastroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 235);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(labelPrecoUnitario);
            Controls.Add(comboBoxCategoria);
            Controls.Add(labelCategoria);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Controls.Add(buttonSalvar);
            Name = "ProdutoCadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProdutoCadastroForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalvar;
        private TextBox textBoxNome;
        private Label labelNome;
        private ComboBox comboBoxCategoria;
        private Label labelCategoria;
        private TextBox textBoxPrecoUnitario;
        private Label labelPrecoUnitario;
    }
}