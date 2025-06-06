using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cantina_2._0.PersistenciaPedido;

namespace Cantina_2._0
{
    public partial class Balcao : Form
    {
        public Balcao()
        {
            InitializeComponent();
            listPedidos.DisplayMember = ("outroresumo");

            GerenciadorPedidos.Instancia.PedidoAdicionado += GerenciadorPedidos_PedidoAdicionado;
            AtualizarListaPedidos();
        }
        private void GerenciadorPedidos_PedidoAdicionado(object sender, Pedido pedido)
        {
            listPedidos.Items.Add(pedido);
        }
        private void AtualizarListaPedidos()
        {
            listPedidos.Items.Clear();
            foreach (var pedido in GerenciadorPedidos.Instancia.ObterPedidos())
            {
                listPedidos.Items.Add(pedido);
            }
        }

        private void listPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {

        }
    }
}
