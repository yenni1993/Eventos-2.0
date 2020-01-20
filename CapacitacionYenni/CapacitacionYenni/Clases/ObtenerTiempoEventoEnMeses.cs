using CapacitacionYenni.Interfaces;
using System;

namespace CapacitacionYenni.Clases
{
    /// <summary>
    /// Clase ObtenerTiempoEventoEnMeses que implementa de la interface IConvertirTiempoEvento.
    /// </summary>
    public class ObtenerTiempoEventoEnMeses : IObtenerTiempoEvento
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
        /// Método que obtiene el tiempo transcurrido del evento en meses.
        /// </summary>
        /// <param name="_tsDiferenciaFecha">Intervalo de tiempo del evento.</param>
        /// <returns>Tiempo transcurrido del evento.</returns>
        public string ObtenerTiempoTranscurrido(TimeSpan _tsDiferenciaFecha)
        {
            int iTotalMeses = 0;
            int iTotalDias = Math.Abs(_tsDiferenciaFecha.Days);
            string cResultado = string.Empty;

            if (iTotalDias >= 30)
            {
                iTotalMeses = iTotalDias / 30;
                cResultado = $"{iTotalMeses} meses";
            }
            else
            {
                cResultado = this.IConvertirTiempoEvento.ObtenerTiempoTranscurrido(_tsDiferenciaFecha);
            }

            return cResultado;
        }
    }
}