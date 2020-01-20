using CapacitacionYenni.Interfaces;
using System;

namespace CapacitacionYenni.Clases
{
    /// <summary>
    /// Clase ObtenerTiempoEventoEnDias que implementa de la interface IConvertirTiempoEvento.
    /// </summary>
    public class ObtenerTiempoEventoEnDias : IObtenerTiempoEvento
    {
        IObtenerTiempoEvento IConvertirTiempoEvento;

        /// <summary>
        /// Método que asigna una nueva conversión del tiempo transcurrido del evento.
        /// </summary>
        /// <param name="_IConvertirTiempoEvento">Interface para convertir el tiempo transcurrido del evento.</param>
        public void AsignarNuevaConversion(IObtenerTiempoEvento _IConvertirTiempoEvento)
        {
            this.IConvertirTiempoEvento = _IConvertirTiempoEvento;
        }

        /// <summary>
        /// Método que obtiene el tiempo transcurrido del evento en días.
        /// </summary>
        /// <param name="_tsDiferenciaFecha">Intervalo de tiempo del evento.</param>
        /// <returns>Tiempo transcurrido del evento.</returns>
        public string ObtenerTiempoTranscurrido(TimeSpan _tsDiferenciaFecha)
        {
            int iTotalDias = Math.Abs(_tsDiferenciaFecha.Days);
            string cResultado = string.Empty;

            if (iTotalDias > 0)
            {
                cResultado = $"{iTotalDias} días";
            }
            else
            {
                cResultado = this.IConvertirTiempoEvento.ObtenerTiempoTranscurrido(_tsDiferenciaFecha);
            }

            return cResultado;
        }
    }
}
