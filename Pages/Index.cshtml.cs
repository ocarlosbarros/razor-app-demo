using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorAppDemo.Pages
{
    public class Index : PageModel
    {
        public List<Category> Categories { get; set; } = new();
        public async Task OnGet()
        {
            await Task.Delay(5000);
            for (int index = 0; index <= 100; index += 1)
            {
                Categories.Add(
                    new Category(index, Title:$"Categoria {index}", Price: index * 18.95M));
            }
        }
    }
}

public record Category (
    int Id,
    string Title,
    decimal Price
);