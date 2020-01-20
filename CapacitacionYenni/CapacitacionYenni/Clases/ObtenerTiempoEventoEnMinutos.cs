using CapacitacionYenni.Interfaces;
using System;

namespace CapacitacionYenni.Clases
{
    /// <summary>
    /// Clase ObtenerTiempoEventoEnMinutos que implementa de la interface IConvertirTiempoEvento.
    /// </summary>
    public class ObtenerTiempoEventoEnMinutos : IObtenerTiempoEvento
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
        /// Método que obtiene el tiempo transcurrido del evento en minutos.
        /// </summary>
        /// <param name="_tsDiferenciaFecha">Intervalo de tiempo del evento.</param>
        /// <returns>Tiempo transcurrido del evento.</returns>
        public string ObtenerTiempoTranscurrido(TimeSpan _tsDiferenciaFecha)
        {
            int iTotalMinutos = Math.Abs(_tsDiferenciaFecha.Minutes);
            string cResultado = string.Empty;
            cResultado = $"{iTotalMinutos} minutos";
            return cResultado;
        }
    }
}
