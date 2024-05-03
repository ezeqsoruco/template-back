using AutoMapper;
using Models.Entities;
using Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Mapping
{
    public class ProvinciaMap: Profile
    {
        public ProvinciaMap()
        {
            CreateMap<Provincia, GetProvinciaResponse>();

            CreateMap<List<Provincia>, GetProvinciasListResponse>()
                .ForMember(dest => dest.Provincias, opt => opt.MapFrom(src => src));
        }
    }
}
