using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Responses
{
    public class GetPersonaResponse
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Dni { get; set; }
        public string Telefono { get; set; }
        public int IdProvincia { get; set; }
        public GetProvinciaResponse Provincia { get; set; }
    }
}
