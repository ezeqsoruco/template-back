﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Responses
{
    public class GetProvinciasListResponse
    {
        public List<GetProvinciaResponse> Provincias { get; set; }

        public GetProvinciasListResponse() { }
    }
}
