namespace NetCoreAPIYFrontBlazor.Server.Domain;
public class Auditoria
{

    private Auditoria() { }

    public Auditoria(string entidad, string entidadId, string campoModificado, string? valorAnterior, string? valorNuevo, string usuarioModificacion)
    {
        EntidadModificada = entidad;
        EntidadModificadaId = entidadId;
        CampoModificado = campoModificado;
        ValorAnterior = valorAnterior;
        ValorNuevo = valorNuevo;
        UsuarioModificacion = usuarioModificacion;
        FechaModificacion = DateTime.Now;
    }

    public int Id { get; set; }
    public string EntidadModificada { get; set; }
    public string EntidadModificadaId { get; set; }
    public string CampoModificado { get; set; }
    public string? ValorAnterior { get; set; }
    public string? ValorNuevo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public string UsuarioModificacion { get; set; }

}

