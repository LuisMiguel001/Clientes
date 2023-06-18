﻿using Clientes.Models;
using Microsoft.EntityFrameworkCore;

namespace Clientes.DAL
{
    public class TicketsContext : DbContext
    {
        public TicketsContext(DbContextOptions<TicketsContext> Options)
            : base(Options) { }

        public DbSet<Sistemas> Sistemas { get; set; }
    }
}
