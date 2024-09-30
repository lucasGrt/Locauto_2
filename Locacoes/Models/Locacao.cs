using System.ComponentModel;

namespace Locacoes.Models
{
    public class Locacao
    {
        public int Id { get; set; }
        public DateOnly DataLocacao { get; set; }
        public string ValorTotal { get; set; }
        [DisplayName("cliente")]
        public int ClientId { get; set; }
        public Cliente? Cliente { get; set; }

        public List<VeiculoLocado> VeiculoLocadoList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VeiculoLocado>().haskey(vl => new { vl.Locacaoid, vl.VeiculoId })
        }
    }
}
