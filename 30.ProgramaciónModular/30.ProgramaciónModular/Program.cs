namespace _30.ProgramaciónModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            MostrarMensajes("Mi nombre es Salomé");
            //MostrarMensajes("Tengo 17 años");
            //Console.WriteLine($"Edad calculada: {CalcularEdad()}");
            MostrarMensajes($"Tengo {CalcularEdad (2025, 2007)} años");
        }

        //Módulo 1 - procedimiento sin parámetros
        static void MostrarMensaje()
        {
            Console.WriteLine("Bienvenidos a la clase de Programación Modular");
            MostrarMensajes("Estoy desde procedimiento sin parámetros");
        }

        //Módulo 2 - Procedimiento con parámetros
        static void MostrarMensajes(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        //Módulo 3 - Funciones sin parámetros
        static int CalcularEdad()
        {
            int edad;
            edad = 2025 - 2007;
            return edad;
        }

        //Módulo 4 - Funciones con parámetros
        static int CalcularEdad(int añoActual, int añoNacimiento)
        {
            return añoActual - añoNacimiento;
        }
    }
}
