namespace _5.CondicionalAnidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Diseñar un algoritmo que lea tres números A, B, C y 
             * visualice en pantalla el valor más grande. El usuario debe ingresar tres valores diferentes.*/
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingrese el número 1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2");
            num2=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 3");
            num3=Convert.ToInt32(Console.ReadLine());

            if(num1>num2)
            {
                if (num1>num3)
                {
                    Console.WriteLine($"El número {num1}, es el mayor");
                }
                else
                {
                    Console.WriteLine($"El número {num3}, es el mayor");
                }
            }
            else
            {
                if (num2>num3)
                {
                    Console.WriteLine($"El número {num2}, es el mayor");
                }
                else
                {
                    Console.WriteLine($"El número {num3}, es el mayor");
                }
            }

            /*2.Realizar un algoritmo que permita solicitar 3 calificaciones, calcular el promedio. Si el promedio se ubica en los siguientes rangos, escribir los correspondientes mensajes. Considerar la situación en donde el promedio generado no esté contemplado en los rangos establecidos, mostrar mensaje de error. 
                9.5-10.0 Excelente 
                8.5-9.4 Muy bien 
                7.5-8.4 Bien*/
            float cal1 = 0;
            float cal2 = 0;
            float cal3 = 0;

            Console.WriteLine("Ingrese la calificación 1");
            cal1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la calificación 2");
            cal2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la calificación 3");
            cal3 = float.Parse(Console.ReadLine());

            float promedio = (cal1 + cal2 + cal3)/3;
            Console.WriteLine($"Su promedio es {promedio}");

            if (promedio >=9.5 && promedio <=10.0)
            {
                Console.WriteLine("Excelente");
            }
            else if (promedio >=8.5 && promedio <=9.4)
            {
                Console.WriteLine("Muy bien");
            }
            else if (promedio >= 7.5 && promedio <= 8.4)
            {
                Console.WriteLine("Bien");
            }
            else
            {
                Console.WriteLine("Error. El promedio no está contemplado dentro de los rangos establecidos");
            }
        }
    }
}
