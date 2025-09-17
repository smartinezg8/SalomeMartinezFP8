using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _19.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*19. En un grupo de 100 alumnos, se desea saber cuántos de los estudiantes son hombres y cuántos son mujeres, además se desea saber cuántos son mayores de edad y cuántos no.*/
            int edad = 0;
            int genero = 0;
            int mayorEdad = 0;
            int menorEdad = 0;
            int hombres = 0;
            int mujeres = 0;
            int numEstudiantes = 0;
            int cantidad = 100;

            do
            {
                Console.WriteLine("Por favor ingrese la edad:");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine("¿Cuál es su género?");
                Console.WriteLine("1. Hombre / 2. Mujer");
                genero = int.Parse(Console.ReadLine());

                if (edad>=18)
                {
                    mayorEdad++;
                }
                else
                {
                    menorEdad++;
                }
                if (genero == 1)
                    hombres++;
                else
                    mujeres++;

                numEstudiantes++;
            } while (numEstudiantes < cantidad);
            Console.WriteLine($"De los {cantidad} estudiantes, {mayorEdad} son mayores de edad, {menorEdad} son menores de edad, {hombres} son hombres, {mujeres} son mujeres");
        }
    }
}
