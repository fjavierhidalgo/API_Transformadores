using MediatR;
using NetCoreAPIYFrontBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.SiniestrosHogar.Application.Transformadores.Queries
{
    public class GetTransformadorByIdQuery : IRequest<DatosTransformadoresDto>
    {
        public GetTransformadorByIdQuery(int transformadorId)
        {
            TransformadorId = transformadorId;
        }
        public int TransformadorId{ get; set; }
    }

}
