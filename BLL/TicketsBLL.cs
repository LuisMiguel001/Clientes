using Clientes.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Clientes.DAL;

namespace Clientes.BLL
{
    public class TicketsBLL
    {
        private readonly TicketsContext _context;

        public TicketsBLL(TicketsContext context)
        {
            _context = context;
        }

        public bool Existe(int TicketId)
        {
            return _context.Sistemas.Any(S => S.TicketId == TicketId);
        }

        public bool Insertar(Tickest Ticket)
        {
            _context.Sistemas.Add(Ticket);
            int cantidad = _context.SaveChanges();
            return cantidad > 0;
        }

        public bool Modificar(Tickest Ticket)
        {
            _context.Update(Ticket);
            int cantidad = _context.SaveChanges();
            return cantidad > 0;
        }

        public bool Guardar(Tickest Ticket)
        {
            if (!Existe(Ticket.TicketId))
                return Insertar(Ticket);
            else
                return Modificar(Ticket);
        }

        public bool Eliminar(Tickest Ticket)
        {
            _context.Sistemas.Remove(Ticket);
            int cantidad = _context.SaveChanges();
            return cantidad > 0;
        }

        public Tickest? Buscar(int SistemaId)
        {
            return _context.Sistemas
                .AsNoTracking()
                .FirstOrDefault(s => s.SistemaId == SistemaId);
        }
        public List<Tickest> GetList(Expression<Func<Tickest, bool>> Criterio)
        {
            return _context.Sistemas
                .Where(Criterio)
                .AsNoTracking()
                .ToList();
        }
    }
}