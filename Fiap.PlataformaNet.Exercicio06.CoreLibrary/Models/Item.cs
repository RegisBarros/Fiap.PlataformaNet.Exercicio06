using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.PlataformaNet.Exercicio06.CoreLibrary.Models
{
    class Item
    {
        public int ItemId { get; set; }

        public int PedidoId { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        public decimal Valor { get; set; }
    }
}
