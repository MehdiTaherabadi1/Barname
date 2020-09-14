using CleanArch.Domin.Modals;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context
{
    public class BaranameDBContext: DbContext
    {
        public BaranameDBContext(DbContextOptions<BaranameDBContext> options):base(options)
        {
            
        }

        public DbSet<Course> Courses { get; set; }
    }
}