using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_pages.Pages;

public class IndexModel : PageModel
{
    public bool ShowGreeting = true;

    public string[] OtherProjects=["MVC", "Blazor", "Web API", "SignalR", "gRPC"];
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
