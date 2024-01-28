namespace SupermercadoForm.Telas
{
    partial class EstanteForm
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
            labelNome = new Label();
            labelSigla = new Label();
            textBoxNome = new TextBox();
            buttonSalvar = new Button();
            maskedTextBoxSigla = new MaskedTextBox();
            labelEstantes = new Label();
            dataGridViewEstantes = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnSigla = new DataGridViewTextBoxColumn();
            buttonApagar = new Button();
            buttonEditar = new Button();
            label1 = new Label();
            textBoxPesquisar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstantes).BeginInit();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 9);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // labelSigla
            // 
            labelSigla.AutoSize = true;
            labelSigla.Location = new Point(12, 62);
            labelSigla.Name = "labelSigla";
            labelSigla.Size = new Size(42, 20);
            labelSigla.TabIndex = 1;
            labelSigla.Text = "Sigla";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 32);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(413, 27);
            textBoxNome.TabIndex = 1;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(331, 127);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 3;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // maskedTextBoxSigla
            // 
            maskedTextBoxSigla.Location = new Point(12, 85);
            maskedTextBoxSigla.Mask = "AAA";
            maskedTextBoxSigla.Name = "maskedTextBoxSigla";
            maskedTextBoxSigla.Size = new Size(413, 27);
            maskedTextBoxSigla.TabIndex = 2;
            // 
            // labelEstantes
            // 
            labelEstantes.AutoSize = true;
            labelEstantes.Location = new Point(450, 9);
            labelEstantes.Name = "labelEstantes";
            labelEstantes.Size = new Size(63, 20);
            labelEstantes.TabIndex = 12;
            labelEstantes.Text = "Estantes";
            // 
            // dataGridViewEstantes
            // 
            dataGridViewEstantes.AllowUserToAddRows = false;
            dataGridViewEstantes.AllowUserToDeleteRows = false;
            dataGridViewEstantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstantes.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNome, ColumnSigla });
            dataGridViewEstantes.Location = new Point(450, 42);
            dataGridViewEstantes.Name = "dataGridViewEstantes";
            dataGridViewEstantes.ReadOnly = true;
            dataGridViewEstantes.RowHeadersWidth = 51;
            dataGridViewEstantes.RowTemplate.Height = 29;
            dataGridViewEstantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEstantes.Size = new Size(658, 514);
            dataGridViewEstantes.TabIndex = 13;
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
            ColumnNome.Width = 300;
            // 
            // ColumnSigla
            // 
            ColumnSigla.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnSigla.HeaderText = "Sigla";
            ColumnSigla.MinimumWidth = 6;
            ColumnSigla.Name = "ColumnSigla";
            ColumnSigla.ReadOnly = true;
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(1114, 67);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(94, 29);
            buttonApagar.TabIndex = 5;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(1114, 32);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(94, 29);
            buttonEditar.TabIndex = 4;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(840, 12);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 14;
            label1.Text = "Pesquisar";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Location = new Point(916, 9);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(192, 27);
            textBoxPesquisar.TabIndex = 15;
            textBoxPesquisar.KeyDown += textBoxPesquisar_KeyDown;
            // 
            // EstanteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 568);
            Controls.Add(textBoxPesquisar);
            Controls.Add(label1);
            Controls.Add(buttonEditar);
            Controls.Add(buttonApagar);
            Controls.Add(dataGridViewEstantes);
            Controls.Add(labelEstantes);
            Controls.Add(maskedTextBoxSigla);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxNome);
            Controls.Add(labelSigla);
            Controls.Add(labelNome);
            Name = "EstanteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estantes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelSigla;
        private TextBox textBoxNome;
        private Button buttonSalvar;
        private MaskedTextBox maskedTextBoxSigla;
        private Label labelEstantes;
        private DataGridView dataGridViewEstantes;
        private Button buttonApagar;
        private Button buttonEditar;
        private Label label1;
        private TextBox textBoxPesquisar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnSigla;
    }
}