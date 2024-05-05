using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.Requests;
using Models.Responses;
using Services.IRepository;

namespace GestionPersonasAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonasController : ControllerBase
    {
        private readonly IPersonaReposotory _personaRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public PersonasController(IPersonaReposotory personaRepository, IMapper mapper, ILogger<PersonasController> logger)
        {
            _personaRepository = personaRepository;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<GetPersonasListResponse>> GetPersonas()
        {
            try
            {
                var personas = await _personaRepository.GetPersonasList();

                var resultado = _mapper.Map<GetPersonasListResponse>(personas);

                return Ok(resultado);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error al obtener personas.", new { deatalle = e.InnerException?.Message });
                return BadRequest(new { error = "Error al obtener personas.", detalle = e.InnerException?.Message });
            }
        }

        [HttpPost]
        public async Task<ObjectResult> PostPersona(PostPersonaRequest request)
        {
            try
            {
                var persona = _mapper.Map<Persona>(request);

                var result = await _personaRepository.AgregarPersona(persona);

                if (result == null)
                {
                    return new ObjectResult(new { message = "Error al crear la persona." })
                    {
                        StatusCode = 500
                    };
                }

                var response = _mapper.Map<GetPersonaResponse>(result);

                return new ObjectResult(response)
                {
                    StatusCode = 201
                };
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error al registrar la persona.", new { deatalle = e.InnerException?.Message });
                return BadRequest(new { error = "Error al registrar la persona.", detalle = e.InnerException?.Message });
            }
        }

        [HttpPut]
        public async Task<ObjectResult> PutPersona(PostPersonaRequest request)
        {
            try
            {
                var persona = _mapper.Map<Persona>(request);

                var result = await _personaRepository.ModificarPersona(persona);

                if (result == null)
                {
                    return new ObjectResult(new { message = "Error al actualizar la persona." })
                    {
                        StatusCode = 500
                    };
                }

                var response = _mapper.Map<GetPersonaResponse>(result);

                return new ObjectResult(response)
                {
                    StatusCode = 201
                };
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error al actualizar la persona.", new { deatalle = e.InnerException?.Message });
                return BadRequest(new { error = "Error al actualizar la persona.", detalle = e.InnerException?.Message });
            }
        }

        [HttpDelete]
        public async Task<ObjectResult> DeletePersona(int id)
        {
            try
            {
                var result = await _personaRepository.EliminarPersona(id);

                if (result == null)
                {
                    return new ObjectResult(new { message = "No se encontró a la persona que se quiere eliminar." })
                    {
                        StatusCode = 304
                    };
                }

                var response = _mapper.Map<GetPersonaResponse>(result);

                return new ObjectResult(response)
                {
                    StatusCode = 201
                };
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error al eliminar la persona.", new { deatalle = e.InnerException?.Message });
                return BadRequest(new { error = "Error al eliminar la persona.", detalle = e.InnerException?.Message });
            }
        }
    }
}
