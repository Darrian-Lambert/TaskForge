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
    public class NewTaskModel : PageModel
    {
        private readonly Final.Models.FinalDbContext _context;

        public NewTaskModel(Final.Models.FinalDbContext context)
        {
            _context = context;
        }

        public IList<WorkerTask> Task { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public int PageNum { get; set; } = 1;

        public int PageSize { get; set; } = 10;
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}
        [BindProperty]
        public int PagesNeeded { get; set; }
        [BindProperty]
        public int TaskIdToDelete { get; set; }

        public async Task OnGetAsync()
        {
            PagesNeeded = (int)Math.Ceiling((double)_context.WorkerTasks.Count()/PageSize);
            var query = _context.WorkerTasks.Include(x => x.Worker).Select(x => x);
            switch (CurrentSort) {
                case "UName_asc":
                    query =query.OrderBy(x => x.Worker.UserName);
                    break;
                case "UName_desc":
                    query = query.OrderByDescending(x => x.Worker.UserName);
                    break;
                    case "Task_asc":
                    query =query.OrderBy(x => x.Title);
                    break;
                case "Task_desc":
                    query = query.OrderByDescending(x => x.Title);
                    break;
            }
            Task = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
