using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final.Models;

namespace TaskForge.Pages.Workers
{
    public class EditTaskModel : PageModel
    {
        private readonly Final.Models.FinalDbContext _context;
        [BindProperty]
         public List<Worker> TheseWorkers { get; set; } = new List<Worker>();

        public EditTaskModel(Final.Models.FinalDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WorkerTask Task { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            TheseWorkers = _context.Workers.ToList();
            TheseWorkers.Sort((x, y) => string.Compare(x.FullName, y.FullName));
            if (id == null)
            {
                return NotFound();
            }

            var task =  await _context.WorkerTasks.Include(x => x.Worker).FirstOrDefaultAsync(m => m.WorkerTaskID == id);
            if (task == null)
            {
                return NotFound();
            }
            Task = task;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Task).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskExists(Task.WorkerTaskID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./NewTasks");
        }

        private bool TaskExists(int id)
        {
            return _context.WorkerTasks.Any(e => e.WorkerTaskID == id);
        }
    }
}
