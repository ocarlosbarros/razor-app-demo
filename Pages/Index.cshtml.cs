using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorAppDemo.Pages
{
    public class Index : PageModel
    {
        public void OnGet()
        {
        }
    }
}

public record Category (
    int Id,
    string Title,
    decimal Price
);