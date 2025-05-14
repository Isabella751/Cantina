using System.Drawing.Text;
using static Cantina_2._0.Form1;

namespace Cantina_2._0
{
    public partial class Form1 : Form
    {

        private List<Produto> produtos;
        private Carrinho carrinho;
        public Form1()
        {
            InitializeComponent();
            carrinho = new Carrinho();
            listBox1.DataSource = produtos;
            listBox1.DisplayMember = "Nome";
            listBox1.ValueMember = "Preco";
            listBox2.DisplayMember = "Nome";
            listBox2.ValueMember = "Preco";
            listBox1.Items.Add(new Produto { Nome = "Mini Pizza", Preco = 23 });
            listBox1.Items.Add(new Produto { Nome = "Pastel", Preco = 10 });
            listBox1.Items.Add(new Produto { Nome = "Fogazza", Preco = 5 });
            listBox1.Items.Add(new Produto { Nome = "Bolo de Pote", Preco = 8 });
            listBox1.Items.Add(new Produto { Nome = "Churros", Preco = 6 });
            listBox1.Items.Add(new Produto { Nome = "Milk Shake", Preco = 12 });
            listBox1.Items.Add(new Produto { Nome = "Suco Natural", Preco = 8 });
            listBox1.Items.Add(new Produto { Nome = "Refrigerante", Preco = 7 });

        }

        public class Produto
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }
        }

        public class Carrinho
        {
            private List<Produto> itens = new List<Produto>();

            public void Adicionar(Produto produto) => itens.Add(produto);
            public void Remover(Produto produto) => itens.Remove(produto);

            public decimal Total() => itens.Sum(p => p.Preco);
            public List<Produto> Listar() => new List<Produto>(itens);
            public void Limpar() => itens.Clear();
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Produto produto)
            {
                carrinho.Adicionar(produto);
                listBox2.Items.Add(produto);
                AtualizarTotal();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem is Produto produto)
            {
                carrinho.Remover(produto);
                listBox2.Items.Remove(produto);
                AtualizarTotal();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total do pedido: R$ {carrinho.Total():F2}", "Pedido Finalizado");
            carrinho.Limpar();
            listBox2.Items.Clear();
            AtualizarTotal();
        }
        private void AtualizarTotal()
        {
            lblTotal.Text = $"Total: R${carrinho.Total():F2}";
        }
    }
}
