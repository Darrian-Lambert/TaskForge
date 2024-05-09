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

namespace TaskForge.Pages
{
    public class MyTaskModel : PageModel
    {
        private readonly ILogger<MyTaskModel> _logger;
        private readonly Final.Models.FinalDbContext _context;

        public MyTaskModel(Final.Models.FinalDbContext context, ILogger<MyTaskModel> logger)
        {
            _context = context;
            _logger = logger;
        }
        public Worker My { get; set; }
        public List<WorkerTask> Tasks { get; set; } = new List<WorkerTask>();
        public List<WorkerTask> Visable { get; set; } = new List<WorkerTask>();

        [BindProperty(SupportsGet = true)]
        public int PageNum { get; set; } = 1;

        public int PageSize { get; set; } = 10;
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = "None";
        [BindProperty]
        public int PagesNeeded { get; set; }
        [BindProperty]
        public int TaskIdToDelete { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            _logger.LogWarning($"ID: {id}");
            if (id == null)
            {
                return NotFound();
            }
            My = _context.Workers.Single(x => x.WorkerID == id);
            if (My == null) {
                return NotFound();
            }
            Tasks = My.WorkerTasks.ToList();
            _logger.LogWarning($"MyTasks: {Tasks.ToArray()}");
            if (Tasks == null)
            {
                return NotFound();
            }
            PagesNeeded = (int)Math.Ceiling((double)Tasks.Count()/PageSize);
            _logger.LogWarning($"PagesNeeded: {PagesNeeded}");
            Visable = Tasks;
            _logger.LogWarning($"MyVisableTasks: {Visable.ToArray()}");
            switch (CurrentSort) {
                case "Title_asc":
                    Visable = Visable.OrderBy(x => x.Title).ToList();
                    break;
                case "Title_desc":
                    Visable = Visable.OrderByDescending(x => x.Title).ToList();
                    break;
            }
            _logger.LogWarning($"MyVisableTasks: {Visable.ToArray()}");
            Visable = Visable.Skip((PageNum-1)*PageSize).Take(PageSize).ToList();
            _logger.LogWarning($"MyVisableTasks: {Visable.ToArray()}");
            return Page();
        }
        public IActionResult OnPostRemoveTask(int? id) {
            if (!ModelState.IsValid) {
                return Page();
            }

            var Target = _context.WorkerTasks.FirstOrDefault(t => t.WorkerTaskID == TaskIdToDelete);

            if (Target != null) {
                _context.WorkerTasks.Remove(Target);
                _context.SaveChanges();
            }

            return RedirectToPage("/MyTasks", new {id = My.WorkerID});
        }
    }
}
