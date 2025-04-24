
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIYFrontBlazor.Shared
{
    
    public class DatosTransformadoresDto
    {
        public DatosTransformadoresDto()
        {
            Transformadores = new List<TransformadorDto>();
        }

        public List<TransformadorDto> Transformadores { get; set; }
    }

    public class TransformadorDto
    {
        public int id { get; set; }
        public string? nombre { get; set; }
        public string? referencia { get; set; }
        public string? detalle { get; set; }


    }

}
