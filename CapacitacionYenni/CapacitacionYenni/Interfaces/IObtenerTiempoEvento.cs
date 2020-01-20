using System;

namespace CapacitacionYenni.Interfaces
{
    /// <summary>
    /// Interface IObtenerTiempoEvento.
    /// </summary>
    public interface IObtenerTiempoEvento
    {
        /// <summary>
        /// Método que asigna una nueva conversión del tiempo transcurrido del evento.
        /// </summary>
        /// <param name="_IConvertirTiempoEvento">Interface para convertir el tiempo transcurrido del evento.</param>
        void AsignarNuevaConversion(IObtenerTiempoEvento _IConvertirTiempoEvento);

        /// <summary>
        /// Método que obtiene el tiempo transcurrido del evento.
        /// </summary>
        /// <param name="_tsDiferenciaFecha">Intervalo de tiempo del evento.</param>
        /// <returns>Tiempo transcurrido del evento.</returns>
        string ObtenerTiempoTranscurrido(TimeSpan _tsDiferenciaFecha);
    }
}
