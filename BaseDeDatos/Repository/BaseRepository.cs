using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos.Repository
{
    public class BaseRepository
    {
        protected readonly DataContext Context;
        public BaseRepository(DataContext context)
        {
            Context = context;
        }

        public async Task Save(CancellationToken cancellationToken)
        {
            await Context.SaveChangesAsync(cancellationToken);
        }
    }
}
