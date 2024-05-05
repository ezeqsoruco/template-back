using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Services.IRepository;

namespace BaseDeDatos.Repository
{
    public class PersonaRepository: BaseRepository, IPersonaReposotory
    {
        public PersonaRepository(DataContext context) : base(context)
        {

        }

        public async Task<List<Persona>> ObtenerPersonasList()
        {
            try
            {
                var personas = await Context.Personas.Include(x => x.Provincia).ToListAsync();

                return personas;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public async Task<Persona> ObtenerPersona(int id)
        {
            try
            {
                var persona = await Context.Personas.Where(x => x.Id == id).FirstAsync();
                return persona;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task<Persona> AgregarPersona(Persona persona)
        {
            try
            {
                //var existe = Context.Personas.Any(x => x.Dni == persona.Dni);

                //if (existe) throw new Exception("Se ha ingresado una persona con un DNI existente en la base de datos.");

                persona.FechaAlta = DateTime.Now;
                var resultado = await Context.Personas.AddAsync(persona);

                await Context.SaveChangesAsync();

                return resultado.Entity;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task<Persona> ModificarPersona(Persona persona)
        {
            try
            {
                persona.FechaModificacion = DateTime.Now;
                
                Context.Entry(persona).State = EntityState.Modified;

                Context.Entry(persona).Property(p => p.FechaAlta).IsModified = false;

                await Context.SaveChangesAsync();

                return persona;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task<Persona?> EliminarPersona(int id)
        {
            try
            {
                var persona = Context.Personas.Where(x => x.Id == id).First();

                if (persona == null) return null;

                persona.FechaBaja = DateTime.Now;

                await Context.SaveChangesAsync();

                return persona;

            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
