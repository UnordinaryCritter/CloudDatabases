using DomainLayer.Data;
using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.CustomServices;
using ServiceLayer.ICustomServices;

namespace WidgetAndCo.Api.Controllers
{
    public class ProductController : Controller
    {
        private readonly ICustomService<Product> _productService;
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductController(ICustomService<Product> productService, ApplicationDbContext applicationDbContext)
        {
            _productService = productService;
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet(nameof(GetProductById))]
        public IActionResult GetProductById(int Id)
        {
            var obj = _productService.Get(Id);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }


        [HttpGet(nameof(GetProducts))]
        public IActionResult GetProducts(int Id)
        {
            var obj = _productService.GetAll();
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
    }
}
