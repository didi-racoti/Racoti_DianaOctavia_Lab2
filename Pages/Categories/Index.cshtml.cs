﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Racoti_DianaOctavia_Lab2.Data;
using Racoti_DianaOctavia_Lab2.Models;

namespace Racoti_DianaOctavia_Lab2.Pages.Categories
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly Racoti_DianaOctavia_Lab2.Data.Racoti_DianaOctavia_Lab2Context _context;

        public IndexModel(Racoti_DianaOctavia_Lab2.Data.Racoti_DianaOctavia_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
