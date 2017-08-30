using Fiap.PlataformaNet.Exercicio06.CoreLibrary.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Fiap.PlataformaNet.Exercicio06.AppCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VendasContext();
            DbInitializer.Initialize(context);

            var pedidos = context.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Items)
                .Include("Items.Produto")
                .ToList();

            Console.WriteLine("Lista de Pedidos:\n");
            Console.WriteLine("".PadRight(100, '='));
            foreach (var p in pedidos)
            {
                Console.WriteLine($"Pedido: {p.PedidoId} - Data: {p.Data:d} - Cliente: {p.Cliente.Nome} - E-Mail: {p.Cliente.Email}\n");

                Console.WriteLine("Itens:");

                foreach (var item in p.Items)
                {
                    Console.WriteLine($"{item.Produto.Descricao} - Quantidade: {item.Quantidade} - Valor: {item.Valor:c}");
                }


                Console.WriteLine("".PadRight(100, '='));
            }

            Console.ReadKey();
        }

    }
}