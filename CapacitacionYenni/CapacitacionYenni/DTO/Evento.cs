using System;

namespace CapacitacionYenni.DTO
{
    /// <summary>
    /// Clase Evento.
    /// </summary>
    public class EventoDTO
    {
        /// <summary>
        /// Título del evento.
        /// </summary>
        public string cTituloEvento { get; set; }
        
        /// <summary>
        /// Fecha del evento.
        /// </summary>
        public DateTime dtFechaEvento { get; set; }

        /// <summary>
        /// Fecha actual.
        /// </summary>
        public DateTime dtFechaActual { get; set; }
    }
}
