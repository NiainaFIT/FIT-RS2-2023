using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        
        private readonly ILogger<ProductsController> _logger;
        private readonly IProizvodiService _productsService;
        public ProductsController(ILogger<ProductsController> logger, IProizvodiService productsService)
        {
            _logger = logger;
            _productsService = productsService;
        }

        [HttpGet(Name = "GetProizvodi")]
        public async Task<IEnumerable<Model.Proizvodi>> Get()
        {
           var result = await _productsService.Get();
            return result;
        }
    }
}
