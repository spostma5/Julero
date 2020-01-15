using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Julero.Data;
using Julero.Models;

namespace Julero
{
    public class DetailsModel : PageModel
    {
        private readonly Julero.Data.JuleroContext _context;

        public DetailsModel(Julero.Data.JuleroContext context)
        {
            _context = context;
        }

        public Goal Goal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Goal = await _context.Goal.FirstOrDefaultAsync(m => m.ID == id);

            if (Goal == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
