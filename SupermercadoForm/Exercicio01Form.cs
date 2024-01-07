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
    public partial class Exercicio01Form : Form
    {
        public Exercicio01Form()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double nota1 = 0;
            try
            {
                nota1 = Convert.ToDouble(textBoxNota1.Text);
                if(nota1 < 0 || nota1 > 10)
                {
                    MessageBox.Show("Nota 1 deve ser entre 0 e 10");
                    textBoxNota1.Focus();
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nota 1 deve conter número real");
                textBoxNota1.Focus();
                return;
            }

            double nota2 = 0;
            try
            {
                nota2 = Convert.ToDouble(textBoxNota2.Text);
                if (nota2 < 0 || nota2 > 10)
                {
                    MessageBox.Show("Nota 2 deve ser entre 0 e 10");
                    textBoxNota2.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nota 2 deve conter número real");
                textBoxNota2.Focus();
                return;
            }

            double nota3 = 0;
            try
            {
                nota3 = Convert.ToDouble(textBoxNota3.Text);
                if (nota3 < 0 || nota3 > 10)
                {
                    MessageBox.Show("Nota 3 deve ser entre 0 e 10");
                    textBoxNota3.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nota 3 deve conter número real");
                textBoxNota3.Focus();
                return;
            }

            double media = (nota1 + nota2 + nota3) / 3;
            MessageBox.Show("Média: " + media);
        }
    }
}
