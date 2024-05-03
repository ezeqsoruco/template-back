using Models.Entities;
using Services.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos.Repository
{
    public class PersonaRepository: BaseRepository, IPersonaReposotory
    {
        public PersonaRepository(DataContext context) : base(context)
        {

        }

        public async Task<bool> AgregarPersona()
        {

            return false;
        }

        public async Task<bool> ModificarPersona()
        {
            return false;
        }

        public async Task<bool> EliminarPersona()
        {
            return false;   
        }
    }
}
