using System.ComponentModel.DataAnnotations;
using Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace TaskForge.Pages;

public class MyTasksModel : PageModel
{
    private readonly ILogger<MyTasksModel> _logger;
    private readonly FinalDbContext _context;
    public List<WorkerTask> Tasks { get; set; } = default!;
    [BindProperty]
    public int targetTask { get; set; } = -1;
    public int thisWorker { get; set; } = default!;

    public MyTasksModel(FinalDbContext context, ILogger<MyTasksModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet(int workerID)
    {
        _logger.LogError($"{workerID}");
        Tasks = _context.WorkerTasks.Where(w => w.UID == workerID).ToList();
        _logger.LogError($"Taks {_context.WorkerTasks.Where(w => w.UID == workerID).ToArray()}");
        _logger.LogError($"Taks {Tasks.Count}");
        thisWorker = workerID;
        _logger.LogError($"This worker {thisWorker}");

        _logger.LogError($"Test {_context.Workers.Where(t => t.WorkerID == workerID).ToArray()}");
        var testo = _context.WorkerTasks.Include(x => x.Worker).ToList();
        _logger.LogCritical($"{testo}");
        _logger.LogCritical($"{testo[3].UID}");
    }

    public IActionResult OnPostMarkComplete() {

        if (targetTask != -1) {
            var Delv = _context.WorkerTasks.FirstOrDefault(d => d.WorkerTaskID == targetTask);

            if (Delv != null) {
                _context.WorkerTasks.Remove(Delv);
                _context.SaveChanges();
            }
        }

        // Reset the page
        Tasks = _context.WorkerTasks.Where(w => w.UID == thisWorker).ToList();

        return Page();
    }

}

