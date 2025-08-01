
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIYFrontBlazor.Server.Domain
{
    
    public class Transformador
    {
        public int Id { get; set; }
        public string ?Nombre { get; set; }
        public string ?Referencia { get; set; }
        public string? Detalle { get; set; }

        public InputData? InputData { get; set; }


    }

}
