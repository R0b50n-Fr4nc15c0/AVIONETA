using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComMultiplasJanelas
{
    public partial class FormNovoProduto : Form
    {
        public string Nome { get { return textBoxProduto.Text; } }
        public string Fabricante { get { return textBoxFabricante.Text; } }
        public decimal PreçoCompra { get { return numericUpDownPreçoCompra.Value; } }
        public decimal PreçoVenda { get { return numericUpDownPreçoVenda.Value;  } }
        public FormNovoProduto()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
