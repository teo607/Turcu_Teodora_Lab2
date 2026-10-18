using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Turcu_Teodora_Lab2.Data;
using Turcu_Teodora_Lab2.Models;

namespace Turcu_Teodora_Lab2.Pages.PublisherPages
{
    public class CreateModel : PageModel
    {
        private readonly Turcu_Teodora_Lab2Context _context;

        public CreateModel(Turcu_Teodora_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}