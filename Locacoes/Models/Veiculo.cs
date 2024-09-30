using System.ComponentModel;

namespace Locacoes.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

        public int anoFabricacao { get; set; }

        public string combustivel { get; set; }

        public long kilometragem { get; set; }
        [DisplayName("Modelo")]
        public int ModeloId { get; set; }

        public Modelo? modelo { get; set; }
        
    }
}
