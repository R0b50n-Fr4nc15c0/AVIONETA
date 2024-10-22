using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppComMultiplasJanelas
{
    internal class Produto
    {
        [DisplayName("Id")]public int Id { get; set; }
        [DisplayName("Produto")]public string Nome { get; set; }
        [DisplayName("Nome do fabricante")]public string Fabricante { get; set; }
        [DisplayName("Preço de compra")]public decimal PreçoCompra { get; set; }
        [DisplayName("Preço de venda")]public decimal PreçoVenda { get; set; }
    }
}
