using Microsoft.EntityFrameworkCore;
using Turcu_Teodora_Lab2.Models;

namespace Turcu_Teodora_Lab2.Data
{
    public class Turcu_Teodora_Lab2Context : DbContext
    {
        public Turcu_Teodora_Lab2Context(DbContextOptions<Turcu_Teodora_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; } = default!;
        public DbSet<Publisher> Publisher { get; set; } = default!;
        public DbSet<Author> Author { get; set; } = default!;
    }
}