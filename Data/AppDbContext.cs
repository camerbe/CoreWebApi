using Microsoft.EntityFrameworkCore;
using MyFirstWebApi.Data.Models;

namespace MyFirstWebApi.Data
{
    public class AppDbContext:DbContext
    {
        private DbSet<Book> Books { get; set; }
    }
}
