using Clientes.Models;
using Microsoft.EntityFrameworkCore;

namespace Clientes.DAL
{
	public class DetalleContext : DbContext
	{
		public DetalleContext(DbContextOptions<DetalleContext> Options)
			: base(Options) { }

		public DbSet<TicketsDetalle> Detalle { get; set; }
	}
}
