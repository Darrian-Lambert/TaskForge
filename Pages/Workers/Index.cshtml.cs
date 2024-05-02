using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Models;

namespace TaskForge.Pages.Workers
{
    public class IndexModel : PageModel
    {
        private readonly Final.Models.FinalDbContext _context;

        public IndexModel(Final.Models.FinalDbContext context)
        {
            _context = context;
        }

        public IList<Worker> Worker { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Worker = await _context.Workers.ToListAsync();
        }
    }
}
