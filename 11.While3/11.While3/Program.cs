namespace _11.While3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11. Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados.

            int acumulador = 0;
            int numeros = 0; //Números es mi contador

            Console.WriteLine("Ingrese los números a sumar, para finalizar ingrese un número negativo");


            while (numeros >= 0)
            {
                acumulador += numeros;
                Console.WriteLine($"Número: {numeros} Acumulador: {acumulador}");
                numeros = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("La suma de los números enteros es:" + acumulador);
        }
    }
}
