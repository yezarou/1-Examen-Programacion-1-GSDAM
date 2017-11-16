/*============================================================================================
 * HECHO POR:                   Rubén Zúñiga García
 * FECHA DE REALIZACIÓN:        16/11/2017
 * VERSIÓN:                     1.0
 * DESCRIPCIÓN:                 Ejercicio 2, programa con una función recursiva e iterativa que
 *                              calcula los numeros enteros comprendidos entre dos numeros.
 *============================================================================================*/

using System;

namespace Eje_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introducción de variables.
            uint valorInicial = 0;
            uint valorFinal = 0;
            bool correcto = false;

            // Información del programa.
            Console.Clear();
            Console.WriteLine("Suma de los numeros enteros comprendidos entre dos números.");
            Console.WriteLine("===========================================================\n");
            
            // Introducción de variables gracias a una función que comprueba si es una variable correcta.
            do
            {
                Console.Write("Escribe el valor mínimo: ");
                valorInicial = IntroduccionUInt();
                Console.Write("Escribe el valor máximo: ");
                valorFinal = IntroduccionUInt();

                if (valorFinal < valorInicial)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEl número inicial no puede ser mayor que el final. Vuelva a introducir los valores.\n");
                    Console.ResetColor();
                }
                else
                    correcto = true;
            } while (!correcto);

            // Resultado de ambas funciones.
            Console.WriteLine("\n=============================================================\n");
            Console.WriteLine("La suma de los enteros entre \"{0}\" y \"{1}\" es:", valorInicial, valorFinal);
            Console.WriteLine("Recursiva: "+SumaNumerosRecursivo(valorInicial, valorFinal));
            Console.WriteLine("Iterativa: "+SumaNumerosIterativo(valorInicial, valorFinal));
            Console.WriteLine("\n=============================================================");

            // Salida del programa.
            Console.WriteLine("\n\nPresione una tecla para salir del programa.");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Función iterativa que dados dos parametros UINT, devuelve un UINT de la suma de todos los numeros comprendidos entre ambos.
        /// </summary>
        /// <param name="valorMenor"></param>
        /// <param name="valorMayor"></param>
        /// <returns></returns>
        static uint SumaNumerosIterativo(uint valorMenor, uint valorMayor)
        {
            uint resultado = 0;
            for (uint i = valorMenor; i <= valorMayor; i++)
                resultado += i;
            return resultado;
        }

        /// <summary>
        /// Función recursiva que dados dos parametros UINT, devuelve un UINT de la suma de todos los numeros comprendidos entre ambos.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static uint SumaNumerosRecursivo(uint x, uint y)
        {
            return y == x ? x : y + SumaNumerosRecursivo(x, y - 1 );
        }

        /// <summary>
        /// Función que hace al usuario escribir un número UINT hasta que sea un UINT valido.
        /// </summary>
        /// <returns></returns>
        static uint IntroduccionUInt()
        {
            uint valorAComprobar = 0;
            bool correcto = false;
            do
                try
                {
                    valorAComprobar = uint.Parse(Console.ReadLine());
                    correcto = true;
                }
                catch (ArgumentNullException e1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR: No ha introducido ningún valor.");
                    Console.WriteLine(e1.Message);
                    Console.ResetColor();
                    Console.Write("\nIntroduzca un nuevo valor: ");
                }
                catch (OverflowException e2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR: El número es demasiado grande o demasiado pequeño para un UInt.");
                    Console.WriteLine(e2.Message);
                    Console.ResetColor();
                    Console.Write("\nIntroduzca un nuevo valor: ");
                }
                catch (FormatException e3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR: El valor introducido no es valido para un UInt.");
                    Console.WriteLine(e3.Message);
                    Console.ResetColor();
                    Console.Write("\nIntroduzca un nuevo valor: ");
                }
                catch (Exception e4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR no contemplado.");
                    Console.WriteLine(e4.Message);
                    Console.ResetColor();
                    Console.Write("\nIntroduzca un nuevo valor: ");
                }
            while (!correcto);
            return valorAComprobar;
        }
    }
}
