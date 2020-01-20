using CapacitacionYenni.Clases;
using CapacitacionYenni.DTO;
using CapacitacionYenni.Interfaces;
using System;
using System.Collections.Generic;

namespace CapacitacionYenni
{
    /// <summary>
    /// Clase EjecutarAplicacionEventos.
    /// </summary>
    public class EjecutarAplicacionEventos
    {
        public void EjecutarEventos()
        {
            string cResultado = string.Empty;
            string cRutaArchivo = @"C:\Eventos.txt";
            string cTiempoConvertido = string.Empty;
            string[] arrLineasArchivo = null;
            TimeSpan tsDiferencia = new TimeSpan();
            IConvertirTiempoEvento IConvertirTiempoEnMeses = new ConvertirTiempoEventoEnMeses();
            IConvertirTiempoEvento IConvertirTiempoEnDias = new ConvertirTiempoEventoEnDias();
            IConvertirTiempoEvento IConvertirTiempoEnHoras = new ConvertirTiempoEventoEnHoras();
            IConvertirTiempoEvento IConvertirTiempoEnMinutos = new ConvertirTiempoEventoEnMinutos();
            IObtenerMensajeEvento IPrepararMensajeEvento;
            ILeerArchivo ILeerArchivo = new LeerArchivo();

            IConvertirTiempoEnMeses.AsignarNuevaConversion(IConvertirTiempoEnDias);
            IConvertirTiempoEnDias.AsignarNuevaConversion(IConvertirTiempoEnHoras);
            IConvertirTiempoEnHoras.AsignarNuevaConversion(IConvertirTiempoEnMinutos);
            arrLineasArchivo = ILeerArchivo.LeerArchivo(cRutaArchivo);

            foreach (string cLineaArchivo in arrLineasArchivo)
            {
                EventoDTO eventoDTO = new EventoDTO();
                eventoDTO.cTituloEvento = cLineaArchivo.Split(',')[0];
                eventoDTO.dtFechaEvento = Convert.ToDateTime(cLineaArchivo.Split(',')[1]);
                eventoDTO.dtFechaActual = DateTime.Now;

                tsDiferencia = (eventoDTO.dtFechaActual - eventoDTO.dtFechaEvento);  
                cTiempoConvertido = IConvertirTiempoEnMeses.ConvertirTiempo(tsDiferencia);

                IPrepararMensajeEvento = new ObtenerMensajeEvento();
                cResultado = IPrepararMensajeEvento.ObtenerMensajeEvento(eventoDTO, cTiempoConvertido);
                Console.WriteLine(cResultado);
            }
        }
    }
}
