using BaseDeDatos.Repository;
using Microsoft.AspNetCore.Mvc;
using Models.Responses;
using Services.IRepository;

namespace GestionPersonasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonasController : ControllerBase
    {
        private readonly IPersonaReposotory _personaRepository;

        public PersonasController(IPersonaReposotory personaRepository)
        {
            _personaRepository = personaRepository;
        }

        //[HttpGet]
        //public async Task<ActionResult<GetProvinciasListResponse>> GetProvincias()
        //{
        //    var resultado = _personaRepository.GetProvincias();

        //    return Ok(resultado);
        //}
    }
}
