namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valorCompra = 0;
            float descuento = 0;
            char dia = ' ';

            Console.WriteLine("Ingrese el valor de compra");
            valorCompra=Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el día de la semana:l:Lunes, m:Martes; x:Miércoles, j:Jueves, v:Viernes, s:Sábado, d:Domingo");
            dia = Convert.ToChar(Console.ReadLine());

            switch(dia)
            {
                case 'l':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es lunes, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 'm':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es martes, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 'x':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es miércoles, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 'j':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es jueves, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 'v':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es viernes, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 's':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es sábado, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 'd':
                    descuento = valorCompra * 0f;
                    Console.WriteLine($"Hoy es domingo, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                default:
                    Console.WriteLine("Debe ingresar un día de la semana válido");
                    break;
            }
            /*Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos números ingresados por el usuario. Las operaciones disponibles serán: suma, resta, multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario*/
            float num1 = 0;
            float num2 = 0;
            char operaciones = ' ';

            Console.WriteLine("Ingrese el primer número");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("¿Qué operación desea realizar? s:suma, r:resta, m:multiplicación, d:división");
            operaciones = Convert.ToChar(Console.ReadLine());

            if (operaciones == 's')
            {
                Console.WriteLine($"La suma es: {num1+num2}");
            }
            else if (operaciones == 'r')
            {
                Console.WriteLine($"La resta es: {num1 - num2}");
            }
            else if (operaciones == 'm')
            {
                Console.WriteLine($"La multiplicación es: {num1 * num2}");
            }
            else if (operaciones == 'd')
            {
                Console.WriteLine($"La división es: {num1 / num2}");
            }

        }
    }
}
