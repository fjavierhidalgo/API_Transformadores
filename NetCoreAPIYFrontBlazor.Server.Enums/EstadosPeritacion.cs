using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Diversos.Enums
{
    public class EstadosPeritacion
    {
        /// <summary>
        /// C - Estado Peritación Pendiente Contactar Asegurado
        /// </summary>
        public const string Pendiente_Contactar_Asegurado = "C";
        /// <summary>
        /// A - Estado Peritación Pendiente Agendar Visita
        /// </summary>
        public const string Pendiente_Agendar_Visita = "A";
        /// <summary>
        /// R - Estado Peritación Pendiente Reparacion
        /// </summary>
        public const string Pendiente_Reparacion = "R";
        /// <summary>
        /// R - Estado Peritación Pendiente Informe Cierre
        /// </summary>
        public const string Pendiente_Informe_Cierre = "I";
    }
}
