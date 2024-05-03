using AutoMapper;
using BaseDeDatos.Repository;
using Microsoft.AspNetCore.Mvc;
using Models.Responses;
using Services.IRepository;

namespace GestionPersonasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProvinciasController : ControllerBase
    {
        private readonly IProvinciaRepository _provinciaRepository;
        private readonly IMapper _mapper;

        public ProvinciasController(IProvinciaRepository provinciaRepository, IMapper mapper)
        {
            _provinciaRepository = provinciaRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<GetProvinciasListResponse>> GetProvincias()
        {
            try
            {
                var provincias = await _provinciaRepository.GetProvincias();

                var resultado = _mapper.Map<GetProvinciasListResponse>(provincias);

                return Ok(resultado);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
