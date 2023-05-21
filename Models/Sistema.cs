using System.ComponentModel.DataAnnotations;

namespace Clientes.Models
{
    public class Sistema
    {
        [Key]

        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El nombre del sistema es obligatorio")]

        public string Nombres { get; set; } = "";

        public int Telefono { get; set; }

        public int Celular { get; set; }
       
        public int Rnc { get; set; }

        public string? Email { get; set; }

        public string? Direccion { get; set; }
    }
}
