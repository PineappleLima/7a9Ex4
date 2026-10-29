
using System;
using System.Windows.Forms;

namespace _7a9Ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string categoria = txtCategoria.Text;
            double preco = 0;
            int quantidade = 0;

            if (!double.TryParse(txtPreco.Text, out preco) || preco < 0)
            {
                MessageBox.Show("Por favor, introduza um preço válido.");
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out quantidade) || quantidade < 0)
            {
                MessageBox.Show("Por favor, introduza uma quantidade válida.");
                return;
            }

            Produto p = new Produto(
                nome,
                categoria,
                preco,
                quantidade,
                chkDisponivel.Checked
            );

            lblOutput.Text = p.ExibirProduto();

            if (!p.Disponivel)
            {
                picProduto.Image = Properties.Resources.Indisponivel;
            }
            else if (p.Quantidade < 3)
            {
                picProduto.Image = Properties.Resources.stockBaixo;
            }
            else
            {
                picProduto.Image = Properties.Resources.Disponivel;
            }

            picProduto.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
