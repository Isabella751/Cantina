using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_2._0
{
    public class Extrato
    {
        public void GerarExtrato(Form1 form)
        {
            string dataHoraPedido = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string mensagem = $"Data e Hora: {dataHoraPedido}";
            string viagemInfo = form.txtViagem.Checked ? "Pedido para viagem." : "Pedido para consumo no local.";

            string listaPedidos = "";
            foreach (var item in form.listBox2.Items)
            {
                listaPedidos += item.ToString() + "\n";
            }

            string mensagemFinal = $"           ***Extrato da compra***\n" +
                                   $"Cliente: {form.nomeCliente}\n" +
                                   $"{listaPedidos}" +
                                   $"Totalsssssss do pedido: R$ {form.carrinho.Total():F2}\n" +
                                   $"Forma de pagamento: {form.pagamentoSelecionado.FormaPagamento}\n" +
                                   (form.pagamentoSelecionado.FormaPagamento == "Dinheiro" ? $"Troco: R${form.troco:F2}\n" : "") +
                                   $"{mensagem}\n" +
                                   $"{viagemInfo}";

            MessageBox.Show(mensagemFinal, "Pedido Finalizado");
        }
    }
}

