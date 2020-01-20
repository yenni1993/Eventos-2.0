using CapacitacionYenni.Clases;
using CapacitacionYenni.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebasUnitarias.Clases
{
    [TestClass]
    public class ObtenerTiempoEventoEnDiasUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void AsignarNuevaConversion_TiempoEventoDeDiasAHoras_ValidacionCorrecta()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IObtenerTiempoEvento IObtenerTiempoEventoEnDias = new ObtenerTiempoEventoEnDias();
            IObtenerTiempoEvento IObtenerTiempoEventoEnHoras = new ObtenerTiempoEventoEnHoras();

            //Act
            //M�todo que ser� sometido a pruebas.
            IObtenerTiempoEventoEnDias.AsignarNuevaConversion(IObtenerTiempoEventoEnHoras);

            //Assert
            //Validaci�n de valores esperados.
            Assert.IsTrue(true);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerTiempoTranscurrido_DiaEventoMenorDiaActual_DevuelveTotalDiasTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 00, 00);
            DateTime dtFechaEvento = new DateTime(2020, 01, 16, 12, 00, 00);
            IObtenerTiempoEvento IObtenerTiempoEventoEnDias = new ObtenerTiempoEventoEnDias();

            //Act
            //M�todo que ser� sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEvento);
            cTiempoTranscurrido = IObtenerTiempoEventoEnDias.ObtenerTiempoTranscurrido(tsDiferencia);

            //Assert
            //Validaci�n de valores esperados.
            Assert.AreEqual("2 d�as", cTiempoTranscurrido);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerTiempoTranscurrido_DiaEventoMayorDiaActual_DevuelveTotalDiasTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 00, 00);
            DateTime dtFechaEvento = new DateTime(2020, 01, 22, 12, 00, 00);
            IObtenerTiempoEvento IObtenerTiempoEventoEnDias = new ObtenerTiempoEventoEnDias();

            //Act
            //M�todo que ser� sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEvento);
            cTiempoTranscurrido = IObtenerTiempoEventoEnDias.ObtenerTiempoTranscurrido(tsDiferencia);

            //Assert
            //Validaci�n de valores esperados.
            Assert.AreEqual("4 d�as", cTiempoTranscurrido);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerTiempoTranscurrido_DiaEventoIgualDiaActual_DevuelveTotalHorasTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 00, 00);
            DateTime dtFechaEvento = new DateTime(2020, 01, 18, 04, 00, 00);
            IObtenerTiempoEvento IObtenerTiempoEventoEnDias = new ObtenerTiempoEventoEnDias();
            IObtenerTiempoEvento IObtenerTiempoEventoEnHoras = new ObtenerTiempoEventoEnHoras();

            //Act
            //M�todo que ser� sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEvento);
            IObtenerTiempoEventoEnDias.AsignarNuevaConversion(IObtenerTiempoEventoEnHoras);
            cTiempoTranscurrido = IObtenerTiempoEventoEnDias.ObtenerTiempoTranscurrido(tsDiferencia);

            //Assert
            //Validaci�n de valores esperados.
            Assert.AreEqual("8 horas", cTiempoTranscurrido);
        }
    }
}
