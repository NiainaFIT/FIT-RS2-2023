using AutoMapper;
using Db = eProdaja.Infrastructure.Entities;

namespace eProdaja.Services.AutoMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Db.Korisnici, Model.Korisnici>();
            CreateMap<Db.Proizvodi, Model.Proizvodi>();
            CreateMap<Model.Requests.KorisniciInsertRequest, Db.Korisnici>();
            CreateMap<Model.Requests.KorisniciUpdateRequest, Db.Korisnici>()
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
