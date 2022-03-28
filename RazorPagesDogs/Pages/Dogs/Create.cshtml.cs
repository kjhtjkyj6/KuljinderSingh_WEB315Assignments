using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesDogs.Models;

namespace RazorPagesDogs.Pages_Dogs
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesDogsContext _context;

        public CreateModel(RazorPagesDogsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Dogs Dogs { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Dogs.Add(Dogs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
