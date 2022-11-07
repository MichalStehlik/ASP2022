using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using asp07identity1.Data;
using asp07identity1.Models;

namespace asp07identity1.Areas.Movies.Pages
{
    public class IndexModel : PageModel
    {
        private readonly asp07identity1.Data.ApplicationDbContext _context;

        public IndexModel(asp07identity1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movies != null)
            {
                Movie = await _context.Movies.ToListAsync();
            }
        }
    }
}
