namespace ParcialCiclosSalomeMartinezG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En el programa de Ingeniería Mecánica, que cuenta con 20 estudiantes, se desea procesar información sobre la ocupación y el género de los alumnos.
            El programa debe realizar las siguientes acciones:
            Ingresar por teclado la ocupación de cada estudiante (trabaja o estudia) y su género (hombre o mujer).
            Calcular y mostrar el porcentaje de estudiantes que trabajan y el porcentaje de los que estudian respecto al total del grupo.
            Calcular y mostrar el número de mujeres que trabajan.
            Calcular y mostrar el número de hombres que estudian.*/
            char ocupacion = ' ';
            char genero = ' ';

            float sumaEstudia = 0;
            float sumaTrabaja = 0;

            int mujeresTrabajo = 0;
            int hombresEstudio = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Estudiante {i}: Ingrese su ocupación: (e:estudia / t: trabaja)");
                ocupacion = Convert.ToChar((Console.ReadLine().ToLower()));
                Console.WriteLine("Ingrese su género: (m: mujer / h: hombre");
                genero = Convert.ToChar((Console.ReadLine().ToLower()));

                if (ocupacion == 'e')
                {
                    sumaEstudia++;
                }
                else if (ocupacion == 't')
                {
                    sumaTrabaja++;
                }

                if (ocupacion == 't' && genero == 'm')
                {
                    mujeresTrabajo++;
                }
                else if (ocupacion == 'e' && genero == 'h')
                {
                    hombresEstudio++;
                }

            }

            Console.WriteLine($"El porcentaje de estudiantes que trabajan es: {(sumaTrabaja * 100) / 20}%");
            Console.WriteLine($"El porcentaje de estudiantes que estudian es: {(sumaEstudia * 100) / 20}%");
            Console.WriteLine($"La cantidad de mujeres que trabajan es: {mujeresTrabajo}");
            Console.WriteLine($"La cantidad de hombres que estudian es: {hombresEstudio}");
        }
    }
}
