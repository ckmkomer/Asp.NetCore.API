using Microsoft.EntityFrameworkCore;

namespace BookCenter.Data
{
    public class BookCenterContext:DbContext
    {
        public BookCenterContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
