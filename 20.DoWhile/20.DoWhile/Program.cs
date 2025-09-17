using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _20.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*20. Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:   
            El número de partidos perdidos  
            El número de partidos empatados
            El número de partidos ganados  
            El porcentaje de partidos perdidos  
            El porcentaje de partidos empatados  
            El porcentaje de partidos ganados  */
            int partidos = 0;
            int perdidos = 0;
            int empatados = 0;
            int ganados = 0;
            char resultado = ' ';

            do
            {
                Console.WriteLine("Ingrese el resultado del partido: g:ganó, p:perdió, e:empató");
                resultado = Convert.ToChar(Console.ReadLine());

                if (resultado == 'g')
                ganados++;
                else if (resultado == 'p')
                perdidos++;
                else if (resultado == 'e')
                empatados++;

                partidos++;

            } while (partidos < 30);
            Console.WriteLine($"El resultado de los partidos es: Ganados: {ganados}, Perdidos: {perdidos}, Empatados: {empatados}");
            Console.WriteLine($"El porcentaje de partidos ganados es: {ganados * 100 / partidos}%");
            Console.WriteLine($"El porcentaje de perdidos ganados es: {perdidos * 100 / partidos}%");
            Console.WriteLine($"El porcentaje de empatados ganados es: {empatados * 100 / partidos}%");
        }
    }
}
