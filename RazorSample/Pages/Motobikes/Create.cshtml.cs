using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorSample.Models;
using System;
using System.Threading.Tasks;

namespace RazorSample.Pages.Motobikes
{
    public class CreateModel : PageModel
    {
        private readonly RazorSample.Data.MotobikeContext _context;

        public CreateModel(RazorSample.Data.MotobikeContext context)
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