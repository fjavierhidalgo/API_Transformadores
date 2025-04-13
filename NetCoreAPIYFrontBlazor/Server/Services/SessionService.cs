using NetCoreAPIYFrontBlazor.Server.Application.Interfaces;

using System.Security.Claims;

namespace NetCoreAPIYFrontBlazor.Server.Services;

public class SessionService : ISessionService
{
    public SessionService(IHttpContextAccessor httpContextAccessor, IWebHostEnvironment env)
    {
        UsuarioId = httpContextAccessor.HttpContext?.User?.Identity?.Name ?? "030112";
        Roles = httpContextAccessor.HttpContext?.User?.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value).ToArray();
        string authHeader = httpContextAccessor.HttpContext.Request.Headers["Authorization"];

        if (authHeader is not null && authHeader.StartsWith("Bearer"))
        {
            //Extract credentials
            Token = authHeader.Substring("Bearer".Length + 1);
        }
        Environment = env.EnvironmentName;
    }

    public string UsuarioId { get; }

    public string[] Roles { get; }

    public string Token { get; }

    public string Environment { get; set; }

}
