using eProdaja.Model.Requests;

namespace eProdaja.Services.Interfaces
{
    public interface IKorisniciService
    {
        Task<List<Model.Korisnici>> Get();
        Task<Model.Korisnici> Insert(KorisniciInsertRequest request);
        Task<Model.Korisnici> Update(int id, KorisniciUpdateRequest request);
    }
}
