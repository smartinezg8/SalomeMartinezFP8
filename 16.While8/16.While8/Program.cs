namespace _16.While8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*16. Escribe un algoritmo en el que el ordenador elija un número aleatorio entre 1 y 100. 
             * El usuario debe adivinar el número, y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. 
             * Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número. */
            int num = 1;
            int intentos = 0;
            Random rnd = new Random();
            num = rnd.Next(1,101);

            while (intentos != num)
            {
                Console.WriteLine("Intente adivinar el número");
                intentos = Convert.ToInt32(Console.ReadLine());

                if (intentos > num)
                {
                    Console.WriteLine("Su intento es demasiado alto");
                }
                else if (intentos < num)
                {
                    Console.WriteLine("Su intento es demasiado bajo");
                }
                else
                {
                    Console.WriteLine($"Su respuesta es correcta, el número era {num}");
                }
            }
        }
    }
}
