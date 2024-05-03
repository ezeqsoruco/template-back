using Models.Entities;

namespace Services.IRepository
{
    public interface IProvinciaRepository: IBaseRepository
    {
        Task<List<Provincia>> GetProvincias();
    }
}
