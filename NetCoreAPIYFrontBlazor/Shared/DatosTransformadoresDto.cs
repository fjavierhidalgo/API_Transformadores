
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
            transformadores = new List<TransformadorDto>();
        }

        public List<TransformadorDto> transformadores { get; set; }
    }

    public class TransformadorDto
    {
        public int id { get; set; } = 0;
        public string? nombre { get; set; } = "";
        public string? referencia { get; set; } = "";
        public string? detalle { get; set; } = "";


    }

}
