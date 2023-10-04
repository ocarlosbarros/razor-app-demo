using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorAppDemo.Pages
{
    public class Categories : PageModel
    {
        public List<Category> CategoryList { get; set; } = new();

        public void OnGet(
            int skip = 0, 
            int take = 25)
        {
            var temp = new List<Category>();

            for (int index = 0; index <= 1787; index += 1)
            {
                temp.Add(
                    new Category(index, Title:$"Categoria {index}", Price: index * 18.95M));
            }

        CategoryList = temp
            .Skip(skip)
            .Take(take)
            .ToList();
        }
       
    }

    public record Category (
        int Id,
        string Title,
        decimal Price
    );
}


