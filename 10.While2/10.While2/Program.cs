namespace _10.While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10. Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1*2*3*4*5)
            int num = 0;
            int contador = 1;
            int acumulador = 1;

            Console.WriteLine("Escriba el número:");
            num = Convert.ToInt32(Console.ReadLine());

            while (contador <= num)
            {
                acumulador *= contador;
                Console.WriteLine($"Contador: {contador} - Acumulador: {acumulador}");
                contador++;
            }
            Console.WriteLine($"El factorial de {num}: {acumulador}");
        }
    }
}
