using SupermercadoRepositorios.Entidades;
using SupermercadoRepositorios.Repositorios;
using System.Data.SqlClient;

namespace SupermercadoForm.Telas
{
    public partial class EstanteForm : Form
    {
        private IEstanteRepositorio repositorio;
        private int IdParaEditar = -1;

        public EstanteForm()
        {
            repositorio = new EstanteRepositorio();

            InitializeComponent();
            ListarEstantes();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Verificar que é o modo de cadastro, pois -1 não é um id válido
            if (IdParaEditar == -1)
            {
                CadastrarEstante();
            }
            else
            {
                AtualizarEstante();
            }
        }

        private void ListarEstantes()
        {
            // Obter o texto para pesquisa
            string pesquisa = textBoxPesquisar.Text.Trim();

            // Limpar dataGridView, para n ter duplicidade de registros
            dataGridViewEstantes.Rows.Clear();

            // Buscar as estantes do BD
            var estantes = repositorio.ObterTodos(pesquisa);

            // Percorrer cada um dos registros
            foreach (var estante in estantes)
                // Adicionar uma linha no DataGridView(componente de tabela do Form)
                dataGridViewEstantes.Rows.Add(new object[]
                {
                    estante.Id, estante.Nome, estante.Sigla
                });
        }

        private void CadastrarEstante()
        {
            // Obter o nome e sigla do form
            string nome = textBoxNome.Text;
            string sigla = maskedTextBoxSigla.Text;

            var estante = new Estante();
            estante.Nome = nome;
            estante.Sigla = sigla;

            repositorio.Cadastrar(estante);

            ListarEstantes(); // Atualizar dataGridView(tabela) com os registros das estantes do BD
            LimparCampos(); // Limpar os Campos da tela
            MessageBox.Show("Estante cadastrada com sucesso");
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            //maskedTextBoxSigla.Clear();
            IdParaEditar = -1; // Redefinir para -1 para que seja possível usuário fazer o cadastro novamente
            textBoxNome.Focus();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            ApagarEstante();
        }

        private void ApagarEstante()
        {
            // Verificar que existe linhas(registros) no dataGridView
            if (dataGridViewEstantes.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Nenhuma estante cadastrada",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Pegar a linha que o usuário selecionou
            DataGridViewRow linhaSelecionada = dataGridViewEstantes.SelectedRows[0];
            // Pegar o id da linha selecionada
            int id = Convert.ToInt32(linhaSelecionada.Cells[0].Value); // Cells[0] pq a primeira coluna do dataGridView é o Id
            string nome = linhaSelecionada.Cells[1].Value.ToString();

            // Questionar se deseja realmente apagar o registro
            DialogResult resultadoQuestionamento = MessageBox.Show(
                "Deseja realmente apagar " + nome + "?",
                "AVISO",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            // Verificar se deseja manter o registro
            if (resultadoQuestionamento == DialogResult.No)
            {
                return;
            }

            repositorio.Apagar(id);
            ListarEstantes();
            MessageBox.Show("Estante apagada com sucesso");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarEstante();
        }

        private void EditarEstante()
        {
            // Verificar que existe linhas(registros) no dataGridView
            if (dataGridViewEstantes.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Nenhuma estante cadastrada",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Pegar a linha que o usuário selecionou
            DataGridViewRow linhaSelecionada = dataGridViewEstantes.SelectedRows[0];
            // Pegar o id da linha selecionada
            IdParaEditar = Convert.ToInt32(linhaSelecionada.Cells[0].Value); // Cells[0] pq a primeira coluna do dataGridView é o Id

            var estante = repositorio.ObterPorId(IdParaEditar);

            textBoxNome.Text = estante.Nome;
            maskedTextBoxSigla.Text = estante.Sigla;
        }

        private void AtualizarEstante()
        {
            // Obter o nome e sigla do form
            string nome = textBoxNome.Text;
            string sigla = maskedTextBoxSigla.Text;

            var estante = repositorio.ObterPorId(IdParaEditar);
            estante.Nome = nome;
            estante.Sigla = sigla;

            repositorio.Atualizar(estante);

            ListarEstantes(); // Atualizar dataGridView(tabela) com os registros das estantes do BD
            LimparCampos(); // Limpar os Campos da tela
            MessageBox.Show("Estante alterada com sucesso");
        }

        private void textBoxPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListarEstantes();
            }
        }
    }
}
