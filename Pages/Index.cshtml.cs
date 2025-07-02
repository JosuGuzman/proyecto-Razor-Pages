using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PrimerRazorPages.Pages;


public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public string? NombreUsuario { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

}