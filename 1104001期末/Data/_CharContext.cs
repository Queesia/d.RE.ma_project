using Microsoft.EntityFrameworkCore;
using _1104001期末.Model; //

namespace _1104001期末.Data
{
    public class _CharContext : DbContext
    {
        public _CharContext(DbContextOptions<_CharContext> options)
            : base(options)
        {
        }

        public DbSet<Zeitgeist> Characters { get; set; }
    }
}
