using eProdaja.Model;
using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductsService _productsService;
        public ProductsController(ILogger<ProductsController> logger, IProductsService productsService)
        {
            _logger = logger;
            _productsService = productsService;
        }

        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Products> Get()
        {
           return _productsService.Get();
        }
    }
}
