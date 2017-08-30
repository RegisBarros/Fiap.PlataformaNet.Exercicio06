using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.PlataformaNet.Exercicio06.CoreLibrary.Models
{
    public class Pedido
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PedidoId { get; set; }

        public string Cpf { get; set; }

        public DateTime Data { get; set; }

        public Cliente Cliente { get; set; }

        public ICollection<Item> Items { get; set; }

        public static Pedido Criar(int id, string cpf, DateTime data)
        {
            return new Pedido()
            {
                PedidoId = id,
                Cpf = cpf,
                Data = data
            };
        }
    }
}
