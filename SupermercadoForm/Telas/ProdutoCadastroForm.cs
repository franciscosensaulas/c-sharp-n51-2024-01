using SupermercadoForm.Entidades;
using SupermercadoForm.Repositorios;

namespace SupermercadoForm.Telas
{
    public partial class ProdutoCadastroForm : Form
    {
        public ProdutoCadastroForm()
        {
            InitializeComponent();
            PreencherDadosCategorias();
        }

        private void PreencherDadosCategorias()
        {
            // Instanciado um objeto do CategoriaRepositorio, para obtermos a lista de categorias,
            // para permitir o usuário escolher a categoria desejada no ComboBox da Categoria
            var categoriaRepositorio = new CategoriaRepositorio();
            // Obter a lista de categorias (SELECT no BD)
            var categorias = categoriaRepositorio.ObterTodos();
            // Percorrer cada uma das categorias obtidas na consulta (SELECT), adicionando no ComboBox da Categoria
            for (int i = 0; i < categorias.Count; i++)
            {
                // Categoria percorrida
                var categoria = categorias[i];
                // Adicionar a categoria percorrida no ComboBox da Categoria
                comboBoxCategoria.Items.Add(categoria);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter a Categoria Selecionada
            var categoria = (Categoria)comboBoxCategoria.SelectedItem;
            
            var nome = textBoxNome.Text;
            var precoUnitario = Convert.ToDecimal(textBoxPrecoUnitario.Text);
            var idCategoria = categoria.Id;

            var repositorio = new ProdutoRepositorio();
            repositorio.Cadastrar(nome, idCategoria, precoUnitario);
            MessageBox.Show("Produto cadastrado com sucesso");
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
