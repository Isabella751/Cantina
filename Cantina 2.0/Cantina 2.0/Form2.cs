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
        //private Carrinho carrinho;
        public Balcao()
        {
            InitializeComponent();
        }

        private void listPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int index = listBox2.SelectedIndex;

            if (index >= 0)
            {
                var todosPedidos = PedidoRepository.ObterTodos();
                var pedidoSelecionado = todosPedidos[index];

                MessageBox.Show(pedidoSelecionado.ToString(), "Detalhes do Pedido");*/
            }
        }
    }

