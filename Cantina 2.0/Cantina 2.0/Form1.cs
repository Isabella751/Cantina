using System.Drawing.Text;
using System.Reflection.Metadata.Ecma335;
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

            listBox1.Items.Add(new Produto { Nome = "Pão de Queijo", Preco = 3.50 });
            listBox1.Items.Add(new Produto { Nome = "Coxinha", Preco = 5.00 });
            listBox1.Items.Add(new Produto { Nome = "Pastel de Carne", Preco = 6.00 });
            listBox1.Items.Add(new Produto { Nome = "Pastel de Queijo", Preco = 5.50 });
            listBox1.Items.Add(new Produto { Nome = "Suco Natural (300mL)", Preco = 4.00 });
            listBox1.Items.Add(new Produto { Nome = "Refrigerante Lata", Preco = 4.50 });
            listBox1.Items.Add(new Produto { Nome = "Hambúrguer Simples", Preco = 8.00 });
            listBox1.Items.Add(new Produto { Nome = "Hambúrguer com Queijo", Preco = 9.00 });
            listBox1.Items.Add(new Produto { Nome = "X-Tudo", Preco = 12.00 });
            listBox1.Items.Add(new Produto { Nome = "Água Mineral (500mL)", Preco = 2.50 });

            btnQuantidade.Minimum = 1;
            btnQuantidade.Maximum = 10;
            
            
        }

        internal class Pagamento
        {
            public string FormaPagamento { get; set; }

            public override string ToString()
            {
                return $"{FormaPagamento}";
            }
        }

        internal class Escolha
        {
            private List<Pagamento> itens = new List<Pagamento>();

            public void AdicionarPagamento(Pagamento pagamento)
            {
                itens.Add(pagamento);
            }
            

            public List<Pagamento> ObterPagamentos()
            {
                return itens;
            }

            
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

        public class Produto
        {
            public string Nome { get; set; }
            public double Preco { get; set; }
            public int Quantidade { get; set; }
            public double total => Preco * Quantidade;
            public override string ToString()
            {
                return $"{Quantidade}x - {Nome} - R${Preco:F2}";
            }

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Produto produtoSelecionado)
            {
                int quantidade = (int)btnQuantidade.Value;

                var novoProduto = new Produto
                {
                    Nome = produtoSelecionado.Nome,
                    Preco = produtoSelecionado.Preco * quantidade,
                    Quantidade = quantidade
                };

                carrinho.Adicionar(novoProduto);
                listBox2.Items.Add(novoProduto);
                AtualizarTotal();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem is Produto produtoSelecionado)
            {
                var produtoCarrinho = carrinho.Listar()
                    .FirstOrDefault(p => p.Nome == produtoSelecionado.Nome &&
                                       p.Quantidade == produtoSelecionado.Quantidade);

                if (produtoCarrinho != null)
                {
                    carrinho.Remover(produtoCarrinho);
                    listBox2.Items.Remove(produtoSelecionado);
                    AtualizarTotal();
                }
                else
                {
                    MessageBox.Show("Selecione um produto para remover!");
                }
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
