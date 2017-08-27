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

            var clientes = context.Clientes
                .Include(p => p.Pedidos)
                .ToList();

            Console.WriteLine("Pedidos por Clientes:\n");
            foreach (var c in clientes)
            {
                Console.WriteLine($"CPF: {c.Cpf} - Nome: {c.Nome} - E-Mail: {c.Email} - Telefone: {c.Telefone} - Sexo: {c.Sexo}");

                Console.WriteLine("\nPedidos:");
                foreach (var p in c.Pedidos)
                {
                    Console.WriteLine($"Número: {p.PedidoId} - Data: {p.Data:d}");
                }

                Console.WriteLine("".PadRight(100, '='));
            }

            Console.ReadKey();
        }
    }
}