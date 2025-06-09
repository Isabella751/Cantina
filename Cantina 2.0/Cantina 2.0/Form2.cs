using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cantina_2._0.PersistenciaPedido;

namespace Cantina_2._0
{
    public partial class Balcao : Form
    {
        private HashSet<int> hashPedidosEntregues = new HashSet<int>();
        private readonly string arquivoPedidosEntregues = "pedidos_entregues.json";

        public Balcao()
        {
            InitializeComponent();
            listPedidos.DisplayMember = ("outroresumo");
            listEntregues.DisplayMember = ("outroresumo");

            CarregarPedidosEntregues();
            GerenciadorPedidos.Instancia.PedidoAdicionado += GerenciadorPedidos_PedidoAdicionado;
            AtualizarListaPedidos();
        }

        private void CarregarPedidosEntregues()
        {
            try
            {
                if (File.Exists(arquivoPedidosEntregues))
                {
                    string json = File.ReadAllText(arquivoPedidosEntregues);
                    var hashes = JsonSerializer.Deserialize<List<int>>(json);
                    hashPedidosEntregues = new HashSet<int>(hashes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar pedidos entregues: {ex.Message}");
            }
        }

        private void SalvarPedidosEntregues()
        {
            try
            {
                string json = JsonSerializer.Serialize(hashPedidosEntregues.ToList());
                File.WriteAllText(arquivoPedidosEntregues, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar pedidos entregues: {ex.Message}");
            }
        }

        private bool PedidoJaFoiEntregue(Pedido pedido)
        {
            return hashPedidosEntregues.Contains(pedido.GetHashCode());
        }

        private void GerenciadorPedidos_PedidoAdicionado(object sender, Pedido pedido)
        {
            if (!PedidoJaFoiEntregue(pedido))
            {
                listPedidos.Items.Add(pedido);
            }
        }

        private void AtualizarListaPedidos()
        {
            listPedidos.Items.Clear();
            listEntregues.Items.Clear();

            foreach (var pedido in GerenciadorPedidos.Instancia.ObterPedidos())
            {
                if (PedidoJaFoiEntregue(pedido))
                {
                    listEntregues.Items.Add(pedido);
                }
                else
                {
                    listPedidos.Items.Add(pedido);
                }
            }
        }

        private void listPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (listPedidos.SelectedItem != null)
            {
                Pedido pedidoSelecionado = (Pedido)listPedidos.SelectedItem;

                hashPedidosEntregues.Add(pedidoSelecionado.GetHashCode());

                listEntregues.Items.Add(pedidoSelecionado);
                listPedidos.Items.Remove(pedidoSelecionado);

                SalvarPedidosEntregues();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            SalvarPedidosEntregues();
            base.OnFormClosed(e);
        }
    }
}
