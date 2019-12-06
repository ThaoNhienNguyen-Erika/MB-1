using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorSample.Pages.Motobikes
{
    public class IndexModel : PageModel
    {
        private readonly RazorSample.Data.MotobikeContext _context;

        public IndexModel(RazorSample.Data.MotobikeContext context)
        {
            _context = context;
        }

        public IList<Motobike> Motobike { get;set; }

        public async Task OnGetAsync()
        {
            Motobike = await _context.Motobikes.ToListAsync();
        }
    }
}