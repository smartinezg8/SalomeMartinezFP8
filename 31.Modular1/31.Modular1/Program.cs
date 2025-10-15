namespace _31.Modular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*31. Crear una matriz de n filas por m columnas,
            que permita ingresar solamente múltiplos de 5 hasta que se llene la matriz. */

            int[,] multiplosDe5 = new int[CapturarFilas(), CapturarColumnas()];
            LlenarMatriz(multiplosDe5);
            MostrarMatriz(multiplosDe5);
        }

        //Módulo que borra la pantalla de la consola
        static void BorrarPantalla()
        {
            Console.Clear();
        }


        //Módulo - procedimiento que recibe la matriz a mostrar en pantalla
        static void MostrarMatriz(int[,] matriz)
        {
            BorrarPantalla();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i,j]} |");
                }
                Console.WriteLine();
            }
        }

        //Módulo - función recorre la matriz y la llena de números múltiplos de 5
        static int[,] LlenarMatriz(int[,] matriz)
        {
            int numero = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    do
                    {
                        Console.WriteLine("Digite un número para ingresar en la matriz:");
                        numero = int.Parse(Console.ReadLine());

                    } while (EsMultiplo5(numero) == false);
                    matriz[i,j] = numero;
                }
            }
            return matriz;
        }

        //Módulo - función comprobar si un número es multiplo de 5
        static bool EsMultiplo5 (int numero)
        {
            if (numero % 5 == 0 && numero !=0)
            {
                return true;
            }
            else 
            {
                Console.WriteLine("Error, debe digitar un número múltiplo de 5");
                return false;
            }
        }

        //Módulo función le pregunta al usuario por el número de filas para la matriz
        static int CapturarFilas()
        {
            BorrarPantalla();
            Console.WriteLine("Ingrese el numero de filas para la matriz:");
            int filas = Convert.ToInt32(Console.ReadLine());
            return filas;
        }
        //Módulo función le pregunta al usuario por el número de columnas para la matriz
        static int CapturarColumnas()
        {
            BorrarPantalla();
            Console.WriteLine("Ingrese el numero de columnas para la matriz:");
            int columnas = Convert.ToInt32(Console.ReadLine());
            return columnas;
        }
    }
}
