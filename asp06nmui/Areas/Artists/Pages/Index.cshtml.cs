using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using asp06nmui.Data;
using asp06nmui.Model;

namespace asp06nmui.Areas.Artists.Pages
{
    public class IndexModel : PageModel
    {
        private readonly asp06nmui.Data.ApplicationDbContext _context;

        public IndexModel(asp06nmui.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Artist> Artist { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Artists != null)
            {
                Artist = await _context.Artists.ToListAsync();
            }
        }
    }
}
