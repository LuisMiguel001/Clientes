﻿using Clientes.DAL;
using Clientes.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Clientes.BLL
{
    public class SistemaBLL
    {
        private readonly ClienteContext _contexto;

        public SistemaBLL(ClienteContext contexto)
        {
            _contexto = contexto;
        }

        public bool Existe(string nombres)
        {
            return _contexto.Sistema.Any(s => s.Nombres == nombres);
        }

        private bool Insertar(Sistemas Cliente)
        {
            _contexto.Sistema.Add(Cliente);
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;
        }

        private bool Modificar(Sistemas Cliente)
        {
            _contexto.Update(Cliente);
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;
        }

        public bool Guardar(Sistemas Cliente)
        {
            if (!Existe(Cliente.Nombres))
                return Insertar(Cliente);
            else
                return Modificar(Cliente);
        }

        public bool Eliminar(Sistemas Cliente)
        {
            _contexto.Remove(Cliente);
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;
        }

        public Sistemas? Buscar(int ClienteId)
        {
            return _contexto.Sistema
                .AsNoTracking()
                .FirstOrDefault(s => s.ClienteId == ClienteId);
        }

        public List<Sistemas> GetList(Expression<Func<Sistemas, bool>> Criterio)
        {
            return _contexto.Sistema
                .Where(Criterio)
                .AsNoTracking()
                .ToList();
        }
    }
}
