using AutoMapper;
using Models.Entities;
using Models.Requests;
using Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Mapping
{
    public class PersonaMap: Profile
    {
        public PersonaMap()
        {
            CreateMap<Persona, GetPersonaResponse>()
                .ForMember(dest => dest.IdProvincia, opt => opt.MapFrom(src => src.ProvinciaId));

            CreateMap<List<Persona>, GetPersonasListResponse>()
                .ForMember(dest => dest.Personas, opt => opt.MapFrom(src => src));

            CreateMap<PostPersonaRequest, Persona>()
                .ForMember(dest => dest.ProvinciaId, opt => opt.MapFrom(src => src.IdProvincia));
        }
    }
}
