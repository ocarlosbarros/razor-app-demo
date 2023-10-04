using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorAppDemo.Pages
{
    public class Categories : PageModel
    {
        public List<Category> CategoryList { get; set; } = new();
        public void OnGet()
        {
            for (int index = 0; index <= 100; index += 1)
            {
                CategoryList.Add(
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