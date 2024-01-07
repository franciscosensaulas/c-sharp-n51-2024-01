namespace SupermercadoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Ao abrir a tela ir� deixar preenchido por padr�o a opera��o Somar
            comboBoxOperacao.SelectedItem = "Somar";
        }

        private void buttonConcatenar_Click(object sender, EventArgs e)
        {
            // Obter o nome que est� preenchido no TextBox do nome
            string nome = textBoxNome.Text;
            // Validar que nome cont�m de 2 at� 15 caracteres
            if (nome.Length > 15)
            {
                MessageBox.Show("Nome deve conter no m�ximo 15 caracteres");
                // Encerrar a execu��o deste m�todo
                return;
            }
            if (nome.Length < 2)
            {
                MessageBox.Show("Nome deve conter no m�nimo 2 caracteres");
                return;
            }

            // Obter o sobrenome que est� preenchido no TextBox do sobrenome
            string sobrenome = textBoxSobrenome.Text;
            // Validar que nome cont�m de 5 at� 150 caracteres
            if (sobrenome.Length > 150)
            {
                MessageBox.Show("Sobrenome deve conter no m�ximo 150 caracteres");
                // Encerrar a execu��o deste m�todo
                return;
            }
            if (sobrenome.Length < 2)
            {
                MessageBox.Show("Sobrenome deve conter no m�nimo 2 caracteres");
                return;
            }

            // Concatenar o nome e sobrenome
            string nomeCompleto = nome + " " + sobrenome;
            // Apresentar o nome completo do usu�rio
            MessageBox.Show(nomeCompleto);
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {

            //if (comboBoxOperacao.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Selecione uma opera��o antes de calcular");
            //    return;
            //}

            // Para obter o item escolhido do combo box utilizamos SelectedItem
            string operacaoEscolhida = comboBoxOperacao.SelectedItem.ToString();
            int numero1 = 0;
            try
            {
                // Obter o n�mero 1 preenchido no campo TextBox
                numero1 = Convert.ToInt32(textBoxNumero1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�mero 1 deve ser um n�mero inteiro");
                textBoxNumero1.Focus();
                return;
            }

            int numero2 = 0;
            try
            {
                // Obter o n�mero 2 preenchido no campo TextBox
                numero2 = Convert.ToInt32(textBoxNumero2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�mero 2 deve ser um n�mero inteiro");
                textBoxNumero2.Focus();
                return;
            }

            int resultado = 0;
            char operacaoSimbolo = ' ';
            if (operacaoEscolhida == "Somar")
            {
                resultado = numero1 + numero2;
                operacaoSimbolo = '+';
            }
            else if (operacaoEscolhida == "Subtrair")
            {
                resultado = numero1 - numero2;
                operacaoSimbolo = '-';
            }
            else if (operacaoEscolhida == "Multiplicar")
            {
                resultado = numero1 * numero2;
                operacaoSimbolo = '*';
            }
            else if (operacaoEscolhida == "Dividir")
            {
                resultado = numero1 / numero2;
                operacaoSimbolo = '/';

                if (numero2 == 0)
                {
                    MessageBox.Show("N�mero 2 n�o pode ser 0");
                    textBoxNumero2.Focus();
                    return;
                }
            }

            DateTime dataHoraAtual = DateTime.Now;
            string dataHoraFormatada = dataHoraAtual.ToShortDateString() + " " + dataHoraAtual.ToLongTimeString();
            string texto = dataHoraFormatada + " " + numero1 + " " + operacaoSimbolo + " " + numero2 + " = " + resultado + "\n";
            // Concantenando o hist�rico com a nova opera��o realizada
            //richTextBoxHistorico.Text = richTextBoxHistorico.Text + texto;
            richTextBoxHistorico.Text += texto;

            LimparCampos();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();

            richTextBoxHistorico.Clear();
        }

        private void LimparCampos()
        {
            // Limpar campos
            //textBoxNumero1.Text = "";
            textBoxNumero1.Clear();
            textBoxNumero2.Clear();
            comboBoxOperacao.SelectedItem = "Somar";
            textBoxNumero1.Focus();
        }
    }
}
