using Microsoft.EntityFrameworkCore;
using SistemaReservaQuadraCondominio.Models;

namespace SistemaReservaQuadraCondominio.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Reserva> Reservas { get; set; }
    }
}
