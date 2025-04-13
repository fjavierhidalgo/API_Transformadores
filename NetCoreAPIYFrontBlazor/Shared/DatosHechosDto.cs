
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIYFrontBlazor.Shared
{
    
    public class DatosHechosDto
    {
        public DatosHechosDto()
        {
            hechos = new List<HechoDto>();
        }

        public List<HechoDto> hechos { get; set; }
    }

    public class HechoDto
    {
        public int id { get; set; }
        public string ?nombre { get; set; }
        public int ?anio { get; set; }
        public string? descripcion { get; set; }


    }

}
