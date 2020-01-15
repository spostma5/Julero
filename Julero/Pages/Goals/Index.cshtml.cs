using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Julero.Data;
using Julero.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Julero
{
    public class IndexModel : PageModel
    {
        private readonly Julero.Data.JuleroContext _context;

        public IndexModel(Julero.Data.JuleroContext context)
        {
            _context = context;
        }

        public IList<Goal> Goal { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var goals = from m in _context.Goal 
                        select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                goals = goals.Where(s => s.name.Contains(SearchString));
            }

            Goal = await _context.Goal.ToListAsync();
        }
    }
}
