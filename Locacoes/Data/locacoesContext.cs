using Locacoes.Models;
using Microsoft.EntityFrameworkCore;

namespace Locacoes.Data
{
    public class locacoesContext : DbContext
    {
        public locacoesContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Veiculo> Veiculos { get; set;}
        public DbSet<Locacao> Locacoes { get; set; }

    }
}
