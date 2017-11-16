/*============================================================================================
 * HECHO POR:                   Rubén Zúñiga García
 * FECHA DE REALIZACIÓN:        16/11/2017
 * VERSIÓN:                     1.0
 * DESCRIPCIÓN:                 Ejercicio 1, programa que lee desde teclado N caracteres y, al
 *                              finalizar usando "*", devuelve el número de vocales 
 *                              introducido.
 *============================================================================================*/

using System;

namespace Eje_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables.
            ConsoleKeyInfo tecla;           // Tecla pulsada
            string lineaDeCaracteres = "";  // String de caracteres a analizar
            
            // Contadores para vocales y total de vocales.
            int contadorA = 0;
            int contadorE = 0;
            int contadorI = 0;
            int contadorO = 0;
            int contadorU = 0;
            int total = 0;

            // Información del programa.
            Console.Clear();
            Console.WriteLine("CONTADOR DE VOCALES");
            Console.WriteLine("===================");
            Console.WriteLine("Escriba una linea de caracteres, cuando quiera terminar presione \"*\" y verá en consola todas las vocales escritas.");
            Console.WriteLine();

            /* ======================================================================
             * Introducción de caracteres utilizando un ReadKey en un bucle do-while. 
             * Permite borrar con retroceso si es necesario 
             * ======================================================================*/
            Console.Write("Introduzca la linea de caracteres: ");
            do
            {
                tecla = Console.ReadKey(true);
                if (tecla.KeyChar > 32)
                {
                    Console.Write(tecla.KeyChar);
                    lineaDeCaracteres += tecla.KeyChar;
                }
                if (tecla.Key == ConsoleKey.Backspace && lineaDeCaracteres.Length > 0)
                {
                    Console.Write("\b \b");
                    lineaDeCaracteres = lineaDeCaracteres.Remove(lineaDeCaracteres.Length-1);
                }
            } while (tecla.KeyChar != '*');

            /* ======================================================================
             * ANALIZADOR DEL STRING CON EL RESULTADO. Analiza cada caracter escrito 
             * en el programa y, si se detecta como una vocal minúscula o mayuscula 
             * sin tilde, se suma en un contador. Todo caracter sin incluir "*" se 
             * cuenta en otro contador.
             * ======================================================================*/
            foreach (char caracter in lineaDeCaracteres)
            {
                switch (caracter)
                {
                    case 'a': case 'A':
                        contadorA++;
                        break;
                    case 'e': case 'E':
                        contadorE++;
                        break;
                    case 'i': case 'I':
                        contadorI++;
                        break;
                    case 'o': case 'O':
                        contadorO++;
                        break;
                    case 'u': case 'U':
                        contadorU++;
                        break;
                }
                if (caracter != '*')
                    total++;
            }

            // Resultado de todas las vocales con su correspondiente linea de almohadillas.
            Console.WriteLine("\n\n=============================================================\n");
            Console.WriteLine("a[{0}] -> {1}", contadorA, LineaAlmohadillas(contadorA));
            Console.WriteLine("e[{0}] -> {1}", contadorE, LineaAlmohadillas(contadorE));
            Console.WriteLine("i[{0}] -> {1}", contadorI, LineaAlmohadillas(contadorI));
            Console.WriteLine("o[{0}] -> {1}", contadorO, LineaAlmohadillas(contadorO));
            Console.WriteLine("u[{0}] -> {1}", contadorU, LineaAlmohadillas(contadorU));
            Console.WriteLine("\nEl total de caracteres es: {0}", total);

            Console.WriteLine("\n=============================================================");
            // Salida del programa.
            Console.WriteLine("\n\nPresione una tecla para salir del programa.");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Función que crea una linea de almohadillas del tamaño del int introducido como parametro.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static string LineaAlmohadillas (int n)
        {
            string almohadillas = "";
            for (int i = 0; i < n; i++)
            {
                almohadillas += "#";
            }
            return almohadillas;
        }
    }
}
