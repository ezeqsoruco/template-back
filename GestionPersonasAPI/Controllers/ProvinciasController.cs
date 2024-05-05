using AutoMapper;
using BaseDeDatos.Repository;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Responses;
using Services.IRepository;

namespace GestionPersonasAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProvinciasController : ControllerBase
    {
        private readonly IProvinciaRepository _provinciaRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public ProvinciasController(IProvinciaRepository provinciaRepository, IMapper mapper, ILogger<ProvinciasController> logger)
        {
            _provinciaRepository = provinciaRepository;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<Result<GetProvinciasListResponse>>> GetProvincias()
        {
            try
            {
                var resultado = new Result<GetProvinciasListResponse>();
                var provincias = await _provinciaRepository.GetProvincias();

                resultado.Return = _mapper.Map<GetProvinciasListResponse>(provincias);

                return Ok(resultado);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error al obtener provincias.");
                return BadRequest(e.Message);
            }

        }
    }
}
