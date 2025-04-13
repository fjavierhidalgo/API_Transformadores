using MediatR;
using NetCoreAPIYFrontBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.SiniestrosHogar.Application.Hechos.Queries.GetListaHechos

{
    public class GetListaHechosByAnioQuery : IRequest<DatosHechosDto>
    {
        public GetListaHechosByAnioQuery(int anio)
        {
            Anio = anio;
        }
        public int Anio { get; set; }

    }


}
