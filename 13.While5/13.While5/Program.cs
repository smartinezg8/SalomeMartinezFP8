namespace _13.While5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*13. Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir.  
            El algoritmo debe escribir en pantalla: 
            La cantidad de números introducidos que son mayores que 0 
            La cantidad de números introducidos menores que 0  
            La cantidad de números iguales a 0. */

            int cantidad = 0;
            int numero = 0;
            int contador = 1;
            int contadorPositivos = 0;
            int contadorNegativos = 0;
            int contadorCero = 0;

            Console.WriteLine("Digite la cantidad de números que quiere ingresar");
            cantidad = Convert.ToInt32(Console.ReadLine());

            while (contador <= cantidad)
            {
                Console.WriteLine("Digitar números");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    contadorPositivos++;
                }
                else if (numero < 0)
                {
                    contadorNegativos++;
                }
                else
                {
                     contadorCero++;
                }
                contador++;
            }
            Console.WriteLine($"La cantidad de números mayores a 0 son: {contadorPositivos}");
            Console.WriteLine($"La cantidad de números menores a 0 son: {contadorNegativos}");
            Console.WriteLine($"La cantidad de números iguales a 0 son: {contadorCero}");
        }
    }
}
