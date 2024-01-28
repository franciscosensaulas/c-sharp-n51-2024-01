namespace SupermercadoForm.Telas
{
    partial class MenuForm
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
            buttonEstantes = new Button();
            buttonCategorias = new Button();
            buttonProdutos = new Button();
            SuspendLayout();
            // 
            // buttonEstantes
            // 
            buttonEstantes.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            buttonEstantes.ForeColor = Color.BlueViolet;
            buttonEstantes.Location = new Point(404, 110);
            buttonEstantes.Name = "buttonEstantes";
            buttonEstantes.Size = new Size(180, 180);
            buttonEstantes.TabIndex = 1;
            buttonEstantes.Text = "Estantes";
            buttonEstantes.UseVisualStyleBackColor = true;
            buttonEstantes.Click += buttonEstantes_Click;
            // 
            // buttonCategorias
            // 
            buttonCategorias.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            buttonCategorias.ForeColor = Color.BlueViolet;
            buttonCategorias.Location = new Point(180, 110);
            buttonCategorias.Name = "buttonCategorias";
            buttonCategorias.Size = new Size(180, 180);
            buttonCategorias.TabIndex = 2;
            buttonCategorias.Text = "Categorias";
            buttonCategorias.UseVisualStyleBackColor = true;
            buttonCategorias.Click += buttonCategorias_Click;
            // 
            // buttonProdutos
            // 
            buttonProdutos.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            buttonProdutos.ForeColor = Color.BlueViolet;
            buttonProdutos.Location = new Point(617, 110);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(180, 180);
            buttonProdutos.TabIndex = 3;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.UseVisualStyleBackColor = true;
            buttonProdutos.Click += buttonProdutos_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 450);
            Controls.Add(buttonProdutos);
            Controls.Add(buttonCategorias);
            Controls.Add(buttonEstantes);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema do Supermercado";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonEstantes;
        private Button buttonCategorias;
        private Button buttonProdutos;
    }
}