using System.ComponentModel.DataAnnotations;

namespace Clientes.Models
{
	public class ClientesSistemas
	{
		[Key]

		public int Id { get; set; }

        public int ClienteId { get; set; }

        public int SistemaId { get; set; }

        public int TerminalesPermitidas { get; set; }

		[Required(ErrorMessage = "El campo (Emisor) es obligatorio")]
		public string Emisor { get; set; } = "";

		[Required(ErrorMessage = "Debe dejar un detalle de mensaje")]
		public string Mensaje { get; set; } = "";
	}
}
