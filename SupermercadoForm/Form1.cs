namespace SupermercadoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Ao abrir a tela irá deixar preenchido por padrão a operação Somar
            comboBoxOperacao.SelectedItem = "Somar";
        }

        private void buttonConcatenar_Click(object sender, EventArgs e)
        {
            // Obter o nome que está preenchido no TextBox do nome
            string nome = textBoxNome.Text;
            // Validar que nome contém de 2 até 15 caracteres
            if (nome.Length > 15)
            {
                MessageBox.Show("Nome deve conter no máximo 15 caracteres");
                // Encerrar a execução deste método
                return;
            }
            if (nome.Length < 2)
            {
                MessageBox.Show("Nome deve conter no mínimo 2 caracteres");
                return;
            }

            // Obter o sobrenome que está preenchido no TextBox do sobrenome
            string sobrenome = textBoxSobrenome.Text;
            // Validar que nome contém de 5 até 150 caracteres
            if (sobrenome.Length > 150)
            {
                MessageBox.Show("Sobrenome deve conter no máximo 150 caracteres");
                // Encerrar a execução deste método
                return;
            }
            if (sobrenome.Length < 2)
            {
                MessageBox.Show("Sobrenome deve conter no mínimo 2 caracteres");
                return;
            }

            // Concatenar o nome e sobrenome
            string nomeCompleto = nome + " " + sobrenome;
            // Apresentar o nome completo do usuário
            MessageBox.Show(nomeCompleto);
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {

            //if (comboBoxOperacao.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Selecione uma operação antes de calcular");
            //    return;
            //}

            // Para obter o item escolhido do combo box utilizamos SelectedItem
            string operacaoEscolhida = comboBoxOperacao.SelectedItem.ToString();
            int numero1 = 0;
            try
            {
                // Obter o número 1 preenchido no campo TextBox
                numero1 = Convert.ToInt32(textBoxNumero1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Número 1 deve ser um número inteiro");
                textBoxNumero1.Focus();
                return;
            }

            int numero2 = 0;
            try
            {
                // Obter o número 2 preenchido no campo TextBox
                numero2 = Convert.ToInt32(textBoxNumero2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Número 2 deve ser um número inteiro");
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
                    MessageBox.Show("Número 2 não pode ser 0");
                    textBoxNumero2.Focus();
                    return;
                }
            }

            DateTime dataHoraAtual = DateTime.Now;
            string dataHoraFormatada = dataHoraAtual.ToShortDateString() + " " + dataHoraAtual.ToLongTimeString();
            string texto = dataHoraFormatada + " " + numero1 + " " + operacaoSimbolo + " " + numero2 + " = " + resultado + "\n";
            // Concantenando o histórico com a nova operação realizada
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
