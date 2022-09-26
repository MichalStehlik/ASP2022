using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using asp02crud.Data;
using asp02crud.Model;

namespace asp02crud.Pages
{
    public class IndexModel : PageModel
    {
        private readonly asp02crud.Data.ApplicationDbContext _context;

        public IndexModel(asp02crud.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Books != null)
            {
                Book = await _context.Books/*.Where(b => b.Title.StartsWith("Bab"))*/.ToListAsync();
            }
        }
    }
}
