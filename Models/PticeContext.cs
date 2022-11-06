using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class PticeContext : DbContext
    {
        public DbSet<Ptica> Ptice { get; set; }
        public DbSet<NepoznataPtica> Nepoznate { get; set; }
        public DbSet<Osobina> Osobine { get; set; }
        public DbSet<Podrucje> Podrucja { get; set; }
        public DbSet<Vidjenje> Vidjenja { get; set; }

        public PticeContext(DbContextOptions options) : base(options)
        {

        }
    }
}
