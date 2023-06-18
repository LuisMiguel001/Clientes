using System.ComponentModel.DataAnnotations;

namespace Clientes.Models
{
    public class TicketsDetalle
    {
        [Required(ErrorMessage = "El campo (Id) es obligatorio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo (TicketId) es obligatorio")]
        public int TicktetId { get; set; }

        [Required(ErrorMessage = "El campo (Emisor) es obligatorio")]
        public string Emisor { get; set; } = "";

        [Required(ErrorMessage = "Debe dejar un detalle de mensaje")]
        public string Mensaje { get; set; } = "";
    }
}
