namespace _24.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear arreglo llamado "numeros" de 100 elementos asignar el número 10 en cada una de las posiciones del arreglo.
            Leer el contenido de cada elemento y escribirlo en pantalla.*/

            int[] numeros = new int[100];

            // Asignar el número 10 en cada posición del arreglo
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 10;
            }

            // Leer y mostrar el contenido del arreglo en pantalla
            Console.WriteLine("Contenido del arreglo 'numeros':");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Posición " + i + " = " + numeros[i]);
            }
        }
    }
}
