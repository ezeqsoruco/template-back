using Models.Entities;
using Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IRepository
{
    public interface IPersonaReposotory: IBaseRepository
    {
        Task<List<Persona>> ObtenerPersonasList();
        Task<Persona> ObtenerPersona(int id);
        Task<Persona> AgregarPersona(Persona persona);
        Task<Persona> ModificarPersona(Persona persona);
        Task<Persona> EliminarPersona(int id);
    }
}
