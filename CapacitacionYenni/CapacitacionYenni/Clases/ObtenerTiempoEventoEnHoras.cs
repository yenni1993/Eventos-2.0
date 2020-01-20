using CapacitacionYenni.Interfaces;
using System;

namespace CapacitacionYenni.Clases
{
    /// <summary>
    /// Clase ObtenerTiempoEventoEnHoras que implementa de la interface IConvertirTiempoEvento.
    /// </summary>
    public class ObtenerTiempoEventoEnHoras : IObtenerTiempoEvento
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
        /// Método que obtiene el tiempo transcurrido del evento en horas.
        /// </summary>
        /// <param name="_tsDiferenciaFecha">Intervalo de tiempo del evento.</param>
        /// <returns>Tiempo transcurrido del evento.</returns>
        public string ObtenerTiempoTranscurrido(TimeSpan _tsDiferenciaFecha)
        {
            int iTotalHoras = Math.Abs(_tsDiferenciaFecha.Hours);
            string cResultado = string.Empty;

            if(iTotalHoras > 0)
            {
                cResultado = $"{iTotalHoras} horas";
            }
            else
            {
                cResultado = this.IConvertirTiempoEvento.ObtenerTiempoTranscurrido(_tsDiferenciaFecha);
            }

            return cResultado;
        }
    }
}
