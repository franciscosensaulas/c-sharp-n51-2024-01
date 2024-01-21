using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermercadoForm
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
    }
}
