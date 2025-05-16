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
            listBox1.Items.Add(new Produto { Nome = "Pão de Queijo - R$3,50", Preco = 3.50 });
            listBox1.Items.Add(new Produto { Nome = "Coxinha - R$5,00", Preco = 5.00 });
            listBox1.Items.Add(new Produto { Nome = "Pastel de Carne - R$6,00", Preco = 6.00 });
            listBox1.Items.Add(new Produto { Nome = "Pastel de Queijo - R$5,50", Preco = 5.50 });
            listBox1.Items.Add(new Produto { Nome = "Suco Natural (300mL) - R$4,00", Preco = 4.00 });
            listBox1.Items.Add(new Produto { Nome = "Refrigerante Lata - R$4,50", Preco = 4.50 });
            listBox1.Items.Add(new Produto { Nome = "Hambúrguer Simples - R$8,00", Preco = 8.00 });
            listBox1.Items.Add(new Produto { Nome = "Hambúrguer com Queijo - R$9,00", Preco = 9.00 });
            listBox1.Items.Add(new Produto { Nome = "X-Tudo - R$12,00", Preco = 12.00 });
            listBox1.Items.Add(new Produto { Nome = "Água Mineral (500mL) - R$2,50", Preco = 2.50 });


            btnQuantidade.Minimum = 1;
            btnQuantidade.Value = 1;
        }

        public class Produto
        {
            public string Nome { get; set; }
            public double Preco { get; set; }
            public int Quantidade { get; set; }
        }

        public class Carrinho
        {
            private List<Produto> itens = new List<Produto>();

            public void Adicionar(Produto produto) => itens.Add(produto);
            public void Remover(Produto produto) => itens.Remove(produto);

            public double Total() => itens.Sum(p => p.Preco);
            public List<Produto> Listar() => new List<Produto>(itens);
            public void Limpar() => itens.Clear();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Produto produto)
            {
                int quantidade = (int)btnQuantidade.Value;

                var novoProduto = new Produto
                {
                    Nome = produto.Nome,
                    Preco = produto.Preco,
                    Quantidade = quantidade
                };
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

        private void numericQuantidade_Click(object sender, EventArgs e)
        {

        }
    }
}
