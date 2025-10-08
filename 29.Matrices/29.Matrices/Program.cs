namespace _29.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por 
            pantalla la suma de los elementos de cada columna. */
            /*int[,] numeros = new int[10, 20];
            int[] sumaColumnas = new int[numeros.GetLength(1)];

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posicion [{i},{j}]:");
                    numeros[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.Write($"{numeros[i,j]} | ");
                }
                Console.WriteLine();
            }

            //recorrer la matriz para sumar los elementos de cada columna

            for(int i = 0; i < numeros.GetLength(1); i++)
            {
                for(int j = 0; j < numeros.GetLength(0); j++)
                {
                    sumaColumnas[i] += numeros[j, i];
                }
            }
            //Recorrer el vector y mostrar la suma de cada columna
            for (int i = 0; i < sumaColumnas.Length; i++)
            {
                Console.Write($"{sumaColumnas[i]} | ");
            }*/

            /*2. Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa 
            caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la 
            primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la 
            matriz con el intercambio de filas.*/
            /*int n = 0;
            int m = 0;
            Console.WriteLine("Ingrese la cantidad de filas que desea:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas que desea:");
            m = int.Parse(Console.ReadLine());

            char[,] matriz = new char[n,m];
            int fila1 = 0;
            int fila2 = n - 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posicion [{i},{j}]:");
                    matriz[i, j] = char.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matriz[i, j]} | ");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < m; j++)
            {
                (matriz[fila1, j], matriz[fila2, j]) = (matriz[fila2, j], matriz[fila1, j]);
            }

            Console.WriteLine("Matriz con filas intercambiadas:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matriz[i, j]} | ");
                }
                Console.WriteLine();
            }*/

            /*3. Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de 
            5x5 llena de números aleatorios. 
            El algoritmo debe permitir: 
            * Usa la función Random para generar los números aleatorios. 
            * Crea un arreglo adicional para almacenar la frecuencia de cada número. 
            * Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número */

            /*4. Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en 
            posiciones aleatorias. Luego, el algoritmo le debe permitir al usuario intentar adivinar la 
            posición de una "X".
            El algoritmo debe permitir: 
             Usar la función Random para colocar las "X" en la matriz. 
             Realizar 3 intentos para ingresar coordenadas y verificar si ha acertado. 
             Al final sacar un mensaje de éxito o error. Si el mensaje es de éxito mostrar la 
            posición de la X en la matriz. Si el mensaje es de error, mostrar la matriz. */

            /*char[,] tablero = new char[5, 5];
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                int fila = random.Next(0, 5);
                int columna = random.Next(0, 5);

                if (tablero[fila, columna] != 'X')
                {
                    tablero[fila, columna] = 'X';
                }
                else
                {
                    i--;
                }

            }
            bool acierto = false;

            for (int intentos = 0; intentos < 3; intentos++)
            {
                Console.WriteLine("Ingrese la fila (0-4):");
                int filaUsuario = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la columna (0-4):");
                int columnaUsuario = int.Parse(Console.ReadLine());

                if (tablero[filaUsuario, columnaUsuario] == 'X')
                {
                    acierto = true;
                    Console.WriteLine($"¡Felicidades! Has acertado la posición de una 'X' en ({filaUsuario}, {columnaUsuario})");
                    break;
                }

                else
                {
                    Console.WriteLine("No has acertado. Intenta de nuevo.");
                }
            }

            if (!acierto)
            {
                Console.WriteLine("No has acertado en los 3 intentos. La matriz es:");
                for (int i = 0; i < tablero.GetLength(0); i++)
                {
                    for (int j = 0; j < tablero.GetLength(1); j++)
                    {
                        if (tablero[i, j] == 'X')
                        {
                            Console.Write("X |");
                        }

                        else
                        {
                            Console.Write(". |");
                        }
                    }
                    Console.WriteLine();
                }

            }*/
            /*5. Desarrollar un programa en C# que: 
            * Le pida al usuario ingresar por teclado el número de filas y columnas de una matriz 
            de enteros 
            * Cargue los datos de la matriz ingresándolos por teclado  
            * Muestre la matriz ingresada 
            * Luego convierta cada fila de la matriz en una columna, es decir la fila 1 pasaría a ser 
            ahora la columna 1. 
            * Mostrar la nueva matriz */
            /*int filas = 0;
            int columnas = 0;

            Console.WriteLine("Ingrese la cantidad de filas que desea:");
            filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas que desea:");
            columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];
            int[,] matrizCambiada = new int[columnas, filas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posicion [{i},{j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matriz original:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j]} | ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matrizCambiada[j, i] = matriz[i, j];
                }
            }
            Console.WriteLine("Matriz con filas convertidas en columnas:");
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    Console.Write($"{matrizCambiada[i, j]} | ");
                }
                Console.WriteLine();
            }*/
            /*6. Crear una aplicación en C# que permita realizar las siguientes acciones: 
            * Crear una matriz de n filas por m columnas 
            * Llenar la matriz con números aleatorios del 1 al 3 (investigar la función random en C#) 
            * Mostrar la matriz generada 
            * Mostrar por pantalla cuantas veces fue ingresado el número 1, el número 2, y el 
            número 3, y cuál de los tres números fue repetido más veces.*/
            int n = 0;
            int m = 0;
            int contador1 = 0;
            int contador2 = 0;
            int contador3 = 0;

            Console.WriteLine("Ingrese la cantidad de filas que desea:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas que desea:");
            m = int.Parse(Console.ReadLine());

            Random random = new Random();
            int[,] matriz = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = random.Next(1, 4);

                    if (matriz[i, j] == 1)
                    {
                        contador1++;
                    }
                    else if (matriz[i, j] == 2)
                    {
                        contador2++;
                    }
                    else
                    {
                        contador3++;
                    }
                }
            }
            Console.WriteLine("Matriz generada:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matriz[i, j]} | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"El número 1 aparece {contador1} veces");
            Console.WriteLine($"El número 2 aparece {contador2} veces");
            Console.WriteLine($"El número 3 aparece {contador3} veces");
            if (contador1 > contador2 && contador1 > contador3)
            {
                Console.WriteLine("El número que más se repite es el 1");
            }
            else if (contador2 > contador1 && contador2 > contador3)
            {
                Console.WriteLine("El número que más se repite es el 2");
            }
            else if (contador3 > contador1 && contador3 > contador2)
            {
                Console.WriteLine("El número que más se repite es el 3");
            }
            else
            {
                Console.WriteLine("Hay un empate en la cantidad de repeticiones entre dos o más números");
            }
        }
    }
}
