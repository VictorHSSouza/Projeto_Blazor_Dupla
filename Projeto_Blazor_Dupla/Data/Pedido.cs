using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Blazor_Dupla.Data
{
    public class Pedido
    {
        public int Id { get; set; }

        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }

        [ForeignKey("Remedio")]
        public int IdRemedio { get; set; }

        public DateTime DtPedido { get; set; }
    }
}
