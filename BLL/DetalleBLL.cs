using Clientes.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Clientes.DAL;

namespace Clientes.BLL
{
	public class DetalleBLL
	{
		private readonly DetalleContext _context;

		public DetalleBLL(DetalleContext context)
		{
			_context = context;
		}

		public bool Existe(string Emisor)
		{
			return _context.Detalle.Any(s => s.Emisor == Emisor);
		}

		public bool Insertar(TicketsDetalle detalle)
		{
			_context.Detalle.Add(detalle);
			int cantidad = _context.SaveChanges();
			return cantidad > 0;
		}
		
		public bool Modificar(TicketsDetalle detalle)
		{
			_context.Update(detalle);
			int cantidad = _context.SaveChanges();
			return cantidad > 0;
		}

		public bool Guardar(TicketsDetalle detalle)
		{
			if (!Existe(detalle.Emisor))
				return Insertar(detalle);
			else
				return Modificar(detalle);
		}

		public bool Eliminar(TicketsDetalle detalle)
		{
			_context.Detalle.Remove(detalle);
			int cantidad = _context.SaveChanges();
			return cantidad > 0;
		}

		public TicketsDetalle? Buscar(int Id)
		{
			return _context.Detalle
				.AsNoTracking()
				.FirstOrDefault(s => s.Id == Id);
		}

		public List<TicketsDetalle> GetList(Expression<Func<TicketsDetalle, bool>> Criterio)
		{
			return _context.Detalle
				.Where(Criterio)
				.AsNoTracking()
				.ToList();
		}
	}
}
