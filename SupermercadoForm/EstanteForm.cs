using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermercadoForm
{
    public partial class EstanteForm : Form
    {
        public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\franc\\Desktop\\Supermercado.mdf;Integrated Security=True;Connect Timeout=30";
        private int IdParaEditar = -1;

        public EstanteForm()
        {
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
            string pesquisa = "%" + textBoxPesquisar.Text.Trim() + "%"; // %Nes%

            // Conectar no banco de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            // Definir o comando da consulta das estantes
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, sigla FROM estantes WHERE nome LIKE @PESQUISA";
            comando.Parameters.AddWithValue("@PESQUISA", pesquisa);

            // Criar tabela em memória e carregar registros da consulta(SELECT) das estantes
            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Limpar dataGridView, para n ter duplicidade de registros
            dataGridViewEstantes.Rows.Clear();

            // Percorrer cada um dos registros
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                // Obter o registro(estante) percorrida
                DataRow registro = tabelaEmMemoria.Rows[i];
                // Obter o id, nome e sigla da consulta realizada
                int id = Convert.ToInt32(registro["id"]);
                string nome = registro["nome"].ToString();
                string sigla = registro["sigla"].ToString();

                // Adicionar uma linha no DataGridView(componente de tabela do Form)
                dataGridViewEstantes.Rows.Add(new object[]
                {
                    id, nome, sigla
                });
            }

            // Fechar a conexão com o Banco de Dados
            conexao.Close();
        }

        private void CadastrarEstante()
        {
            // Obter o nome e sigla do form
            string nome = textBoxNome.Text;
            string sigla = maskedTextBoxSigla.Text;

            // Conectar no banco de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            // Definir o comando da consulta das estantes
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO estantes (nome, sigla) VALUES (@NOME, @SIGLA)";
            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@SIGLA", sigla);

            // Executar o insert armazenando a quantidade de registros afetados
            int quantidadeRegistrosAfetados = comando.ExecuteNonQuery();

            // Verificar que o registro foi persistido com sucesso
            if (quantidadeRegistrosAfetados > 0)
            {
                ListarEstantes(); // Atualizar dataGridView(tabela) com os registros das estantes do BD
                LimparCampos(); // Limpar os Campos da tela
                //MessageBox.Show("Estante cadastrada com sucesso");
            }
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

            // Conectar no banco de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            // Definir o comando da consulta das estantes
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM estantes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            int quantidadeRegistrosAfetados = comando.ExecuteNonQuery();

            if (quantidadeRegistrosAfetados > 0)
            {
                ListarEstantes();
                MessageBox.Show("Estante apagada com sucesso");
            }

            // Fechar a conexão com o BD
            conexao.Close();
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

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            // Definir o comando da consulta das estantes
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, sigla FROM estantes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", IdParaEditar);

            // Criar tabela em memória e carregar registro da consulta(SELECT) das estantes
            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Obter a primeira linha da tabela pois filtramos buscando por id, retornará um único registro
            DataRow registro = tabelaEmMemoria.Rows[0];

            string nome = registro["nome"].ToString();
            string sigla = registro["sigla"].ToString();

            textBoxNome.Text = nome;
            maskedTextBoxSigla.Text = sigla;

            // Fechar a conexão
            conexao.Close();
        }

        private void AtualizarEstante()
        {
            // Obter o nome e sigla do form
            string nome = textBoxNome.Text;
            string sigla = maskedTextBoxSigla.Text;

            // Conectar no banco de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            // Definir o comando de atualização do registro da estante
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE estantes SET nome = @NOME, sigla = @SIGLA WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@SIGLA", sigla);
            comando.Parameters.AddWithValue("@ID", IdParaEditar);

            // Executar o update armazenando a quantidade de registros afetados
            int quantidadeRegistrosAfetados = comando.ExecuteNonQuery();

            // Verificar que o registro foi persistido com sucesso
            if (quantidadeRegistrosAfetados > 0)
            {
                ListarEstantes(); // Atualizar dataGridView(tabela) com os registros das estantes do BD
                LimparCampos(); // Limpar os Campos da tela
                MessageBox.Show("Estante alterada com sucesso");
            }
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
