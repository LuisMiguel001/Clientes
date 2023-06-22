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
    }
}
