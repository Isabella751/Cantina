using System.Drawing.Text;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using static Cantina_2._0.Form1;
using static Cantina_2._0.PersistenciaPedido;

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
            produtos = new List<Produto>();
            listBox1.DisplayMember = "Nome";
            listBox1.ValueMember = "Preco";

            listBox1.Items.Add(new Produto { Nome = "Pão de Queijo (3,50)", Preco = 3.50 });
            listBox1.Items.Add(new Produto { Nome = "Coxinha (5,00)", Preco = 5.00 });
            listBox1.Items.Add(new Produto { Nome = "Pastel de Carne (6,00)", Preco = 6.00 });
            listBox1.Items.Add(new Produto { Nome = "Pastel de Queijo (5,50)", Preco = 5.50 });
            listBox1.Items.Add(new Produto { Nome = "Suco Natural (300mL) (4,00)", Preco = 4.00 });
            listBox1.Items.Add(new Produto { Nome = "Refrigerante Lata (4,50)", Preco = 4.50 });
            listBox1.Items.Add(new Produto { Nome = "Hambúrguer Simples (8,00)", Preco = 8.00 });
            listBox1.Items.Add(new Produto { Nome = "Hambúrguer com Queijo (9,00)", Preco = 9.00 });
            listBox1.Items.Add(new Produto { Nome = "X-Tudo (12,00)", Preco = 12.00 });
            listBox1.Items.Add(new Produto { Nome = "Água Mineral (500mL) (2,50)", Preco = 2.50 });

            btnQuantidade.Minimum = 1;
            btnQuantidade.Maximum = 10;

            Form1_Load(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox.Items.Add(new Pagamento { FormaPagamento = "Dinheiro" });
            comboBox.Items.Add(new Pagamento { FormaPagamento = "Cartão de Débito" });
            comboBox.Items.Add(new Pagamento { FormaPagamento = "Cartão de Crédito" });
            comboBox.Items.Add(new Pagamento { FormaPagamento = "PIX" });
            comboBox.Items.Add(new Pagamento { FormaPagamento = "VR" });
            comboBox.Items.Add(new Pagamento { FormaPagamento = "VA" });

            comboBox.DisplayMember = "FormaPagamento";
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            txtBox1.TextChanged += txtBox1_TextChanged;
            //txtViagem.CheckedChanged += txtViagem_CheckedChanged;
        }

        private class Pagamento
        {
            public string FormaPagamento { get; set; }

            public override string ToString()
            {
                return $"{FormaPagamento}";
            }
        }

        private class Escolha
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

        private double CalcularTroco()
        {
            double valorPago = 0;
            if (!double.TryParse(txtBox1.Text, out valorPago))
            {
                MessageBox.Show("Valor pago inválido ou insuficiente para cobrir o total.");
                return 0;
            }

            double totalCompra = carrinho.Total();
            double troco = valorPago - totalCompra;
            return troco;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nomeCliente))
            {
                MessageBox.Show("Por favor, informe o nome do cliente antes de finalizar o pedido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox.SelectedItem is Pagamento pagamentoSelecionado)
            {
                double troco = 0;

                if (pagamentoSelecionado.FormaPagamento == "Dinheiro")
                {
                    if (string.IsNullOrWhiteSpace(txtBox1.Text) || !double.TryParse(txtBox1.Text, out double valorPago))
                    {
                        MessageBox.Show("Por favor, informe um valor válido para o pagamento em dinheiro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    troco = CalcularTroco();

                    if (troco < 0)
                    {
                        MessageBox.Show("Valor insuficiente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    txtBox2.Text = troco.ToString("F2");

                }

                var pedido = new Pedido
                {
                    NomeCliente = nomeCliente,
                    Itens = new List<Produto>(carrinho.Listar()),
                    FormaPagamento = pagamentoSelecionado.FormaPagamento,
                    Total = carrinho.Total(),
                    Troco = pagamentoSelecionado.FormaPagamento == "Dinheiro" ? troco : (double?)null,
                    ParaViagem = txtViagem.Checked,
                    DataHora = DateTime.Now
                };

                // Adiciona o pedido na lista central
                PedidoRepository.AdicionarPedido(pedido);

                // Mostra o resumo
                MessageBox.Show(pedido.ToString(), "Pedido finalizado");



                carrinho.Limpar();
                listBox2.Items.Clear();
                AtualizarTotal();
                comboBox.SelectedIndex = -1;

                lblAviso.Visible = false;
                lblAviso2.Visible = false;
                txtBox1.Visible = false;
                txtBox2.Visible = false;
                txtUsuário.Text = "";
                nomeCliente = "";
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma forma de pagamento!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void AtualizarTotal()
        {
            lblTotal.Text = $"Total: R${carrinho.Total():F2}";
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem is Pagamento pagamentoSelecionado)
            {
                lblAviso.Visible = pagamentoSelecionado.FormaPagamento == "Dinheiro";
                lblAviso2.Visible = pagamentoSelecionado.FormaPagamento == "Dinheiro";
                txtBox1.Visible = pagamentoSelecionado.FormaPagamento == "Dinheiro";
                txtBox2.Visible = pagamentoSelecionado.FormaPagamento == "Dinheiro";
            }
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
            // CalcularTroco();
        }

        private string nomeCliente;

        private void txtUsuário_TextChanged(object sender, EventArgs e)
        {
            nomeCliente = txtUsuário.Text;
        }

        private void btnBalcao_Click(object sender, EventArgs e)
        {
            Balcao minhaNovaJanela = new Balcao();
            minhaNovaJanela.Show();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
