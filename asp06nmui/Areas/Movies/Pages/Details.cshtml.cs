using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using asp06nmui.Data;
using asp06nmui.Model;
using asp06nmui.Model.InputModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace asp06nmui.Areas.Movies.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly asp06nmui.Data.ApplicationDbContext _context;

        public DetailsModel(asp06nmui.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }
        [BindProperty]
        public RoleIM NewRole { get; set; }
        public List<Role> Roles { get; set; }
        public List<SelectListItem> ArtistsList { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movies == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.Include(m => m.Roles).ThenInclude(r => r.Artist).FirstOrDefaultAsync(m => m.MovieId == id);
            if (movie == null)
            {
                return NotFound();
            }
            else 
            {

                ArtistsList = _context.Artists.Select(a => new SelectListItem { Value = a.ArtistId.ToString(), Text = a.Lastname + ", " + a.Firstname}).ToList();
                Movie = movie;
                NewRole = new RoleIM { MovieId = movie.MovieId };
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // TODO errors
            _context.Roles.Add(new Role { ArtistId = NewRole.ArtistId, MovieId = NewRole.MovieId, Name = NewRole.Name});
            await _context.SaveChangesAsync();
            return RedirectToPage("Details", new { id = NewRole.MovieId});
        }
    }
}
