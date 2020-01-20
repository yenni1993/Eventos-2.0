using CapacitacionYenni.Clases;
using CapacitacionYenni.DTO;
using CapacitacionYenni.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebasUnitarias.Clases
{
    [TestClass]
    public class ObtenerMensajeEventoUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerMensajeEvento_EventoPasadoDadoFechaActual_MensajeEventoPasado()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cMensajeEvento = string.Empty;
            string cTiempoTranscurrido = string.Empty;
            IObtenerMensajeEvento IObtenerMensajeEvento = new ObtenerMensajeEvento();

            EventoDTO eventoDTO = new EventoDTO();
            eventoDTO.cTituloEvento = "Reyes Magos";
            eventoDTO.dtFechaActual = new DateTime(2020, 01, 18, 12, 00, 00);
            eventoDTO.dtFechaEvento = new DateTime(2020, 01, 06, 12, 00, 00);
            cTiempoTranscurrido = "12 días";

            //Act
            //Método que será sometido a pruebas.
            cMensajeEvento = IObtenerMensajeEvento.ObtenerMensajeEvento(eventoDTO, cTiempoTranscurrido);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual($"{eventoDTO.cTituloEvento} ocurrió hace {cTiempoTranscurrido}", cMensajeEvento);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerMensajeEvento_EventoFuturoDadoFechaActual_MensajeEventoFuturo()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cMensajeEvento = string.Empty;
            string cTiempoTranscurrido = string.Empty;
            IObtenerMensajeEvento IObtenerMensajeEvento = new ObtenerMensajeEvento();

            EventoDTO eventoDTO = new EventoDTO();
            eventoDTO.cTituloEvento = "Primavera";
            eventoDTO.dtFechaActual = new DateTime(2020, 01, 18, 12, 00, 00);
            eventoDTO.dtFechaEvento = new DateTime(2020, 03, 21, 12, 00, 00);
            cTiempoTranscurrido = "2 meses";

            //Act
            //Método que será sometido a pruebas.
            cMensajeEvento = IObtenerMensajeEvento.ObtenerMensajeEvento(eventoDTO, cTiempoTranscurrido);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual($"{eventoDTO.cTituloEvento} ocurrirá dentro de {cTiempoTranscurrido}", cMensajeEvento);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerMensajeEvento_EventoPresenteDadoFechaActual_NingunMensajeEvento()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cMensajeEvento = string.Empty;
            string cTiempoTranscurrido = string.Empty;
            IObtenerMensajeEvento IObtenerMensajeEvento = new ObtenerMensajeEvento();

            EventoDTO eventoDTO = new EventoDTO();
            eventoDTO.cTituloEvento = "Ninguno";
            eventoDTO.dtFechaActual = new DateTime(2020, 01, 18, 12, 00, 00);
            eventoDTO.dtFechaEvento = new DateTime(2020, 01, 18, 12, 00, 00);
            cTiempoTranscurrido = "0 minutos";

            //Act
            //Método que será sometido a pruebas.
            cMensajeEvento = IObtenerMensajeEvento.ObtenerMensajeEvento(eventoDTO, cTiempoTranscurrido);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(string.Empty, cMensajeEvento);
        }
    }
}
