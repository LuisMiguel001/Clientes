using System.ComponentModel.DataAnnotations;

namespace Clientes.Models
{
    public class Sistema
    {
        [Key]

        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El nombre es un campo obligatorio")]
        public string Nombres { get; set; } = "";

		[StringLength(12)]
		public string? Telefono { get; set; }

        [StringLength(12)]
        public string? Celular { get; set; }

        [StringLength(13)]
		[Required(ErrorMessage = "El Rnc es un campo obligatorio")]
        public string? Rnc { get; set; }

        public string? Email { get; set; }

        public string? Direccion { get; set; }
    }
}
