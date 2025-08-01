using MediatR;
using NetCoreAPIYFrontBlazor.Server.Domain;
using NetCoreAPIYFrontBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.SiniestrosHogar.Application
{
    public class GetInputDataByReferenciaQuery : IRequest<InputDataDto>
    {
        public GetInputDataByReferenciaQuery(string transformadorRef)
        {
            TransformadorRef = transformadorRef;
        }
        public string TransformadorRef{ get; set; }
    }

}
