namespace _9.CicloWHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int acumulador = 0;

            while (contador <= 5)
            {
                acumulador += contador;
                Console.WriteLine($"Contador: {contador} - Acumulador: {acumulador}");
                contador++;
            }
            Console.WriteLine("La suma de los primeros 5 números enteros es:" + acumulador);
        }
    }
}
