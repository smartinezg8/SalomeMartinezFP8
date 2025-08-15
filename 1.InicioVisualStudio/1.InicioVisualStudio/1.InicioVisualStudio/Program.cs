namespace _1.InicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración e inicialización de variables
            string nombre="Salome";
            const string iva = "19%";
            string apellido = "Martinez Gallego";
            //iva = "20%"; No puedo cambiar el valor de iva por ser una constante
            Console.Write("Bienvenido al curso de Fundamentos de Programación\n");
            nombre = "Tobby";
            Console.Write("\t" + nombre + " " + apellido + " " + iva);
            Console.ReadKey();
        }
    }
}
