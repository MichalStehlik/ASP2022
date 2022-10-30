﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly asp06nmui.Data.ApplicationDbContext _context;

        public DetailsModel(asp06nmui.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Artist Artist { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Artists == null)
            {
                return NotFound();
            }

            var artist = await _context.Artists.FirstOrDefaultAsync(m => m.ArtistId == id);
            if (artist == null)
            {
                return NotFound();
            }
            else 
            {
                Artist = artist;
            }
            return Page();
        }
    }
}
