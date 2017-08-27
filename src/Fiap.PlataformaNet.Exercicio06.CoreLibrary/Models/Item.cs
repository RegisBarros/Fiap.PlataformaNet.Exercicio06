namespace Fiap.PlataformaNet.Exercicio06.CoreLibrary.Models
{
    public class Item
    {
        public int ItemId { get; set; }

        public int PedidoId { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        public decimal Valor { get; set; }

        public static Item Criar(int pedidoId, int produtoId, int quantidade, decimal valor)
        {
            return new Item()
            {
                PedidoId = pedidoId,
                ProdutoId = produtoId,
                Quantidade = quantidade,
                Valor = valor
            };
        }
    }
}
