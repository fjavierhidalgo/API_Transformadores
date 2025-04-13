using System;
namespace NetCoreAPIYFrontBlazor.Server.Application.Common
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string entidad, string id)
            : base($"No se ha encontrado la entidad '{entidad}' con id '{id}'.")
        {

        }
    }
}

