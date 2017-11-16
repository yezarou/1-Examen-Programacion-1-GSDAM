/*============================================================================================
 * HECHO POR:                   Rubén Zúñiga García
 * FECHA DE REALIZACIÓN:        16/11/2017
 * VERSIÓN:                     1.0
 * DESCRIPCIÓN:                 Ejercicio 3, programa con una función que calcula el horoscopo
 *                              base a tu fecha de nacimiento
 *============================================================================================*/

using System;

namespace Eje_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de una variable fecha.
            DateTime fecha = new DateTime();

            // Información mostrada en pantalla del programa.
            Console.Clear();
            Console.WriteLine("=========");
            Console.WriteLine("HOROSCOPO");
            Console.WriteLine("=========");
            Console.WriteLine();
            Console.WriteLine("Este programa calculará el horoscopo en base a la fecha de tu nacimiento.");
            Console.WriteLine("El formato para introducir tú fecha de nacimiento debe ser: DD/MM/YYYY");
            Console.WriteLine("DD:      Día");
            Console.WriteLine("MM:      Mes");
            Console.WriteLine("YYYY:    Año");
            Console.WriteLine("\n=============================================================\n");

            // Introducción de la fecha con función que comprueba si la fecha no da error.
            Console.Write("¿Cual es tu fecha de nacimiento?: ");
            fecha = IntroduccionFecha();
            Console.WriteLine("\n=============================================================\n");

            // Resultado del horóscopo.
            Console.WriteLine("Naciste un {0}, y tu signo del horoscopo es: \"{1}\".", fecha.ToLongDateString(), Horoscopo(fecha));

            // Salida del programa.
            Console.WriteLine("\n=============================================================");
            Console.WriteLine("\n\nPresione una tecla para salir del programa.");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Función que devuelve un string del horóscopo según una fecha.
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        static string Horoscopo(DateTime fecha)
        {
            string signo = "";
            if ((fecha.Month == 01 && fecha.Day >= 20) || (fecha.Month == 02 && fecha.Day <= 18))
                signo = "Acuario";
            if ((fecha.Month == 02 && fecha.Day >= 19) || (fecha.Month == 03 && fecha.Day <= 20))
                signo = "Piscis";
            if ((fecha.Month == 03 && fecha.Day >= 21) || (fecha.Month == 04 && fecha.Day <= 19))
                signo = "Aries";
            if ((fecha.Month == 04 && fecha.Day >= 20) || (fecha.Month == 05 && fecha.Day <= 20))
                signo = "Tauro";
            if ((fecha.Month == 05 && fecha.Day >= 21) || (fecha.Month == 06 && fecha.Day <= 20))
                signo = "Géminis";
            if ((fecha.Month == 06 && fecha.Day >= 21) || (fecha.Month == 07 && fecha.Day <= 22))
                signo = "Cáncer";
            if ((fecha.Month == 07 && fecha.Day >= 23) || (fecha.Month == 08 && fecha.Day <= 22))
                signo = "Leo";
            if ((fecha.Month == 08 && fecha.Day >= 23) || (fecha.Month == 09 && fecha.Day <= 22))
                signo = "Virgo";
            if ((fecha.Month == 09 && fecha.Day >= 23) || (fecha.Month == 10 && fecha.Day <= 22))
                signo = "Libra";
            if ((fecha.Month == 10 && fecha.Day >= 23) || (fecha.Month == 11 && fecha.Day <= 21))
                signo = "Escorpio";
            if ((fecha.Month == 11 && fecha.Day >= 22) || (fecha.Month == 12 && fecha.Day <= 21))
                signo = "Sagitario";
            if ((fecha.Month == 12 && fecha.Day >= 22) || (fecha.Month == 01 && fecha.Day <= 19))
                signo = "Capricornio";
            return signo;
        }

        /// <summary>
        /// Función que hace al usuario escribir una fecha hasta que sea una fecha valida.
        /// </summary>
        /// <returns></returns>
        static DateTime IntroduccionFecha()
        {
            DateTime fecha = new DateTime();
            bool correcto = false;
            do
                try
                {
                    fecha = DateTime.Parse(Console.ReadLine());
                    correcto = true;
                }
                catch (ArgumentNullException e1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR: No ha introducido ningún valor.");
                    Console.WriteLine(e1.Message);
                    Console.ResetColor();
                    Console.Write("\nIntroduzca una nueva fecha: ");
                }
                catch (FormatException e2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR: El valor introducido no es valido para un DateTime o es una fecha no existente.");
                    Console.WriteLine(e2.Message);
                    Console.ResetColor();
                    Console.Write("\nIntroduzca una nueva fecha: ");
                }
                catch (Exception e3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR no contemplado.");
                    Console.WriteLine(e3.Message);
                    Console.ResetColor();
                    Console.Write("\nIntroduzca una nueva fecha: ");
                }
            while (!correcto);
            return fecha;
        }
    }
}
