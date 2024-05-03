using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IRepository
{
    public interface IPersonaReposotory: IBaseRepository
    {
        Task<bool> AgregarPersona();
        Task<bool> ModificarPersona();
        Task<bool> EliminarPersona();
    }
}
