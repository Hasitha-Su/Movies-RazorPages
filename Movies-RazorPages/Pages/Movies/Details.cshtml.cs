using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Movies_RazorPages.Data;
using Movies_RazorPages.Models;

namespace Movies_RazorPages
{
    public class DetailsModel : PageModel
    {
        private readonly Movies_RazorPages.Data.Movies_RazorPagesContext _context;

        public DetailsModel(Movies_RazorPages.Data.Movies_RazorPagesContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
