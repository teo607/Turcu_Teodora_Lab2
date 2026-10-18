using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Turcu_Teodora_Lab2.Data;
using Turcu_Teodora_Lab2.Models;

namespace Turcu_Teodora_Lab2.Pages.BookPages
{
    public class IndexModel : PageModel
    {
        private readonly Turcu_Teodora_Lab2Context _context;

        public IndexModel(Turcu_Teodora_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher)
                .Include(b => b.Author)
                .ToListAsync();
        }
    }
}