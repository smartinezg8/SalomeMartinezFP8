namespace _32.ProgramacionModular
{
    internal class Program
    {
        /*Algoritmo que muestre un menú con operaciones (+,-,*,/) y permita realizar la operación que el usuario ingrese por teclado.
             * Si es suma o multiplicación, permitirle al usuario realizar estas operaciones con la cantidad de números que el desee ingresar.
             * Si es división o resta solo dejar realizar la operación con dos números. */
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                opcion = MostrarMenu();
                if (opcion == 1)
                {
                    Sumar();
                }
                else if (opcion == 2)
                {
                    Restar();
                }
                else if (opcion == 3)
                {
                    Multiplicar();
                }
                else if (opcion == 4)
                {
                    Dividir();
                }
                else if (opcion != 0)
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                }
            } while (opcion != 0);
        }

        static int MostrarMenu()
        {
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una operación: ");
            return int.Parse(Console.ReadLine());
        }
        static void Sumar()
        {
            Console.Write("¿Cuántos números desea sumar? ");
            int cantidad = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                suma += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"El resultado de la suma es: {suma}");
        }
        static void Restar()
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resta = num1 - num2;
            Console.WriteLine($"El resultado de la resta es: {resta}");
        }
        static void Multiplicar()
        {
            Console.Write("¿Cuántos números desea multiplicar? ");
            int cantidad = int.Parse(Console.ReadLine());
            int producto = 1;
            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                int num = int.Parse(Console.ReadLine());
                producto *= num;
            }
            Console.WriteLine($"El resultado de la multiplicación es: {producto}");
        }
        static void Dividir()
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");

            }
            int resultado = num1 / num2;
            Console.WriteLine($"El resultado de la división es: {resultado}");
        }
    }
}
