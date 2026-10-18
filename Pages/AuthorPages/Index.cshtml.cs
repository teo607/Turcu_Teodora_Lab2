using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Turcu_Teodora_Lab2.Models;
using Turcu_Teodora_Lab2.Data;

namespace Turcu_Teodora_Lab2.Pages.AuthorPages;

public class IndexModel : PageModel
{
    private readonly Turcu_Teodora_Lab2Context _context;

    public IndexModel(Turcu_Teodora_Lab2Context context)
    {
        _context = context;
    }

    public IList<Author> Author { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Author = await _context.Author.ToListAsync();
    }
}
