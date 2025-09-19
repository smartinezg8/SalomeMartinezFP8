namespace _18.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*18.Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente: 
            * Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “Es apto para el crédito” 
            * Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “No es apto para el crédito” 
            El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más. 
            Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos. */

            string nombre = " ";
            int numCuenta = 0;
            int saldo = 0;
            float sumaSaldos = 0;
            string respuesta = " ";
            int numUsuarios = 0;

            do
            {
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su número de cuenta");
                numCuenta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su número saldo");
                saldo = Convert.ToInt32(Console.ReadLine());

                if (saldo > 3000000)
                {
                    Console.WriteLine($"Nombre del ususario: {nombre}, Número de cuenta: {numCuenta}, saldo {saldo}. Es apto para el crédito");
                }
                else if (saldo < 3000000)
                {
                    Console.WriteLine($"Nombre del ususario: {nombre}, Número de cuenta: {numCuenta}, saldo {saldo}. No es apto para el crédito");
                }
                sumaSaldos += saldo;
                numUsuarios++;
                
                nombre = " ";
                numCuenta = 0;
                saldo = 0;
                Console.WriteLine("¿Desea seguir? (si/no)");
                respuesta = Console.ReadLine().ToLower(); 

            } while (respuesta == "si");
            Console.WriteLine($"Total de usuarios:{numUsuarios}. El promedio de los saldos de los usuarios es: {sumaSaldos / numUsuarios}");
        }
    }
}
