using Models.Entities;
using Services.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BaseDeDatos.Repository
{
    public class ProvinciaRepository : BaseRepository, IProvinciaRepository
    {
        public ProvinciaRepository(DataContext context) : base(context)
        {
        }

        public async Task<List<Provincia>> GetProvincias()
        {
            try
            {
                var provincias = await Context.Provincias.ToListAsync();
                return provincias;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
