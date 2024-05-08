using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Models;
using System.Text.RegularExpressions;
using SQLitePCL;

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
        [BindProperty(SupportsGet = true)]
        public int PageNum { get; set; } = 1;

        public int PageSize { get; set; } = 10;
        [BindProperty]
        public int PagesNeeded { get; set; }

        public async Task OnGetAsync()
        {
            PagesNeeded = (int)Math.Ceiling((double)_context.Workers.Count()/PageSize);
            Worker = await _context.Workers.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
