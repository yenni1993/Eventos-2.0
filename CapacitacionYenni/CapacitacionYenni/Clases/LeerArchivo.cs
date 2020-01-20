using CapacitacionYenni.Interfaces;
using System.IO;

namespace CapacitacionYenni.Clases
{
    public class LeerArchivo : ILeerArchivo
    {
        string[] ILeerArchivo.LeerArchivo(string _cRutaArchivo)
        {
            string[] lstLineasArchivo = null;

            if (File.Exists(_cRutaArchivo)) {
                lstLineasArchivo  = File.ReadAllLines(_cRutaArchivo);
            }

            return lstLineasArchivo;
        }
    }
}

