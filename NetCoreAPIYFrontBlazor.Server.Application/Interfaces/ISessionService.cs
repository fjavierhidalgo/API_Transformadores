using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NetCoreAPIYFrontBlazor.Server.Application.Interfaces;

public interface ISessionService
{
    string UsuarioId { get; }
    string[] Roles { get; }
    string Token { get; }
    string Environment { get; set; }
}