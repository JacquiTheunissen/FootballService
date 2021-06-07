using Microsoft.EntityFrameworkCore;

namespace FootballService.Context
{
    public partial class FootballDbContext : DbContext
    {
        public FootballDbContext()
        {
        }

        public FootballDbContext(DbContextOptions<FootballDbContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<AssessingDiary> AssessingDiaries { get; set; }
    }
}
