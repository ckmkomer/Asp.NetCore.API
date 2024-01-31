using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;//Bir ifade readonly olarak tanımlanmış ise bunun değerini iki yerde vereniliriz.  //1-Ctor 2. ise tanımlandığı yerdir. ve bir kez set edebiliyoruz.

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = new List<Product>()
            {
                new Product { Id = 1,Name="Bilgisayar"},
                new Product { Id = 2, Name="Fare"},
                new Product { Id = 3, Name="Klavye"}
            };
            _logger.LogInformation("GetAllProduct action has been called");
            return Ok(products);
        }
    }
}
