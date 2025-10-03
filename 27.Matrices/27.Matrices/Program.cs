using System;

namespace _27.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*27. Escribe un programa que realice la suma de dos matrices de dimensiones 2x3.
 
            Requisitos del programa:
            Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas.
            Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones (2x3).
            Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices.
            Muestra la matriz resultante de la suma en formato de matriz (2 filas, 3 columnas).*/

            int[,] matriz1 = new int[2, 3];
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el número para la matriz 1, en la posición con índices {i}, {j}:");
                    matriz1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[,] matriz2 = new int[2, 3];
            for (int s = 0; s < matriz2.GetLength(0); s++)
            {
                for (int m = 0; m < matriz2.GetLength(1); m++)
                {
                    Console.WriteLine($"Ingrese el número para la matriz 2, en la posición con índices {s}, {m}:");
                    matriz1[s, m] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] sumamatriz = new int[2, 3];
            for (int a = 0; a < sumamatriz.GetLength(0); a++)
            {
                for (int b = 0; b < sumamatriz.GetLength(1); b++)
                {
                    sumamatriz[a, b] = matriz1[a, b] + matriz2[a,b];
                    Console.Write($"{sumamatriz[a, b]} | ");
                }
            }

        }

    }
}
