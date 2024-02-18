namespace SupermercadoForm.Telas
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonCategorias_Click(object sender, EventArgs e)
        {
            // Instanciar um objeto
            CategoriaForm form = new CategoriaForm();
            // Tornar o form visível
            form.ShowDialog();
        }

        private void buttonEstantes_Click(object sender, EventArgs e)
        {
            // Instanciar um objeto do form de estante
            EstanteForm form = new EstanteForm();
            // Tornar o form visível
            form.ShowDialog();
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            var form = new ProdutoListaForm();
            form.ShowDialog();
        }
    }
}
