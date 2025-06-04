using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_2._0
{
    internal class PersistenciaPedido
    {

        public class Pedido
        {
            public string NomeCliente { get; set; }
            public List<Produto> Itens { get; set; }
            public string FormaPagamento { get; set; }
            public double Total { get; set; }
            public double? Troco { get; set; }
            public bool ParaViagem { get; set; }
            public DateTime DataHora { get; set; }

            public override string ToString()
            {
                string resumo = $"Nome do cliente: {NomeCliente}\n";
                resumo += "Itens do pedido:\n";

                foreach (var item in Itens)
                {
                    resumo += $"- {item.Quantidade}x {item.Nome} = R${item.Preco:F2}\n";
                }

                resumo += $"\nTotal: R${Total:F2}\n";
                resumo += $"Forma de pagamento: {FormaPagamento}\n";

                if (Troco.HasValue)
                    resumo += $"Troco: R${Troco.Value:F2}\n";

                resumo += $"Pedido para {(ParaViagem ? "viagem" : "comer no local")}\n";
                resumo += $"Data e Hora: {DataHora:dd/MM/yyyy HH:mm:ss}\n";

                return resumo;
            }

            public string ResumoCompacto()
            {
                string outroresumo = $"Cliente: {NomeCliente} - Itens: ";

                foreach (var item in Itens)
                {
                    outroresumo += $" {item.Quantidade}x {item.Nome}, ";
                }

                if (outroresumo.EndsWith(", "))
                {
                    outroresumo = outroresumo.Substring(0, outroresumo.Length - 2);
                }

                return outroresumo;
            }

        }

        public class GerenciadorPedidos
        {
            private static GerenciadorPedidos _instancia;
            private List<Pedido> _pedidos;
            private GerenciadorPedidos()
            {
                _pedidos = new List<Pedido>();
            }
            public static GerenciadorPedidos Instancia
            {
                get
                {
                    if (_instancia == null)
                    {
                        _instancia = new GerenciadorPedidos();
                    }
                    return _instancia;
                }
            }
            public void AdicionarPedido(Pedido pedido)
            {
                _pedidos.Add(pedido);
                PedidoAdicionado?.Invoke(this, pedido);
            }
            public List<Pedido> ObterPedidos()
            {
                return _pedidos;
            }
            public event EventHandler<Pedido> PedidoAdicionado;
        }
    }
}
