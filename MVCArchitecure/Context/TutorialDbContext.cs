using Microsoft.EntityFrameworkCore;
using MVCArchitecure.Models;

namespace MVCArchitecure.Context
{
    public class TutorialDbContext:DbContext
    {

        public TutorialDbContext(DbContextOptions<TutorialDbContext>options):base(options) 
        {

        }

        public DbSet<Tutorial> Tutorials { get; set; }
    }
}
