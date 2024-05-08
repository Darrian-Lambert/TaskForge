using Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

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

    public IndexModel(ILogger<IndexModel> logger, FinalDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public void OnGet()
    {

    }

    public IActionResult OnPost() {
        var worker = _context.Workers.FirstOrDefault(s => s.UserName == Username && s.Password == Password);
        var admin = _context.Admins.FirstOrDefault(A => A.UserName == Username && A.Password == Password);

        if (admin != null) {
            return RedirectToPage("/Workers/Index");
        } else if (worker != null) {
            return RedirectToPage("/MyTasks");
        } else {
            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            return Page();
        }
    }
}
