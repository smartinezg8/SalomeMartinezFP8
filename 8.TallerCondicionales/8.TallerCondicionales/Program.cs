using System.Diagnostics;

namespace _8.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taller
            /*1.Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1, numero2, numero3 respectivamente.El algoritmo debe comprobar si los números son diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en pantalla los números de menor a mayor.Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben ingresar números diferentes.*/
            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;
            int mayor = 0;
            int medio = 0;
            int menor = 0;

            Console.WriteLine("Ingrese el número 1");
            numero1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2");
            numero2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 3");
            numero3 = Int32.Parse(Console.ReadLine());

            if (numero1 != numero2 && numero2 != numero3 && numero3 != numero1)
            {
                mayor = numero1 > numero2 
                ? (numero1 > numero3 ? numero1 : numero3)
                : (numero2 > numero3 ? numero2 : numero3);
                Console.WriteLine($"El número mayor es: {mayor}");
     
                menor = numero1 < numero2
                    ? (numero1 < numero3 ? numero1 : numero3)
                    : (numero2 < numero3 ? numero2 : numero3);
                Console.WriteLine($"El número menor es: {menor}");
             
                if (numero1 != mayor && numero1 != menor)
                {
                    medio = numero1;
                }
                else if (numero2 != mayor && numero2 != menor)
                {
                    medio = numero2;
                }
                else if (numero3 != mayor && numero3 != menor)
                {
                    medio = numero3;
                }
                Console.WriteLine($"El número medio es: {medio}");
                Console.WriteLine($"El orden de los números es: {menor}, {medio}, {mayor}");

            }
            else
            { 
                Console.WriteLine("Se deben ingresar números diferentes");
            }

            /*2.El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si 
            cuenta con munición y si se encuentra en estado invencible, crear un programa que: 
            a. Permita ingresar por teclado si el personaje está en estado invencible (True). 
            b. La cantidad de munición que tiene el personaje en el momento será calculada por el 
            sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#.
            c. Si el estado del personaje es invencible (true) y su cantidad de munición está entre 1 y 
            10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario 
            no hacer nada. */

            bool invencible;
            int municion;

            Console.WriteLine("¿El personaje está en estado invencible? (true,false)");
            invencible = bool.Parse(Console.ReadLine());

            Random rnd = new Random();
            municion = rnd.Next(2,11);
            Console.WriteLine($"La munición es: {municion}");

            if (invencible == true && municion >=2 && municion <= 11)
            {
                Console.WriteLine("El personaje está disparando");
            }

            /*3.Crear un algoritmo que permita ingresar las coordenadas x,y, para tres puntos: P1(x1,y1), 
            P2(x2,y2), P3(x3,y3). Luego calcular la distancia entre los puntos P1  P2, P2  P3, P1 
            P3. La distancia entre dos puntos está dada por la siguiente formula:   
            d = √((x2 - x1)² + (y2 - y1)²) 
            Después de haber calculado la distancia entre los puntos, el algoritmo debe decir si con 
            dichas distancias se puede construir un triángulo, consultar las condiciones que se deben 
            cumplir para realizar dicha construcción. En caso contrario, decir cuál o cuáles de las 
            condiciones no se cumplen. */
            float p1 = 0;
            float p2 = 0;
            float p3 = 0;
            float x1 = 0;
            float x2 = 0;
            float x3 = 0;
            float y1 = 0;
            float y2 = 0;
            float y3 = 0;
            float d1 = 0;
            float d2 = 0;
            float d3 = 0;

            Console.WriteLine("Ingrese la coordenada x del punto 1");
            x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y del punto 1");
            y1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada x del punto 2");
            x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y del punto 2");
            y2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada x del punto 3");
            x3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y del punto 3");
            y3 = float.Parse(Console.ReadLine());

            Console.WriteLine($"P1({x1},{y1}); P2({x2},{y2}); P3({x3},{y3})");

            d1 = MathF.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine($"La distancia de P1 a P2 es {d1}");
            d2 = MathF.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            Console.WriteLine($"La distancia de P2 a P3 es {d2}");
            d3 = MathF.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            Console.WriteLine($"La distancia de P3 a P1 es {d3}");

            if(d1 + d2 > d3 && d1 + d3 > d2 && d2 + d3 > d1)
            {
                Console.WriteLine("Con estas distancias se puede construir un triángulo");
            }
            
            else
            {
                Console.WriteLine("No se puede construir un triángulo con estas distancias");
            }
            if (d1 + d2 <= d3)
            {
                Console.WriteLine("Pues d1+d2<d3");
            }
            if (d1 + d3 <= d2)
            {
                Console.WriteLine("Pues d1+d3<d2");
            }
            if (d2 + d3 <= d1)
            {
                Console.WriteLine("Pues d2+d3<d1");
            }

            /*4.El personaje de un juego, solo se puede mover en forma horizontal (Izquierda o Derecha), 
            crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve 
            hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado. 
             Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la 
            derecha 
             Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la derecha 
             En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra 
            dirección” */
            char tecla = ' '; 

            Console.WriteLine("Ingrese la dirección de movimiento: d:Derecha, i:Izquierda");
            tecla=Convert.ToChar(Console.ReadLine());

            if (tecla == 'd')
            {
                Console.WriteLine("El personaje se mueve hacia la derecha");
            }
            else if (tecla == 'i')
            {
                Console.WriteLine("El personaje se mueve hacia la izquierda");
            }
            else
            {
                Console.WriteLine("No me puedo mover en otra dirección");
            }

            /*5.El personaje de un juego, puede realizar diferentes acciones dependiendo del carácter que 
            el usuario ingrese, y de la cantidad de vidas que posee. Crear un programa que permita: 
             Generar un número aleatorio entre 0 y 5 para simular el número de vidas del personaje. 
            (Función Random) 
             Si el número de vidas es mayor a 0, el personaje puede realizar acciones en el juego. En 
            caso contrario escribir el mensaje “el personaje no posee vidas, y no puede realizar 
            ninguna acción”. 
             Si el personaje puede realizar acciones, escribir los siguientes mensajes de acuerdo al 
            carácter que se ingrese: 
            o Si se ingresa ‘c’, mostrar en consola “el personaje está disparando” 
            o Si se ingresa ‘x’, mostrar en consola “el personaje está hablando con la Rana” 
            o Si se ingresa ‘t’, mostrar en consola “el personaje está en modo Turbo” 
            o Si se presiona ‘i’, mostrar en consola “el personaje es Invencible”*/

            int vidas;
            char accion;

            Random rnd1 = new Random();
            vidas = rnd1.Next(1, 6);
            Console.WriteLine($"La munición es: {vidas}");

            if (vidas > 0)
            {
                Console.WriteLine("Escoger la acción: c, x, t, i");
                accion=Convert.ToChar(Console.ReadLine());

                if (accion == 'c')
                {
                    Console.WriteLine("El personaje está disparando");
                }
                else if (accion == 'x')
                {
                    Console.WriteLine("El personaje está hablando con la Rana");
                }
                else if (accion == 't')
                {
                    Console.WriteLine("El personaje está en modo Turbo");
                }
                else if (accion == 'i')
                {
                    Console.WriteLine("El personaje es Invencible");
                }
            }
            else
            {
                Console.WriteLine("El personaje no posee vidas, y no puede realizar ninguna acción");
            }

            /*6.Realizar la prueba de escritorio para el siguiente algoritmo, según los casos propuestos a 
              continuación. 
                Caso1: finalProm>0 
                Caso2: finalProm=20 
                Caso3: finalProm=15 
                Caso4: finalProm<=0
            CASOS	VARIABLES	SALIDA
                	finalProm	
    C1: finalProm>0	    3       “Desaprobado”
    C2: finalProm=20	20	    “Supera las expectativas”
    C3: finalProm=15	15	    “Requiere mejorar”
    C4: finalProm<=0	0	    “Ingrese un promedio correcto”*/
        }
    }
}
