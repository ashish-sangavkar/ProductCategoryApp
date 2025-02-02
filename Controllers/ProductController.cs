using Microsoft.AspNetCore.Mvc;
using ProductCategoryApp.Models;

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
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductDto productDto)
        {
            Product product = new Product()
            {
                productName = productDto.productName,
                categoryId = productDto.categoryId,
            };
            context.products.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index", "Products");
        }

        public IActionResult Edit(int productId)
        {
            var product = context.products.Find(productId);

            if (product == null) {
                    return RedirectToAction("Index", "Products");
            }

            var productDto = new ProductDto()
            {
                productName = product.productName,
                categoryId = product.categoryId,
            };
            return View(productDto);
        }

        public IActionResult Delete(int productId)
        {
            var product = context.products.Find(productId);

            if (product == null)
            {
                return RedirectToAction("Index", "Products");
            }

            var productDto = new ProductDto()
            {
                productName = product.productName,
                categoryId = product.categoryId,
            };
            return View(productDto);
        }

    }
}
