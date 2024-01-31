using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ResponseMode Get()
        {
            return new ResponseMode()
            {
                HttpStatus = 200,
                StatusMessage = "Ömer Çakmak",
            };
        }


    }
}
