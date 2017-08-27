using Fiap.PlataformaNet.Exercicio06.CoreLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.PlataformaNet.Exercicio06.CoreLibrary.Data
{
    public class VendasContext : DbContext
    {
        public VendasContext() : base(new DbContextOptionsBuilder<VendasContext>()
            .UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database=DbVendas;Trusted_Connection=True;MultipleActiveResultSets=true").Options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("TBClientes");
            modelBuilder.Entity<Item>().ToTable("TBItems");
            modelBuilder.Entity<Pedido>().ToTable("TBPedidos");
            modelBuilder.Entity<Produto>().ToTable("TBProdutos");
        }
    }
}
