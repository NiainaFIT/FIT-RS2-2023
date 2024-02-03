namespace eProdaja.Services.Interfaces
{
    public interface IProizvodiService
    {
        Task<List<Model.Proizvodi>> Get();
    }
}
