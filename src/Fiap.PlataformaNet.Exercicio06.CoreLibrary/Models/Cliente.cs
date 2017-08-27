using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fiap.PlataformaNet.Exercicio06.CoreLibrary.Models
{
    public class Cliente
    {
        [Key]
        public string Cpf { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Sexo { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

        public static Cliente Criar(string cpf, string nome, string telefone, string email, string sexo)
        {
            return new Cliente()
            {
                Cpf = cpf,
                Nome = nome,
                Telefone = telefone,
                Email = email,
                Sexo = sexo
            };
        }
    }
}
