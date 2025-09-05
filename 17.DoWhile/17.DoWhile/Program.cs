using System;

namespace _17.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que genere y calcule la suma de los 5 primeros números enteros positivos*/

            int contador = 0;
            int acumulador = 0;

            do
            {
                contador++;
                acumulador += contador;
            } while (contador < 5);

            Console.WriteLine($"La suma de los cinco primeros números enteris es: {acumulador}");

            /*17. Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10.
            Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar. */

            int numero = 0;
            int multiplicacion = 0; //contador
            string respuesta = " ";

            do
            {
                Console.WriteLine("Ingrese el número para ver su tabla de multplicación");
                numero = Convert.ToInt32(Console.ReadLine());
                do
                {
                    multiplicacion++;
                    Console.WriteLine($"{numero} * {multiplicacion} = {numero * multiplicacion}");
                } while (multiplicacion < 10);

                multiplicacion = 0; //Hay que reiniciar el valor del contador
                Console.WriteLine("¿Le gustaría generar otra tabla de multiplicar? (si/no)");
                respuesta = Console.ReadLine().ToLower(); //ToLower pone la cadena de caracteres en minúscula

            } while (respuesta == "si");
                
           
        }
    }
}
