using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Final.Models;
using System.Text.RegularExpressions;
using SQLitePCL;

namespace TaskForge.Pages.Workers
{
    public class NewTaskModel : PageModel
    {
        private readonly ILogger<NewTaskModel> _logger;
        private readonly Final.Models.FinalDbContext _context;

        public NewTaskModel(Final.Models.FinalDbContext context, ILogger<NewTaskModel> logger)
        {
            _context = context;
            _logger = logger;
        }
        public List<Worker> TheseWorkers { get; set; } = new List<Worker>();

        [BindProperty]
        public WorkerTask NewTask { get; set; } = default!;

        public IList<WorkerTask> Task { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public int PageNum { get; set; } = 1;

        public int PageSize { get; set; } = 10;
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = "UName_asc";
        [BindProperty]
        public int PagesNeeded { get; set; }
        [BindProperty]
        public int TaskIdToDelete { get; set; }

        public async Task OnGetAsync()
        {
            //Task Creator
            TheseWorkers = _context.Workers.ToList();
            TheseWorkers.Sort((x, y) => string.Compare(x.FullName, y.FullName));

            //Task Manager
            PagesNeeded = (int)Math.Ceiling((double)_context.WorkerTasks.Count()/PageSize);
            var query = _context.WorkerTasks.Include(x => x.Worker).Select(x => x);
            switch (CurrentSort) {
                case "UName_asc":
                    query =query.OrderBy(x => x.Worker.FullName);
                    break;
                case "UName_desc":
                    query = query.OrderByDescending(x => x.Worker.FullName);
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

        public IActionResult OnPostNewTask() {
            if (NewTask != null) {
                var thisWorker = _context.Workers.Find(NewTask.UID);
                _context.WorkerTasks.Add(new WorkerTask{Title = NewTask.Title, Description = NewTask.Description, Worker = thisWorker});
                _context.SaveChanges();
                return RedirectToPage("/Workers/Index");
            } else {
                TheseWorkers = _context.Workers.ToList();
                TheseWorkers.Sort((x, y) => string.Compare(x.FullName, y.FullName));
                return Page();
            }
        }
    }
}
