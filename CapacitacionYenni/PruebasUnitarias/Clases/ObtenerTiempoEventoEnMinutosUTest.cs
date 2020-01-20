using CapacitacionYenni.Clases;
using CapacitacionYenni.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebasUnitarias.Clases
{
    [TestClass]
    public class ObtenerTiempoEventoEnMinutosUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerTiempoTranscurrido_MinutoEventoMenorMinutoActual_DevuelveTotalMesesTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 50, 00);
            DateTime dtFechaEvento = new DateTime(2020, 01, 18, 12, 10, 00);
            IObtenerTiempoEvento IObtenerTiempoEventoEnMinutos = new ObtenerTiempoEventoEnMinutos();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEvento);
            cTiempoTranscurrido = IObtenerTiempoEventoEnMinutos.ObtenerTiempoTranscurrido(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("40 minutos", cTiempoTranscurrido);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerTiempoTranscurrido_MinutoEventoMayorMinutoActual_DevuelveTotalMesesTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 30, 00);
            DateTime dtFechaEvento = new DateTime(2020, 01, 22, 12, 50, 00);
            IObtenerTiempoEvento IObtenerTiempoEventoEnMinutos = new ObtenerTiempoEventoEnMinutos();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEvento);
            cTiempoTranscurrido = IObtenerTiempoEventoEnMinutos.ObtenerTiempoTranscurrido(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("20 minutos", cTiempoTranscurrido);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerTiempoTranscurrido_MinutoEventoIgualMinutoActual_DevuelveCeroMinutosTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 30, 00);
            DateTime dtFechaEvento = new DateTime(2020, 01, 18, 12, 30, 00);
            IObtenerTiempoEvento IObtenerTiempoEventoEnMinutos = new ObtenerTiempoEventoEnMinutos();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEvento);
            cTiempoTranscurrido = IObtenerTiempoEventoEnMinutos.ObtenerTiempoTranscurrido(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("0 minutos", cTiempoTranscurrido);
        }
    }
}
