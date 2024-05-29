using Microsoft.EntityFrameworkCore;
using T2_Laulate_Maycol.Models;

namespace T2_Laulate_Maycol.Datos
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Distribuidor> Distribuidor { get; set; }
        public DbSet<DistribuidorPeru> DistribuidorPE { get; set; }
        public DbSet<DistribuidorMundo> DistribuidorMUNDO { get; set; }
    }
}
