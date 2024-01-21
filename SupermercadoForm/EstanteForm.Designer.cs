namespace SupermercadoForm
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
            textBoxNome.TabIndex = 3;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(331, 127);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 10;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxSigla
            // 
            maskedTextBoxSigla.Location = new Point(12, 85);
            maskedTextBoxSigla.Mask = "AAA";
            maskedTextBoxSigla.Name = "maskedTextBoxSigla";
            maskedTextBoxSigla.Size = new Size(413, 27);
            maskedTextBoxSigla.TabIndex = 11;
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
            dataGridViewEstantes.Location = new Point(450, 32);
            dataGridViewEstantes.Name = "dataGridViewEstantes";
            dataGridViewEstantes.ReadOnly = true;
            dataGridViewEstantes.RowHeadersWidth = 51;
            dataGridViewEstantes.RowTemplate.Height = 29;
            dataGridViewEstantes.Size = new Size(658, 524);
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
            ColumnNome.Width = 125;
            // 
            // ColumnSigla
            // 
            ColumnSigla.HeaderText = "Sigla";
            ColumnSigla.MinimumWidth = 6;
            ColumnSigla.Name = "ColumnSigla";
            ColumnSigla.ReadOnly = true;
            ColumnSigla.Width = 125;
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(1114, 67);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(94, 29);
            buttonApagar.TabIndex = 14;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(1114, 32);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(94, 29);
            buttonEditar.TabIndex = 15;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // EstanteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 568);
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
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnSigla;
        private Button buttonApagar;
        private Button buttonEditar;
    }
}