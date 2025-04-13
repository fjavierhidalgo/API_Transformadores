
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIYFrontBlazor.Server.Domain
{
    
    public class Hecho
    {
        public int Id { get; set; }
        public string ?Nombre { get; set; }
        public int ?Anio { get; set; }
        public string? Detalle { get; set; }


    }

}
