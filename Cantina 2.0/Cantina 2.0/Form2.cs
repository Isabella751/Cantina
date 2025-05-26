using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_2._0
{
    public partial class Balcao : Form
    {
        private Form1 formPrincipal;

        public Balcao(Form1 form)
        {
            InitializeComponent();
            formPrincipal = form;
        }

        private void listPedidosBal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
