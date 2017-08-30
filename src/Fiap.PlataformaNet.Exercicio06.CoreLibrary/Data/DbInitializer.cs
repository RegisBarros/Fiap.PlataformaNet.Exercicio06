using Fiap.PlataformaNet.Exercicio06.CoreLibrary.Models;
using System;
using System.Linq;

namespace Fiap.PlataformaNet.Exercicio06.CoreLibrary.Data
{
    public static class DbInitializer
    {
        public static void Initialize(VendasContext context)
        {
            context.Database.EnsureCreated();

            if (context.Pedidos.Any()) // existem registros
                return;

            var clientes = new Cliente[]
            {
                Cliente.Criar("83167303085", "Mariana Ribeiro", "11963358021", "mari@gmail.com", "F"),
                Cliente.Criar("53173476026", "Roberto Lima de Oliveira", "11978456320", "roberto.lima@outlook.com", "M"),
                Cliente.Criar("19294543099", "Anderson José da Silva", "11989875898", "andi897@outlook.com", "M"),
                Cliente.Criar("43937173099", "Bruno Silvestri", "1158693256", "silvestri@gmail.com", "M"),
                Cliente.Criar("19585866099", "Juliano Bestrik", "11978456987", "juli78@gmail.com", "M"),
                Cliente.Criar("77927246038", "Rafaela Totti", "11978454578", "rafatotti@gmail.com", "F"),
            };

            var produtos = new Produto[]
            {
                Produto.Criar(1, "IPhone 7S 64 12Gb", 50, DateTime.Now.AddYears(10), 3500M),
                Produto.Criar(2, "Smart TV LED 32/", 5, DateTime.Now.AddYears(5), 1999M),
                Produto.Criar(3, "Apple Watch Series 1 Aluminio 8GB - Preto", 69, DateTime.Now.AddYears(15), 2349.90M),
                Produto.Criar(4, "Camiseta Under Armour Masculina", 150, DateTime.Now.AddYears(3), 62.91M),
                Produto.Criar(5, "Notebook Dell Inspiron 7000 I7 16GB", 6999, DateTime.Now.AddYears(7), 3569.99M),
                Produto.Criar(6, "Jogo Injustice 2 - PS4", 100, DateTime.Now.AddYears(4), 175.91M),
                Produto.Criar(7, "Console Playstation 4 1TB", 2, DateTime.Now.AddYears(15), 1500M),
                Produto.Criar(8, "Console Xbox One S 500GB", 7, DateTime.Now.AddYears(7), 1200.90M),
                Produto.Criar(9, "Cafeteira Expresso Três Corações 15 Bar", 1, DateTime.Now.AddYears(4), 249.90M),
                Produto.Criar(10, "Smarphone Samsung Galaxy S7", 3, DateTime.Now.AddYears(5), 1979.10M),
            };
           

            var pedidos = new Pedido[]
            {
                Pedido.Criar(1, "83167303085", DateTime.Parse("07-07-2017")),
                Pedido.Criar(7, "83167303085", DateTime.Parse("08-08-2017")),
                Pedido.Criar(8, "83167303085", DateTime.Parse("15-08-2017")),
                Pedido.Criar(9, "83167303085", DateTime.Parse("20-08-2017")),

                Pedido.Criar(2, "53173476026", DateTime.Parse("01-03-2016")),
                Pedido.Criar(10, "53173476026", DateTime.Parse("01-02-2017")),

                Pedido.Criar(3, "19294543099", DateTime.Parse("31-05-2017")),

                Pedido.Criar(4, "43937173099", DateTime.Parse("11-09-2016")),
                Pedido.Criar(11, "43937173099", DateTime.Parse("01-02-2017")),
                Pedido.Criar(12, "43937173099", DateTime.Parse("10-03-2017")),

                Pedido.Criar(5, "19585866099", DateTime.Parse("20-08-2017")),
                Pedido.Criar(13, "19585866099", DateTime.Parse("27-08-2017")),

                Pedido.Criar(6, "77927246038", DateTime.Parse("01-04-2017")),
                Pedido.Criar(14, "77927246038", DateTime.Parse("05-06-2017")),
                Pedido.Criar(15, "77927246038", DateTime.Parse("10-06-2017")),
                Pedido.Criar(16, "77927246038", DateTime.Parse("20-07-2017"))
            };

            var items = new Item[]
            {
                Item.Criar(1, 1, 2, 7000M),
                Item.Criar(1, 10, 1, 1979.10M),
                Item.Criar(1, 9, 3, 749.7M),
                Item.Criar(2, 2, 1, 1999M),
                Item.Criar(3, 4, 10, 629.1M),
                Item.Criar(3, 10, 1, 1979.10M),
                Item.Criar(3, 5, 1, 3569.99M),
                Item.Criar(3, 1, 1, 3500M),
                Item.Criar(4, 3, 1, 2349.90M),
                Item.Criar(5, 9, 2, 499.8M),
                Item.Criar(5, 7, 5, 7500M),
                Item.Criar(5, 2, 1, 1999M),
                Item.Criar(6, 8, 1, 1200.90M),
                Item.Criar(6, 6, 1, 175.91M),
                Item.Criar(7, 6, 1, 175.91M),
                Item.Criar(8, 4, 10, 629.1M),
                Item.Criar(9, 3, 1, 2349.90M),
                Item.Criar(10, 7, 5, 7500M),
                Item.Criar(11, 8, 1, 1200.90M),
                Item.Criar(12, 1, 2, 7000M),
                Item.Criar(13, 9, 3, 749.7M),
                Item.Criar(14, 9, 3, 749.7M),
                Item.Criar(15, 1, 1, 3500M),
                Item.Criar(16, 8, 1, 1200.90M)
            };

            context.Clientes.AddRange(clientes);
            context.SaveChanges();

            context.Produtos.AddRange(produtos);
            context.SaveChanges();

            context.Pedidos.AddRange(pedidos);
            context.SaveChanges();

            context.Items.AddRange(items);
            context.SaveChanges();
        }
    }
}
