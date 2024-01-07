namespace SupermercadoForm
{
    partial class Exercicio01Form
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
            labelNota1 = new Label();
            labelNota2 = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            labelIdade = new Label();
            labelNota3 = new Label();
            textBoxNota1 = new TextBox();
            textBoxNota3 = new TextBox();
            textBoxNota2 = new TextBox();
            numericUpDownIdade = new NumericUpDown();
            buttonCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIdade).BeginInit();
            SuspendLayout();
            // 
            // labelNota1
            // 
            labelNota1.AutoSize = true;
            labelNota1.Location = new Point(12, 74);
            labelNota1.Name = "labelNota1";
            labelNota1.Size = new Size(42, 15);
            labelNota1.TabIndex = 0;
            labelNota1.Text = "Nota 1";
            // 
            // labelNota2
            // 
            labelNota2.AutoSize = true;
            labelNota2.Location = new Point(12, 103);
            labelNota2.Name = "labelNota2";
            labelNota2.Size = new Size(42, 15);
            labelNota2.TabIndex = 1;
            labelNota2.Text = "Nota 2";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(61, 6);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(403, 23);
            textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 9);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome";
            // 
            // labelIdade
            // 
            labelIdade.AutoSize = true;
            labelIdade.Location = new Point(12, 40);
            labelIdade.Name = "labelIdade";
            labelIdade.Size = new Size(36, 15);
            labelIdade.TabIndex = 4;
            labelIdade.Text = "Idade";
            labelIdade.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelNota3
            // 
            labelNota3.AutoSize = true;
            labelNota3.Location = new Point(12, 136);
            labelNota3.Name = "labelNota3";
            labelNota3.Size = new Size(42, 15);
            labelNota3.TabIndex = 5;
            labelNota3.Text = "Nota 3";
            // 
            // textBoxNota1
            // 
            textBoxNota1.Location = new Point(61, 74);
            textBoxNota1.Name = "textBoxNota1";
            textBoxNota1.Size = new Size(100, 23);
            textBoxNota1.TabIndex = 3;
            // 
            // textBoxNota3
            // 
            textBoxNota3.Location = new Point(61, 136);
            textBoxNota3.Name = "textBoxNota3";
            textBoxNota3.Size = new Size(100, 23);
            textBoxNota3.TabIndex = 5;
            // 
            // textBoxNota2
            // 
            textBoxNota2.Location = new Point(61, 103);
            textBoxNota2.Name = "textBoxNota2";
            textBoxNota2.Size = new Size(100, 23);
            textBoxNota2.TabIndex = 4;
            // 
            // numericUpDownIdade
            // 
            numericUpDownIdade.Location = new Point(61, 40);
            numericUpDownIdade.Name = "numericUpDownIdade";
            numericUpDownIdade.Size = new Size(120, 23);
            numericUpDownIdade.TabIndex = 2;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(199, 36);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(265, 123);
            buttonCalcular.TabIndex = 6;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // Exercicio01Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCalcular);
            Controls.Add(numericUpDownIdade);
            Controls.Add(textBoxNota2);
            Controls.Add(textBoxNota3);
            Controls.Add(textBoxNota1);
            Controls.Add(labelNota3);
            Controls.Add(labelIdade);
            Controls.Add(labelNome);
            Controls.Add(textBoxNome);
            Controls.Add(labelNota2);
            Controls.Add(labelNota1);
            Name = "Exercicio01Form";
            Text = "Exercicio01Form";
            ((System.ComponentModel.ISupportInitialize)numericUpDownIdade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNota1;
        private Label labelNota2;
        private TextBox textBoxNome;
        private Label labelNome;
        private Label labelIdade;
        private Label labelNota3;
        private TextBox textBoxNota1;
        private TextBox textBoxNota3;
        private TextBox textBoxNota2;
        private NumericUpDown numericUpDownIdade;
        private Button buttonCalcular;
    }
}