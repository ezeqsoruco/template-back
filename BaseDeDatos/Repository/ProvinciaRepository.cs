using Models.Entities;
using Services.IRepository;

namespace BaseDeDatos.Repository
{
    public class ProvinciaRepository : BaseRepository, IProvinciaRepository
    {
        public ProvinciaRepository(DataContext context) : base(context)
        {
        }

        public async Task<List<Provincia>> GetProvincias()
        {
            var provincias = Context.Provincias.ToList();
            return provincias;
        }
    }
}
