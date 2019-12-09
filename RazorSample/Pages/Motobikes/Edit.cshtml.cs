using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RazorSample.Pages.Motobikes
{
    public class EditModel : PageModel
    {
        private readonly MotobikeContext _context;

        public EditModel(MotobikeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Motobike Motobike { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Motobike = await _context.Motobikes.FirstOrDefaultAsync(m => m.Id == id);

            if (Motobike == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Motobike).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MotobikeExists(Motobike.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MotobikeExists(int id)
        {
            return _context.Motobikes.Any(e => e.Id == id);
        }
    }
}