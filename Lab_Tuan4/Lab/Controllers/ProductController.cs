using Lab.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>() 
        {
            new Product() { Id = 1, Name = "Bim bim", Price = 10000 },
            new Product() { Id = 2, Name = "Nước ngọt", Price = 15000 },
            new Product() { Id = 3, Name = "Bánh", Price = 30000 }
        };
        [Route("/product-details")]
        public IActionResult Details()
        {
            return View(products);
        }
    }
}
