using Microsoft.EntityFrameworkCore;
using TecnicalAPI.Models;

namespace TecnicalAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Book> Books {  get; set; }
    }
}
