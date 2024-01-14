using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SupermercadoForm
{
    public partial class CategoriaForm : Form
    {
        public CategoriaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // CRUD
            // Create => INSERT
            CriarCategoria();
        }

        private void CriarCategoria()
        {
            // Obter o nome da categoria que o usuário preencheu
            string nomeCategoria = textBoxNome.Text;
            if (nomeCategoria.Length < 3)
            {
                MessageBox.Show("Nome da categoria deve conter no mínimo 3 caracteres");
                return;
            }

            // Instancia um objeto para abrir a conexão com o banco de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\franc\\Desktop\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";

            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO categorias (nome) VALUES ('" + nomeCategoria + "')";
            comando.ExecuteNonQuery();
            // Limpar campo do nome da categoria
            textBoxNome.Clear();
            // Apresentar feedback que a categoria foi criada
            MessageBox.Show("Categoria criada com sucesso");
            // Atualizar a lista das categorias
            ListarCategorias();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            // CRUD
            // READ => SELECT
            ListarCategorias();
        }


        // Método ListarCategorias sem retorno(void)
        private void ListarCategorias()
        {
            // Instanciar um objeto para abrir a conexão com o Banco de Dados
            SqlConnection conexao = new SqlConnection();
            // Definir a ConnectionString (onde o bd se encontra)
            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\franc\\Desktop\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";
            // Abrir a conexão com o Banco de Dados
            conexao.Open();
            // Criar o objeto que será utilizado para definir o comando que será executado
            SqlCommand comando = conexao.CreateCommand();
            // Definir o comando que será executado
            comando.CommandText = "SELECT id, nome FROM categorias";

            // Criado tabela em memória para carregar os dados retornados do SELECT
            DataTable tabelaEmMemoria = new DataTable();
            // Carregado os dados da consulta (SELECT) na tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Limpar campo que contém as categorias
            richTextBoxCategorias.Clear();

            // Percorrer cada um dos registros da consutla na tabela de categorias
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                // Obter o id e nome do registro percorrido
                DataRow registro = tabelaEmMemoria.Rows[i];
                int id = Convert.ToInt32(registro["id"]);
                string nome = registro["nome"].ToString();
                // Adicionar no campo das categorias o registro percorrido
                richTextBoxCategorias.AppendText("Cod: " + id + " => " + nome + "\n");
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            ApagarCategoria();
        }

        private void ApagarCategoria()
        {
            // Obter o código que o usuário informou que deseja apagar
            int codigoInformado = Convert.ToInt32(textBoxCodigoApagar.Text);

            // Instanciar um objeto para abrir a conexão com o Banco de Dados
            SqlConnection conexao = new SqlConnection();
            // Definir a ConnectionString (onde o bd se encontra)
            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\franc\\Desktop\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";
            // Abrir a conexão com o Banco de Dados
            conexao.Open();
            // Criar o objeto que será utilizado para definir o comando que será executado
            SqlCommand comando = conexao.CreateCommand();
            // Definir o comando que será executado
            comando.CommandText = "DELETE FROM categorias WHERE id = " + codigoInformado;
            // Executar o comando para apagar a categoria
            int quantidadeRegistrosApagados = comando.ExecuteNonQuery();

            // Verificar que nenhum registro foi apagado
            if (quantidadeRegistrosApagados == 0)
            {
                // Apresentar feedback que nenhum registro foi apagado
                MessageBox.Show("Não existe categoria com o código " + codigoInformado);
                textBoxCodigoApagar.Focus();
                return;
            }

            // Limpar campo do código para apagar
            textBoxCodigoApagar.Clear();
            // Apresentar feedback que a categoria foi apagada
            MessageBox.Show("Registro apagado com sucesso");
            // Atualizar lista de categorias
            ListarCategorias();
        }

        private void CategoriaForm_Load(object sender, EventArgs e)
        {
            // Preencher a lista de categorias com os registros da tabela de categorias
            ListarCategorias();
        }

        // Evento do form que ocorre quando o form é apresentado na primeira vez
        private void CategoriaForm_Shown(object sender, EventArgs e)
        {
            // Colocar o cursor piscando no campo do nome para cadastro
            textBoxNome.Focus();
        }

        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        // Ocorre quando é apertado alguma tecla no campo do nome 
        private void textBoxNome_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificando se a tecla utilizada é o enter
            if (e.KeyCode == Keys.Enter)
            {
                CriarCategoria();
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            AlterarCategoria();
        }

        private void AlterarCategoria()
        {
            // Obter o nome e código da categoria que será atualizada
            int codigoParaAlterar = Convert.ToInt32(textBoxCodigoParaAlterar.Text);
            string nome = textBoxNomeParaAlterar.Text;

            // Instanciar um objeto para abrir a conexão com o Banco de Dados
            SqlConnection conexao = new SqlConnection();
            // Definir a ConnectionString (onde o bd se encontra)
            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\franc\\Desktop\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";
            // Abrir a conexão com o Banco de Dados
            conexao.Open();
            // Criar o objeto que será utilizado para definir o comando que será executado
            SqlCommand comando = conexao.CreateCommand();
            // Definir o comando que será executado
            comando.CommandText = "UPDATE categorias SET nome = '" + nome + "' WHERE id = " + codigoParaAlterar;
            // Executar o comando para atualizar a categoria
            int quantidadeAlterada = comando.ExecuteNonQuery();

            // Verificar que não foi alterado a categoria
            if (quantidadeAlterada == 0)
            {
                // Apresentar feedback que nenhum registro foi atualizado
                MessageBox.Show("Não existe categoria com o código " + codigoParaAlterar);
                textBoxCodigoApagar.Focus();
                return;
            }

            // Limpar campos de atualização
            textBoxCodigoParaAlterar.Clear();
            textBoxNomeParaAlterar.Clear();
            // Apresentar feedback que o registro foi atualizado
            MessageBox.Show("Categoria atualizada com sucesso");
            // Atualizar lista de categorias
            ListarCategorias();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
