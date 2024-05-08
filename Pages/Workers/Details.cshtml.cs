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
    public class DetailsModel : PageModel
    {
        private readonly Final.Models.FinalDbContext _context;

        public DetailsModel(Final.Models.FinalDbContext context)
        {
            _context = context;
        }

        public Worker Worker { get; set; } = default!;
        [BindProperty]
        public int TaskIdToDelete { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var worker = await _context.Workers.Include(x => x.WorkerTasks).FirstOrDefaultAsync(m => m.WorkerID == id);
            if (worker == null)
            {
                return NotFound();
            }
            else
            {
                Worker = worker;
            }
            return Page();
        }

        public IActionResult OnPostRemoveTask(int? id) {
            if (!ModelState.IsValid) {
                return Page();
            }

            var Task = _context.WorkerTasks.FirstOrDefault(t => t.WorkerTaskID == TaskIdToDelete);

            if (Task != null) {
                _context.Remove(Task);
                _context.SaveChanges();
            }

            return RedirectToPage("./Index");
        }
    }
}
