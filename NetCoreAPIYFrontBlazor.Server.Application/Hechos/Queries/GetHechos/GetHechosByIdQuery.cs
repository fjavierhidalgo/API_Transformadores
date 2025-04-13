using MediatR;
using NetCoreAPIYFrontBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.SiniestrosHogar.Application.Hechos.Queries.GetHechos
{
    public class GetHechosByIdQuery : IRequest<DatosHechosDto>
    {
        public GetHechosByIdQuery(int hechoId)
        {
            HechoId = hechoId;
        }
        public int HechoId{ get; set; }
    }

}
