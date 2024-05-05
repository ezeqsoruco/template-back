using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Responses
{
    public class GetPersonasListResponse
    {
        public List<GetPersonaResponse> Personas { get; set; }
    }
}
