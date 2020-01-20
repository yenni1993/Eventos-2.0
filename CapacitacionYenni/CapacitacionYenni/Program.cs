using System;
using System.Collections.Generic;

namespace CapacitacionYenni
{
    public class Program
    {
        /// <summary>
        /// Método principal del programa.
        /// </summary>
        /// <param name="args">Arreglo de argumentos.</param>
        public static void Main(string[] args)
        {
            List<string> lstEventos = new List<string>();
            Console.WriteLine("APLICACIÓN DE EVENTOS");
            Console.Write("\n");
            EjecutarAplicacionEventos oEjecutarAplicacionEvento = new EjecutarAplicacionEventos();
            oEjecutarAplicacionEvento.EjecutarEventos();
            Console.ReadLine();
        }
    }
}
