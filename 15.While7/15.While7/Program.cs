namespace _15.While7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*15.Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, 
             * si al final de cada mes deposita cantidades variables de dinero;
             * además, se quiere saber cuánto lleva ahorrado cada mes. */
            int mes = 1;
            int ahorroMes = 0;
            int ahorroTotal = 0;

            while (mes <= 12)
            {
                Console.WriteLine($"Digite el total ingresado en el mes {mes}");
                ahorroMes = Convert.ToInt32(Console.ReadLine());

                ahorroTotal = ahorroMes + ahorroTotal;
                Console.WriteLine($"Usted lleva ahorrado hasta el mes {mes}: {ahorroTotal}");
                mes++;
            }
        }
    }
}
