using CapacitacionYenni.Clases;
using CapacitacionYenni.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebasUnitarias.Clases
{
    [TestClass]
    public class ObtenerTiempoEventoEnMesesUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void AsignarNuevaConversion_TiempoEventoDeMesesADias_ValidacionCorrecta()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IObtenerTiempoEvento IObtenerTiempoEventoEnMeses = new ObtenerTiempoEventoEnMeses();
            IObtenerTiempoEvento IObtenerTiempoEventoEnDias = new ObtenerTiempoEventoEnDias();

            //Act
            //Método que será sometido a pruebas.
            IObtenerTiempoEventoEnMeses.AsignarNuevaConversion(IObtenerTiempoEventoEnDias);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(true);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerTiempoTranscurrido_MesEventoMenorMesActual_DevuelveTotalMesesTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 00, 00);
            DateTime dtFechaEvento = new DateTime(2019, 11, 18, 12, 00, 00);
            IObtenerTiempoEvento IObtenerTiempoEventoEnMeses = new ObtenerTiempoEventoEnMeses();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEvento);
            cTiempoTranscurrido = IObtenerTiempoEventoEnMeses.ObtenerTiempoTranscurrido(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("2 meses", cTiempoTranscurrido);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerTiempoTranscurrido_MesEventoMayorMesActual_DevuelveTotalMesesTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 00, 00);
            DateTime dtFechaEvento = new DateTime(2020, 05, 18, 12, 00, 00);
            IObtenerTiempoEvento IObtenerTiempoEventoEnMeses = new ObtenerTiempoEventoEnMeses();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEvento);
            cTiempoTranscurrido = IObtenerTiempoEventoEnMeses.ObtenerTiempoTranscurrido(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("4 meses", cTiempoTranscurrido);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerTiempoTranscurrido_MesEventoIgualMesActual_DevuelveTotalDiasTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 00, 00);
            DateTime dtFechaEvento = new DateTime(2020, 01, 02, 12, 00, 00);
            IObtenerTiempoEvento IObtenerTiempoEventoEnMeses = new ObtenerTiempoEventoEnMeses();
            IObtenerTiempoEvento IObtenerTiempoEventoEnDias = new ObtenerTiempoEventoEnDias();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEvento);
            IObtenerTiempoEventoEnMeses.AsignarNuevaConversion(IObtenerTiempoEventoEnDias);
            cTiempoTranscurrido = IObtenerTiempoEventoEnMeses.ObtenerTiempoTranscurrido(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("16 días", cTiempoTranscurrido);
        }
    }
}
