using Microsoft.EntityFrameworkCore;

namespace TP03_Douglas_Lucas.Models.SqlContext
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData
            (
                
                new Produto
                {
                    Id = 1,
                    Nome = "Celular",
                    Categoria = "Eletronico",
                    Descricao = "Celular",
                    Preco = 2000,
                    Unidade = 1
                }

            );
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
