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
    public class DeleteTaskModel : PageModel
    {
        private readonly Final.Models.FinalDbContext _context;

        public DeleteTaskModel(Final.Models.FinalDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WorkerTask Task { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var task = await _context.WorkerTasks.FirstOrDefaultAsync(m => m.WorkerTaskID == id);

            if (task == null)
            {
                return NotFound();
            }
            else
            {
                Task = task;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var task = await _context.WorkerTasks.FindAsync(id);
            if (task != null)
            {
                Task = task;
                _context.WorkerTasks.Remove(Task);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./NewTasks");
        }
    }
}
