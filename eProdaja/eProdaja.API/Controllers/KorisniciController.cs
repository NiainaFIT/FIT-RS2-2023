using eProdaja.Model.Requests;
using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : ControllerBase
    {
        
        private readonly ILogger<KorisniciController> _logger;
        private readonly IKorisniciService _korisniciService;
        
        public KorisniciController(ILogger<KorisniciController> logger, IKorisniciService korisniciService)
        {
            _logger = logger;
            _korisniciService = korisniciService;
        }


        [HttpGet(Name = "GetKorisnici")]
        public async Task<IEnumerable<Model.Korisnici>> Get()
        {
            var korisnici = await _korisniciService.Get();

            return korisnici;
        }

        [HttpPost]
        public async Task<Model.Korisnici> Insert(KorisniciInsertRequest request)
        {
            var korisnik = await _korisniciService.Insert(request);

            return korisnik;
        }

        [HttpPut("{id}")]
        public async Task<Model.Korisnici> Update(int id,KorisniciUpdateRequest request)
        {
            var korisnik = await _korisniciService.Update(id, request);

            return korisnik;
        }
    }
}
