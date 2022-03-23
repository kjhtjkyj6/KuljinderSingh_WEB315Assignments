using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesDogs.Models;

namespace RazorPagesDogs.Pages_Dogs
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesDogsContext _context;

        public IndexModel(RazorPagesDogsContext context)
        {
            _context = context;
        }

        public IList<Dogs> Dogs { get;set; }

        public async Task OnGetAsync()
        {
            Dogs = await _context.Dogs.ToListAsync();
        }
    }
}
