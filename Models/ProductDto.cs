using System.ComponentModel.DataAnnotations;

namespace ProductCategoryApp.Models
{
    public class ProductDto
    {
        public string productName { get; set; } = "";

        public int categoryId { get; set; } = 0;

        
    }
}
