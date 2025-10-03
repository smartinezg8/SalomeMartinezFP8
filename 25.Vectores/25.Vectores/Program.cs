namespace _25.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*25. Algoritmo que permita solicitar 10 números,
             * los cuales serán almacenados en un arreglo unidimensional,
             * al final, debe visualizar el promedio de esos números.*/

            int[] numeros = new int[10];
            int suma = 0;


            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese el número " + (i + 1) + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[i]; // Acumular la suma
            }


            int promedio = suma / numeros.Length;


            Console.WriteLine("\nEl promedio de los números ingresados es: " + promedio);
        }
    }
}
