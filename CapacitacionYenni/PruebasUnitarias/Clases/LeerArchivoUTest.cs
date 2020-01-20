using CapacitacionYenni.Clases;
using CapacitacionYenni.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias.Clases
{
    [TestClass]
    public class LeerArchivoUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void LeerArchivo_RutaCorrectaDelArchivo_DevuelveListaDatosArchivo()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cRutaArchivo = @"C:\Eventos.txt";
            string[] arrLineasArchivo = null;
            ILeerArchivo ILeerArchivo = new LeerArchivo();

            //Act
            //Método que será sometido a pruebas.
            arrLineasArchivo = ILeerArchivo.LeerArchivo(cRutaArchivo);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(arrLineasArchivo.Length > 0);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void LeerArchivo_RutaInCorrectaDelArchivo_NoDevuelveListaDatosArchivo()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cRutaArchivo = @"C:\EventosAAA.txt";
            string[] arrLineasArchivo = null;
            ILeerArchivo ILeerArchivo = new LeerArchivo();

            //Act
            //Método que será sometido a pruebas.
            arrLineasArchivo = ILeerArchivo.LeerArchivo(cRutaArchivo);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(arrLineasArchivo == null);
        }
    }
}
