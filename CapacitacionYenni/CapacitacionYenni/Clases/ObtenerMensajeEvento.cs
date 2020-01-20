using CapacitacionYenni.DTO;
using CapacitacionYenni.Interfaces;

namespace CapacitacionYenni.Clases
{
    /// <summary>
    /// Clase ObtenerMensajeEvento que implementa de la interface IObtenerMensajeEvento.
    /// </summary>
    public class ObtenerMensajeEvento : IObtenerMensajeEvento
    {
        /// <summary>
        /// Método que prepara el mensaje del evento.
        /// </summary>
        /// <param name="_entEventoDTO">DTO con información del evento.</param>
        /// <param name="_cTiempoTranscurrido">Tiempo transcurrido en formato meses, dias, horas o minutos.</param>
        /// <returns>Mensaje del evento.</returns>
        string IObtenerMensajeEvento.ObtenerMensajeEvento(EventoDTO _entEventoDTO, string _cTiempoTranscurrido)
        {
            string cMensajeEvento = string.Empty;
            string cTiempoTranscurridoEvento = string.Empty;
            string cTiempoPasadoEvento = "ocurrió hace";
            string cTiempoFuturoEvento = "ocurrirá dentro de";

            if (_entEventoDTO != null)
            {
                cTiempoTranscurridoEvento = (_entEventoDTO.dtFechaActual > _entEventoDTO.dtFechaEvento) ? cTiempoPasadoEvento
                   : (_entEventoDTO.dtFechaActual < _entEventoDTO.dtFechaEvento) ? cTiempoFuturoEvento : string.Empty;

                cMensajeEvento = $"{_entEventoDTO.cTituloEvento} {cTiempoTranscurridoEvento} {_cTiempoTranscurrido}";
            }

            return cMensajeEvento;
        }
    }
}
