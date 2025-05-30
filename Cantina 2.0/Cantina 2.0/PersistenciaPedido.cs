using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_2._0
{
    internal class PersistenciaPedido
    {
        public static class PedidoRepository
        {
            // Lista central de pedidos
            private static readonly List<Pedido> pedidos = new List<Pedido>();

            // Adiciona um novo pedido
            public static void AdicionarPedido(Pedido pedido)
            {
                if (pedido != null)
                {
                    pedidos.Add(pedido);
                }
            }

            // Retorna todos os pedidos
            public static List<Pedido> ObterTodos()
            {
                return new List<Pedido>(pedidos); // Retorna uma cópia para segurança
            }

            // Limpa todos os pedidos
            public static void Limpar()
            {
                pedidos.Clear();
            }
        }

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
        }


    }
}
