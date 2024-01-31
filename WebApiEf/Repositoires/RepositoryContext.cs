using Microsoft.EntityFrameworkCore;
using WebApiEf.Models;

namespace WebApiEf.Repositoires
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}
