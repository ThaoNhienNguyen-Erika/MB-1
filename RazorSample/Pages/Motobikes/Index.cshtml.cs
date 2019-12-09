using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;
using ApplicationCore.Common;
using ApplicationCore.Entities;
using Infrastructure.Persistence;

namespace RazorSample.Pages.Motobikes
{
    public class IndexModel : PageModel
    {
        private int pageSize = 4;
        private readonly MotobikeContext _context;

        public IndexModel(MotobikeContext context)
        {
            _context = context;
        }
        public string NameSort { get; set; }
        public string PriceSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }


        public PaginatedList<Motobike> Motobike { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Colors { get; set; }
        public SelectList Types { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MotoColor { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MotoType { get; set; }

        public void OnGet(string sortOrder,int pageIndex = 1)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            PriceSort = sortOrder=="price_asc" ? "price_desc" : "price_asc";
            CurrentFilter=SearchString;

            var types = from m in _context.Motobikes
                                    select m.Type;
            var colors = from m in _context.Motobikes
                                    select m.Color;
            var motobikes = from m in _context.Motobikes 
                            select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                motobikes = motobikes.Where(s => s.Name.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(MotoType))
            {
                motobikes = motobikes.Where(x => x.Type == MotoType);
            }
            if (!string.IsNullOrEmpty(MotoColor))
            {
                motobikes = motobikes.Where(x => x.Color == MotoColor);
            }

            switch (sortOrder)
            {
                case "name_desc":
                    motobikes = motobikes.OrderByDescending(s => s.Name);
                    break;
                case "price_desc":
                    motobikes = motobikes.OrderByDescending(s => s.Price);
                    break;
                case "price_asc":
                    motobikes = motobikes.OrderBy(s => s.Price);
                    break;
                default:
                    motobikes = motobikes.OrderBy(s => s.Name);
                    break;
            }

            Types = new SelectList(types.Distinct().ToList());
            Colors = new SelectList(colors.Distinct().ToList());
            Motobike = PaginatedList<Motobike>.Create(motobikes.AsNoTracking(), pageIndex, pageSize);
        }
    }
}