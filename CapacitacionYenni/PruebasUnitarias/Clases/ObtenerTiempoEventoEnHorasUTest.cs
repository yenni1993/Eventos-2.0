using CapacitacionYenni.Clases;
using CapacitacionYenni.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebasUnitarias.Clases
{
    [TestClass]
    public class ObtenerTiempoEventoEnHorasUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void AsignarNuevaConversion_TiempoEventoDeHorasAMinutos_ValidacionCorrecta()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IObtenerTiempoEvento IObtenerTiempoEventoEnHoras = new ObtenerTiempoEventoEnHoras();
            IObtenerTiempoEvento IObtenerTiempoEventoEnMinutos = new ObtenerTiempoEventoEnMinutos();

            //Act
            //Método que será sometido a pruebas.
            IObtenerTiempoEventoEnHoras.AsignarNuevaConversion(IObtenerTiempoEventoEnMinutos);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(true);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerTiempoTranscurrido_HoraEventoMenorHoraActual_DevuelveTotalHorasTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 16, 00, 00);
            DateTime dtFechaEvento = new DateTime(2020, 01, 18, 12, 00, 00);
            IObtenerTiempoEvento IObtenerTiempoEventoEnHoras = new ObtenerTiempoEventoEnHoras();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEvento);
            cTiempoTranscurrido = IObtenerTiempoEventoEnHoras.ObtenerTiempoTranscurrido(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("4 horas", cTiempoTranscurrido);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerTiempoTranscurrido_HoraEventoMayorHoraActual_DevuelveTotalHorasTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 16, 00, 00);
            DateTime dtFechaEvento = new DateTime(2020, 01, 18, 22, 00, 00);
            IObtenerTiempoEvento IObtenerTiempoEventoEnHoras = new ObtenerTiempoEventoEnHoras();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEvento);
            cTiempoTranscurrido = IObtenerTiempoEventoEnHoras.ObtenerTiempoTranscurrido(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("6 horas", cTiempoTranscurrido);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerTiempoTranscurrido_HoraEventoIgualHoraActual_DevuelveTotalMinutosTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 10, 50, 00);
            DateTime dtFechaEvento = new DateTime(2020, 01, 18, 10, 20, 00);
            IObtenerTiempoEvento IObtenerTiempoEventoEnHoras = new ObtenerTiempoEventoEnHoras();
            IObtenerTiempoEvento IObtenerTiempoEventoEnMinutos = new ObtenerTiempoEventoEnMinutos();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEvento);
            IObtenerTiempoEventoEnHoras.AsignarNuevaConversion(IObtenerTiempoEventoEnMinutos);
            cTiempoTranscurrido = IObtenerTiempoEventoEnHoras.ObtenerTiempoTranscurrido(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("30 minutos", cTiempoTranscurrido);
        }
    }
}
