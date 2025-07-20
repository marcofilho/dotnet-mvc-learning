using Microsoft.EntityFrameworkCore;

namespace MyFirstMvc.Data
{
    public class MyFirstMvcContext : DbContext
    {
        public MyFirstMvcContext (DbContextOptions<MyFirstMvcContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstMvc.Models.Movie> Movie { get; set; } = default!;
    }
}
