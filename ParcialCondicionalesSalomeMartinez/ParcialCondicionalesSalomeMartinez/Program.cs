namespace ParcialCondicionalesSalomeMartinez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*La pizzería Olafo ofrece a sus clientes dos tipos de pizzas: vegetarianas y no vegetarianas, y permite la selección de ingredientes específicos para cada tipo. Según los ingredientes seleccionados, el precio final puede variar, incluyendo un porcentaje de IVA correspondiente.
            1. Solicitar al cliente el tipo de pizza que desea comprar:
            Vegetariana
            No vegetariana
            2. Mostrar ingredientes disponibles según el tipo de pizza:
            Si la pizza es vegetariana, permitir elegir 3 ingredientes de la siguiente lista:
            Pimiento, Tofu, Champiñones, Tomate, Lechuga
            Si la pizza es no vegetariana, permitir elegir 2 ingredientes de la siguiente lista:
            Res, Chorizo, Pollo, Tocineta, Cerdo
            3. Calcular el precio de la pizza en función del tipo e ingredientes seleccionados
            Pizza Vegetariana:
            Ingredientes seleccionados      Precio base     IVA
            Pimiento, Champiñones, Lechuga   $20.000        19%
            Tofu, Champiñones, Lechuga       $30.000        15%
            Cualquier otra combinación       $25.000        10%

            Pizza No Vegetariana
            Ingredientes seleccionados      Precio base     IVA
            Res, Pollo                      $10.000         19%
            Res, Tocineta                   $15.000         17%
            Chorizo, Tocineta               $25.000         9%
            Cualquier otra combinación      $22.000         10%
            4. El programa debe:
            Calcular el IVA correspondiente según la combinación de ingredientes.
            Calcular el precio final (precio base + IVA).
            Mostrar al final:
            Tipo de pizza seleccionada.
            Ingredientes elegidos.
            Valor del IVA aplicado.
            Precio final de la pizza.*/

            char pizza = ' ';
            char ingrediente1 = ' ';
            char ingrediente2 = ' ';
            char ingrediente3 = ' ';
     
            float precioBase= 0;
            float iva = 0;

            Console.WriteLine("¿Qué tipo de pizza prefiere: v:vegetariana, n:no vegetariana");
            pizza=Convert.ToChar(Console.ReadLine());
            

            if (pizza == 'v')
            {
                Console.WriteLine("Puede escoger 3 ingredientes: p:pimiento, t:tofu, c:champiñones, o:tomate, l:lechuga");
                Console.WriteLine("Escoja su primer ingrediente");
                ingrediente1 = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Escoja su segundo ingrediente");
                ingrediente2 = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Escoja su tercer ingrediente");
                ingrediente3 = Convert.ToChar(Console.ReadLine());

                if (ingrediente1 == 'p' && ingrediente2 == 'c' && ingrediente3 == 'l' || ingrediente1 == 'c' && ingrediente2 == 'p' && ingrediente3 == 'l'|| ingrediente1 == 'l' && ingrediente2 == 'c' && ingrediente3 == 'p' || ingrediente1 == 'p' && ingrediente2 == 'l' && ingrediente3 == 'c')
                {
                    precioBase = 20.000f;
                    iva = 1.19f;
                    Console.WriteLine($"El precio total de su pizza es {precioBase*iva}");
                }
                else if (ingrediente1 == 't' && ingrediente2 == 'c' && ingrediente3 == 'l' || ingrediente1 == 'c' && ingrediente2 == 't' && ingrediente3 == 'l' || ingrediente1 == 'l' && ingrediente2 == 'c' && ingrediente3 == 't' || ingrediente1 == 't' && ingrediente2 == 'l' && ingrediente3 == 'c')
                {
                    precioBase = 30.000f;
                    iva = 1.15f;
                    Console.WriteLine($"El precio total de su pizza es {precioBase * iva}");
                }
                else
                {
                    precioBase = 25.000f;
                    iva = 1.10f;
                    Console.WriteLine($"El precio total de su pizza es {precioBase * iva}");
                }
            }
            else if (pizza == 'n')
            {
                Console.WriteLine("Puede escoger 2 ingredientes: r:res, c:chorizo, p:pollo, t:tocineta, m:cerdo");
                Console.WriteLine("Escoja su primer ingrediente");
                ingrediente1 =Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Escoja su segundo ingrediente");
                ingrediente2 = Convert.ToChar(Console.ReadLine());

                if(ingrediente1 == 'r' && ingrediente2 == 'p' || ingrediente1 == 'p' && ingrediente2 == 'r')
                {
                    precioBase = 10.000f;
                    iva = 1.19f;
                    Console.WriteLine($"El precio total de su pizza es {precioBase * iva}");
                }
                else if (ingrediente1 == 'r' && ingrediente2 == 't' || ingrediente1 == 't' && ingrediente2 == 'r')
                {
                    precioBase = 15.000f;
                    iva = 1.17f;
                    Console.WriteLine($"El precio total de su pizza es {precioBase * iva}");
                }
                else if (ingrediente1 == 'c' && ingrediente2 == 't' || ingrediente1 == 't' && ingrediente2 == 'c')
                {
                    precioBase = 25.000f;
                    iva = 1.09f;
                    Console.WriteLine($"El precio total de su pizza es {precioBase * iva}");
                }
                else
                {
                    precioBase = 22.000f;
                    iva = 1.10f;
                    Console.WriteLine($"El precio total de su pizza es {precioBase * iva}");
                }
            }
            Console.WriteLine($"Tipo de pizza seleccionada {pizza}. Ingredientes elegidos:{ingrediente1}, {ingrediente2}, {ingrediente3}. El iva aplicado fue: {iva}. El precio final de su pizza es: {precioBase * iva}");

            /*Prueba de escritorio
            CASOS	                    Variables					                Salida
                            Ing1	   Ing2	    Ing3	Iva	      precioBase	
            C1: Pizza v	    pimiento   tofu	    lechuga	15%	      30.000	        34.500
            C2: Pizza n	    tocineta   res	    N/A	    17%	      15.000	        17.550
            C3: Pizza n	    pollo      pollo	N/A	    10%	      22.000	        24200
*/
        }
    }
}
