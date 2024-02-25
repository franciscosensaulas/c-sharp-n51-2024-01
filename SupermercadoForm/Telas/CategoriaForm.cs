using SupermercadoRepositorios.Entidades;
using SupermercadoRepositorios.Repositorios;

namespace SupermercadoForm.Telas
{
    public partial class CategoriaForm : Form
    {
        private ICategoriaRepositorio repositorio;

        public CategoriaForm()
        {
            InitializeComponent();
            // Instanciando um objeto da classe CategoriaRepositorio
            repositorio = new CategoriaRepositorio();
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

            var categoria = new Categoria();
            categoria.Nome = nomeCategoria;

            repositorio.Cadastrar(categoria);

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
            // Limpar campo que contém as categorias
            richTextBoxCategorias.Clear();

            var categorias = repositorio.ObterTodos();

            // Percorrer cada um dos registros da consutla na tabela de categorias
            for (int i = 0; i < categorias.Count; i++)
            {
                // Obter o id e nome do registro percorrido
                var categoria = categorias[i];
                // Adicionar no campo das categorias o registro percorrido
                richTextBoxCategorias.AppendText("Cod: " + categoria.Id + " => " + categoria.Nome + "\n");
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

            repositorio.Apagar(codigoInformado);

            // Verificar que nenhum registro foi apagado
            /*
             * if (quantidadeRegistrosApagados == 0)
            {
                // Apresentar feedback que nenhum registro foi apagado
                MessageBox.Show("Não existe categoria com o código " + codigoInformado);
                textBoxCodigoApagar.Focus();
                return;
            }
            */

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

            var categoria = repositorio.ObterPorId(codigoParaAlterar);
            categoria.Nome = nome;

            repositorio.Atualizar(categoria);

            /*
            // Verificar que não foi alterado a categoria
            if (quantidadeAlterada == 0)
            {
                // Apresentar feedback que nenhum registro foi atualizado
                MessageBox.Show("Não existe categoria com o código " + codigoParaAlterar);
                textBoxCodigoApagar.Focus();
                return;
            }
            */

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
