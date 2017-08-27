using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.PlataformaNet.Exercicio06.CoreLibrary.Models
{
    public class Produto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProdutoId { get; set; }

        public string Descricao { get; set; }

        public int Unidade { get; set; }

        public DateTime DataValidade { get; set; }

        public decimal Preco { get; set; }

        public static Produto Criar(int id, string descricao, int unidade, DateTime dataValidade, decimal preco)
        {
            return new Produto()
            {
                ProdutoId = id,
                Descricao = descricao,
                Unidade = unidade,
                DataValidade = dataValidade,
                Preco = preco
            };
        }
    }
}
