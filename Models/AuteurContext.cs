using Microsoft.EntityFrameworkCore;

namespace NembotKamgueGyldas.Models
{
    public class AuteurContext : DbContext
    {
        public AuteurContext(DbContextOptions<AuteurContext> options) : base(options) { }

        public DbSet<Auteur> Auteurs { get; set; }
    }
}
