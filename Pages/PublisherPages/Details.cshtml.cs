using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Turcu_Teodora_Lab2.Data;
using Turcu_Teodora_Lab2.Models;

namespace Turcu_Teodora_Lab2.Pages.PublisherPages
{
    public class DetailsModel : PageModel
    {
        private readonly Turcu_Teodora_Lab2Context _context;

        public DetailsModel(Turcu_Teodora_Lab2Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            Publisher = publisher;
            return Page();
        }
    }
}