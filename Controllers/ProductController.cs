using Microsoft.AspNetCore.Mvc;

namespace ProductCategoryApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext context;

        public ProductController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var product = context.products.ToList();
            return View(product);
        }

        public IActionResult Create()
        {
            var product = context.products.ToList();
            return View(product);
        }
    }
}
