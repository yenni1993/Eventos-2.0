using CapacitacionYenni.DTO;

namespace CapacitacionYenni.Interfaces
{
    /// <summary>
    /// Interface IObtenerMensajeEvento.
    /// </summary>
    public interface IObtenerMensajeEvento
    {
        /// <summary>
        /// Método que obtiene el mensaje del evento.
        /// </summary>
        /// <param name="_entEventoDTO">DTO con información del evento.</param>
        /// <param name="_cTiempoTranscurrido">Tiempo transcurrido en formato meses, dias, horas o minutos.</param>
        /// <returns>Mensaje del evento.</returns>
        string ObtenerMensajeEvento(EventoDTO _entEventoDTO, string _cTiempoTranscurrido);
    }
}
