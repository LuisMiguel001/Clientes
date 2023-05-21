using Clientes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Clientes.DAL
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> Options)
            : base(Options) { }

        public DbSet<Sistema> Sistema { get; set; }
    }
}
