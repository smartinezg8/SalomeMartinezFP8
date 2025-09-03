namespace _14.While6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*14. Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n.*/
            int rango = 0;
            int contadorPares = 0;
            int contador = 1;

            Console.WriteLine("Ingrese el rango a evaluar");
            rango = Convert.ToInt32(Console.ReadLine());

            while (contador <= rango)
            {
                if (contador % 2 == 0)
                {
                    contadorPares++;
                }
                contador++;
            }
            Console.WriteLine($"La cantidad de números pares de 1 hasta {rango} es: {contadorPares}");
        }
    }
}
