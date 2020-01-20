using System;

namespace CapacitacionYenni.Interfaces
{
    /// <summary>
    /// Interface IConvertirTiempoEvento.
    /// </summary>
    public interface IConvertirTiempoEvento
    {
        /// <summary>
        /// Método que asigna una nueva conversión del tiempo transcurrido del evento.
        /// </summary>
        /// <param name="_IConvertirTiempoEvento">Interface para convertir el tiempo transcurrido del evento.</param>
        void AsignarNuevaConversion(IConvertirTiempoEvento _IConvertirTiempoEvento);

        /// <summary>
        /// Método que convierte el tiempo transcurrido del evento.
        /// </summary>
        /// <param name="_tsDiferenciaFecha">Intervalo de tiempo del evento.</param>
        /// <returns>Tiempo transcurrido del evento.</returns>
        string ConvertirTiempo(TimeSpan _tsDiferenciaFecha);
    }
}
