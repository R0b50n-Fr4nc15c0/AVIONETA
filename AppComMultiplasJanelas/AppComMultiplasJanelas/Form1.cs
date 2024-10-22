using System.ComponentModel;

namespace AppComMultiplasJanelas
{
    public partial class Form1 : Form
    {
        private BindingList<Produto> Produtos = new BindingList<Produto>();
        public Form1()
        {
            InitializeComponent();

            this.dataGridView1.DataSource = Produtos;
        }

        private void ButtonAdicionarProduto_Click(object sender, EventArgs e)
        {
            FormNovoProduto fnp = new FormNovoProduto();
            DialogResult resultado = fnp.ShowDialog();
            if (resultado == DialogResult.OK) 
            {
                //string textoProduto = $"{fnp.Nome}-{fnp.Fabricante}(R${fnp.Pre�oCompra})(R${fnp.Pre�oVenda})";
                //listBoxProdutos.Items.Add(textoProduto);

                Produto produto = new Produto();

                if (Produtos.Count == 0) produto.Id = 1;
                else produto.Id = Produtos.Max(x => x.Id) + 1;

                produto.Nome = fnp.Nome;
                produto.Fabricante = fnp.Fabricante;
                produto.Pre�oVenda = fnp.Pre�oVenda;
                produto.Pre�oCompra = fnp.Pre�oCompra;

                Produtos.Add(produto);
            }
        }   
               


            

        private void ButtonDeletarProduto_Click(object sender, EventArgs e)
        {
            //if (listBoxProdutos.Items.Count > 0) 
            //{
            //    if (listBoxProdutos.SelectedIndex >= 0)
            //    { listBoxProdutos.Items.RemoveAt(listBoxProdutos.SelectedIndex); }
            //}

            if (dataGridView1.DataSource == Produtos)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }
    }
}
