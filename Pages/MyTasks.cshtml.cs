using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TaskForge.Pages;

public class MyTaskModel : PageModel
{
    private readonly ILogger<MyTaskModel> _logger;

    public MyTaskModel(ILogger<MyTaskModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

