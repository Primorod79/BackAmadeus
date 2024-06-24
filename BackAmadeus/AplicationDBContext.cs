using BackAmadeus.Models;
using Microsoft.EntityFrameworkCore;

namespace BackAmadeus
{
    public class AplicationDBContext: DbContext 
    {
        public DbSet<Laptop> laptop {  get; set; }
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options ): base( options )
        { 
        }

    }
}
