using Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace TaskForge.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    [Display(Name = "Username")]
    [StringLength(25)]
    [Required]
    public string Username { get; set;} = string.Empty;

    [BindProperty]
    [Display(Name = "Password")]
    [StringLength(255)]
    [Required]
    public string Password { get; set;} = string.Empty;
    private readonly ILogger<IndexModel> _logger;
    private readonly FinalDbContext _context;
    public bool TableisVisable = false;
    public bool LoggedIn = false;
    public Worker worker { get; set; } = new Worker();
    public List<WorkerTask> Tasks { get; set; } = new List<WorkerTask>();
    [BindProperty]
    public int targetTask { get; set; } = -1;

    public IndexModel(ILogger<IndexModel> logger, FinalDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public void OnGet()
    {

    }

    public async Task<IActionResult> OnPostShow() {
        worker = await _context.Workers.Include(x => x.WorkerTasks).FirstOrDefaultAsync(A => A.UserName == Username && A.Password == Password);
        var admin = _context.Admins.FirstOrDefault(A => A.UserName == Username && A.Password == Password);

        if (admin != null) {
            return RedirectToPage("/Workers/Index");
        } else if (worker != null) {
            _logger.LogCritical($"{worker.WorkerID}");

            Tasks = _context.WorkerTasks.Where(t => t.UID == worker.WorkerID).ToList();

            TableisVisable = true;
            LoggedIn = true;
            return Page();
            //return RedirectToPage("/MyTasks", new {workerID = worker.WorkerID});//Initially redirected but I could not determine why UID wasn't working on that page yet worked on every other page
        } else {
            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            return Page();
        }
    }
    public void OnPostMarkComplete() {

        if (targetTask != -1) {
            var Delv = _context.WorkerTasks.FirstOrDefault(d => d.WorkerTaskID == targetTask);

            if (Delv != null) {
                _context.WorkerTasks.Remove(Delv);
                _context.SaveChanges();
            }
        }

        // Reset the page
        Tasks = _context.WorkerTasks.Where(w => w.UID == worker.WorkerID).ToList();
    }
}
