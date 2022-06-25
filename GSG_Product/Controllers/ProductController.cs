using Microsoft.AspNetCore.Mvc;
using GSG_Product.Models;
namespace GSG_Product.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetName()
        {
            return Ok("Mohammed Alattar");
        }
        [HttpPost]
        public IActionResult productDetils()
        {
            Product product = new Product();
            return Ok($"ProductPrice={product.Price}");
        }
    }
}
