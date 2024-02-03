using AutoMapper;
using eProdaja.Infrastructure.Database;
using eProdaja.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eProdaja.Services.Services
{
    public class ProizvodiService : IProizvodiService
    {
        EProdajaContext _context;
        private readonly IMapper _mapper;
        public ProizvodiService(EProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<Model.Proizvodi>> Get()
        {
            var proizvodi = await _context.Proizvodi.ToListAsync();

            return _mapper.Map<List<Model.Proizvodi>>(proizvodi);
        }
    }
}
