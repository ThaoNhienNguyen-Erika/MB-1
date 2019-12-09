using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;

namespace RazorSample.Pages.Motobikes
{
    public class CreateModel : PageModel
    {
        private readonly MotobikeContext _context;

        public CreateModel(MotobikeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Motobike Motobike { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Motobikes.Add(Motobike);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}