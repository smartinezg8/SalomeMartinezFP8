namespace _26.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglo de dos dimensiones
            int[,] numeros = new int[2, 2]; //No se pone el rango, sino el num de filas y columnas
            string[,] nombres = new string[2, 3]; //rango = 6 posiciones

            //Asignación de datos
            numeros[0, 0] = 25;
            numeros[0, 1] = 46;
            numeros[1, 0] = 42;
            numeros[1, 1] = 78;
            //numeros[1, 2] = 2; Error índice fuera del rango

            //Otra forma de declarar e inicializar matrices
            string[,] apellidos =
            {
                {"Chica", "Álvarez"},
                {"Cardona", "Ríos"},
                {"López", "Mejía"}, 
                //Filas tienen el mismo número de columnas
            };

            //Recuperar datos de la matriz
            Console.WriteLine(apellidos[1, 1]);

            //Recorrer Matrices - Almacenar datos
            char[,] caracteres = new char[3, 2]; //rango = 6

            for (int i = 0; i < 3; i++) //Recorre las filas
            {
                for (int j = 0; j < 2; j++) //Recorrer las columnas de cada una de las filas
                {
                    Console.WriteLine($"Ingrese el caracter para la posición con índices {i}, {j}:");
                    caracteres[i, j] = char.Parse(Console.ReadLine());
                }
            }
            //Recorrer Matrices - Recuperar datos
            for (int i = 0; i < caracteres.GetLength(0); i++) //.GetLenght(0) devuelve el número de filas
            {
                for (int j = 0; j < caracteres.GetLength(1); j++) //.GetLenght(1) devuelve número de columnas
                {
                    Console.WriteLine($"Caracter posición {i}, {j}: {caracteres[i, j]}");
                }
            }

            for (int i = 0; i < caracteres.GetLength(0); i++) //.GetLenght(0) devuelve el número de filas
            {
                for (int j = 0; j < caracteres.GetLength(1); j++) //.GetLenght(1) devuelve número de columnas
                {
                    Console.Write($"{caracteres[i, j]} |");
                }
                Console.WriteLine();
            }

            //Rango de la matriz
            Console.WriteLine(caracteres.Length);

            int[,] num =
            {
                {10, 10, 10, 10},
                {10, 10, 10, 10},
                {10, 10, 10, 10},
                {10, 10, 10, 10},

            };

            for (int i = 0; i < num.GetLength(0); i++) 
            {
                for (int j = 0; j < num.GetLength(1); j++) 
                {
                    Console.Write($"{num[i, j]} | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(num.Length);
        }
    }
}
