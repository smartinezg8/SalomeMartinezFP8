namespace _21.For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que genera y suma los 5 primeros números enteros
            int acumulador = 0;
            for (int i = 0; i <=5; i++)
            {
                acumulador += i;
            }
            Console.Write($"La suma de los cinco primeros números enteros es: {acumulador}");
        }
    }
}
