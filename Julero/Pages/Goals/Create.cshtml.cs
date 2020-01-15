using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Julero.Data;
using Julero.Models;

namespace Julero
{
    public class CreateModel : PageModel
    {
        private readonly Julero.Data.JuleroContext _context;

        public CreateModel(Julero.Data.JuleroContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Goal Goal { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Goal.Add(Goal);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
