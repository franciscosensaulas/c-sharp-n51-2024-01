namespace SupermercadoForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelPrimeiraTela = new Label();
            buttonConcatenar = new Button();
            labelNome = new Label();
            labelSobrenome = new Label();
            textBoxNome = new TextBox();
            textBoxSobrenome = new TextBox();
            labelOperacao = new Label();
            comboBoxOperacao = new ComboBox();
            labelNumero1 = new Label();
            textBoxNumero1 = new TextBox();
            labelNumero2 = new Label();
            textBoxNumero2 = new TextBox();
            labelHistorico = new Label();
            richTextBoxHistorico = new RichTextBox();
            buttonCalcular = new Button();
            buttonLimpar = new Button();
            SuspendLayout();
            // 
            // labelPrimeiraTela
            // 
            labelPrimeiraTela.AutoSize = true;
            labelPrimeiraTela.Font = new Font("Microsoft Sans Serif", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrimeiraTela.ForeColor = Color.Red;
            labelPrimeiraTela.Location = new Point(20, 8);
            labelPrimeiraTela.Margin = new Padding(2, 0, 2, 0);
            labelPrimeiraTela.Name = "labelPrimeiraTela";
            labelPrimeiraTela.Size = new Size(154, 26);
            labelPrimeiraTela.TabIndex = 0;
            labelPrimeiraTela.Text = "Primeira Tela";
            // 
            // buttonConcatenar
            // 
            buttonConcatenar.Location = new Point(20, 131);
            buttonConcatenar.Margin = new Padding(2);
            buttonConcatenar.Name = "buttonConcatenar";
            buttonConcatenar.Size = new Size(314, 126);
            buttonConcatenar.TabIndex = 1;
            buttonConcatenar.Text = "Concatenar";
            buttonConcatenar.UseVisualStyleBackColor = true;
            buttonConcatenar.Click += buttonConcatenar_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(20, 32);
            labelNome.Margin = new Padding(2, 0, 2, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            // 
            // labelSobrenome
            // 
            labelSobrenome.AutoSize = true;
            labelSobrenome.Location = new Point(20, 85);
            labelSobrenome.Margin = new Padding(2, 0, 2, 0);
            labelSobrenome.Name = "labelSobrenome";
            labelSobrenome.Size = new Size(68, 15);
            labelSobrenome.TabIndex = 3;
            labelSobrenome.Text = "Sobrenome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(20, 49);
            textBoxNome.Margin = new Padding(2);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(316, 23);
            textBoxNome.TabIndex = 4;
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.Location = new Point(20, 102);
            textBoxSobrenome.Margin = new Padding(2);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(316, 23);
            textBoxSobrenome.TabIndex = 5;
            // 
            // labelOperacao
            // 
            labelOperacao.AutoSize = true;
            labelOperacao.Location = new Point(363, 32);
            labelOperacao.Margin = new Padding(2, 0, 2, 0);
            labelOperacao.Name = "labelOperacao";
            labelOperacao.Size = new Size(58, 15);
            labelOperacao.TabIndex = 6;
            labelOperacao.Text = "Operação";
            // 
            // comboBoxOperacao
            // 
            comboBoxOperacao.FormattingEnabled = true;
            comboBoxOperacao.Items.AddRange(new object[] { "Dividir", "Multiplicar", "Somar", "Subtrair" });
            comboBoxOperacao.Location = new Point(363, 49);
            comboBoxOperacao.Margin = new Padding(2);
            comboBoxOperacao.Name = "comboBoxOperacao";
            comboBoxOperacao.Size = new Size(257, 23);
            comboBoxOperacao.TabIndex = 7;
            // 
            // labelNumero1
            // 
            labelNumero1.AutoSize = true;
            labelNumero1.Location = new Point(364, 82);
            labelNumero1.Margin = new Padding(2, 0, 2, 0);
            labelNumero1.Name = "labelNumero1";
            labelNumero1.Size = new Size(66, 15);
            labelNumero1.TabIndex = 8;
            labelNumero1.Text = "Número 01";
            // 
            // textBoxNumero1
            // 
            textBoxNumero1.Location = new Point(364, 102);
            textBoxNumero1.Margin = new Padding(2);
            textBoxNumero1.Name = "textBoxNumero1";
            textBoxNumero1.Size = new Size(114, 23);
            textBoxNumero1.TabIndex = 9;
            // 
            // labelNumero2
            // 
            labelNumero2.AutoSize = true;
            labelNumero2.Location = new Point(494, 82);
            labelNumero2.Margin = new Padding(2, 0, 2, 0);
            labelNumero2.Name = "labelNumero2";
            labelNumero2.Size = new Size(66, 15);
            labelNumero2.TabIndex = 10;
            labelNumero2.Text = "Número 02";
            // 
            // textBoxNumero2
            // 
            textBoxNumero2.Location = new Point(494, 102);
            textBoxNumero2.Margin = new Padding(2);
            textBoxNumero2.Name = "textBoxNumero2";
            textBoxNumero2.Size = new Size(126, 23);
            textBoxNumero2.TabIndex = 11;
            // 
            // labelHistorico
            // 
            labelHistorico.AutoSize = true;
            labelHistorico.Location = new Point(364, 131);
            labelHistorico.Margin = new Padding(2, 0, 2, 0);
            labelHistorico.Name = "labelHistorico";
            labelHistorico.Size = new Size(55, 15);
            labelHistorico.TabIndex = 12;
            labelHistorico.Text = "Histórico";
            // 
            // richTextBoxHistorico
            // 
            richTextBoxHistorico.Location = new Point(364, 148);
            richTextBoxHistorico.Margin = new Padding(2);
            richTextBoxHistorico.Name = "richTextBoxHistorico";
            richTextBoxHistorico.Size = new Size(256, 111);
            richTextBoxHistorico.TabIndex = 13;
            richTextBoxHistorico.Text = "";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(624, 11);
            buttonCalcular.Margin = new Padding(2);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(78, 202);
            buttonCalcular.TabIndex = 14;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(623, 217);
            buttonLimpar.Margin = new Padding(2);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(78, 40);
            buttonLimpar.TabIndex = 15;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 270);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonCalcular);
            Controls.Add(richTextBoxHistorico);
            Controls.Add(labelHistorico);
            Controls.Add(textBoxNumero2);
            Controls.Add(labelNumero2);
            Controls.Add(textBoxNumero1);
            Controls.Add(labelNumero1);
            Controls.Add(comboBoxOperacao);
            Controls.Add(labelOperacao);
            Controls.Add(textBoxSobrenome);
            Controls.Add(textBoxNome);
            Controls.Add(labelSobrenome);
            Controls.Add(labelNome);
            Controls.Add(buttonConcatenar);
            Controls.Add(labelPrimeiraTela);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPrimeiraTela;
        private Button buttonConcatenar;
        private Label labelNome;
        private Label labelSobrenome;
        private TextBox textBoxNome;
        private TextBox textBoxSobrenome;
        private Label labelOperacao;
        private ComboBox comboBoxOperacao;
        private Label labelNumero1;
        private TextBox textBoxNumero1;
        private Label labelNumero2;
        private TextBox textBoxNumero2;
        private Label labelHistorico;
        private RichTextBox richTextBoxHistorico;
        private Button buttonCalcular;
        private Button buttonLimpar;
    }
}
