namespace TallerProgramacionModular
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            /*1. Desarrolla un programa que permita: 
             Ingresar una palabra 
             LLevar la palabra ingresada a un vector de caracteres 
             Contar la cantidad de vocales y consonantes en la palabra proporcionada por el usuario.*/

        /*string palabra = SolicitarPalabra();
        int vocales = ContarVocales(palabra);
        int consonantes = ContarConsonantes(palabra);
        MostrarRespuesta(palabra, vocales, consonantes);
    }
    static string SolicitarPalabra()
    {
        Console.WriteLine("Ingrese una palabra:");
        return Console.ReadLine();
    }

    static int ContarVocales(string palabra)
    {
        int contador = 0;
        palabra = palabra.ToLower();


        for (int i = 0; i < palabra.Length; i++)
        {
            char letra = palabra[i];
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                contador++;
        }
        return contador;
    }

    static int ContarConsonantes(string palabra)
    {
        int contador = 0;
        palabra = palabra.ToLower();


        for (int i = 0; i < palabra.Length; i++)
        {
            char letra = palabra[i];
            if (letra >= 'a' && letra <= 'z' && !(letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u'))
                contador++;
        }
        return contador;
    }

    static void MostrarRespuesta(string palabra, int vocales, int consonantes)
    {
        Console.WriteLine("La palabra es: " + palabra);
        Console.WriteLine("Número de vocales: " + vocales);
        Console.WriteLine("Número de consonantes: " + consonantes);
    }*/

        /* 2. Crear un programa que permita gestionar una lista de tareas:
           Agregar tareas.
           Eliminar tareas
           Mostrar la lista de tareas */
        /*static void Main()
         {

            string[] tareas = new string[20];
            int opcion = 0;
            int cantidad = 0;

            do
            {
                opcion = GestionTareas();

                if (opcion ==1)
                    cantidad = AgregarTarea(tareas, cantidad);
                else if (opcion == 2)
                    cantidad = EliminarTarea(tareas, cantidad);
                else if (opcion == 3)
                    MostrarTareas(tareas, cantidad);
                else if (opcion == 0)
                    Console.WriteLine("Saliendo del programa...");
                else
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
            } while (opcion != 0);

            static int GestionTareas()
            {
                Console.WriteLine("Gestión de Tareas");
                Console.WriteLine("1. Agregar Tarea");
                Console.WriteLine("2. Eliminar Tarea");
                Console.WriteLine("3. Mostrar Tareas");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción:");
                return int.Parse(Console.ReadLine());
            }
            static int AgregarTarea(string[] tareas, int cantidad)
            {
                if (cantidad < tareas.Length)
                {
                    Console.Write("Ingrese la tarea a agregar:");
                    string tarea = Console.ReadLine();
                    tareas[cantidad] = tarea;
                    cantidad++;
                    Console.WriteLine("La tarea fue agregada.");
                }
                else
                {
                    Console.WriteLine("No se pueden agregar más tareas. Lista llena.");
                }
                return cantidad;
            }
            static int EliminarTarea(string[] tareas, int cantidad)
            {
                if (cantidad > 0)
                {
                    Console.Write("Ingrese el número de la tarea a eliminar (1 a {0}):", cantidad);
                    int numero = int.Parse(Console.ReadLine());
                    if (numero >= 1 && numero <= cantidad)
                    {
                        for (int i = numero - 1; i < cantidad - 1; i++)
                        {
                            tareas[i] = tareas[i + 1];
                        }
                        tareas[cantidad - 1] = null;
                        cantidad--;
                        Console.WriteLine("La tarea fue eliminada.");
                    }
                    else
                    {
                        Console.WriteLine("Número de tarea inválido.");
                    }
                }
                else
                {
                    Console.WriteLine("No hay tareas para eliminar.");
                }
                return cantidad;
            }
            static void MostrarTareas(string[] tareas, int cantidad)
            {
                    Console.WriteLine("Lista de Tareas:");
                    if (cantidad == 0)
                    {
                        Console.WriteLine("No hay tareas en la lista.");
                        return;
                    }
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine((i+1) + ". " + tareas[i]);
                    }
            }
        }*/

        /*3. Desarrolla un programa que permita: 
         Elegir un tipo de unidad de medida 
        o Masa 
        o Capacidad 
        o Longitud 
        o Tiempo 
         Elegir una unidad de medida para convertir. 
        o Masa 
         De kilogramos a gramos  
         De gramos a Kilogramos 
        o Capacidad 
         De litro a mililitro 
         De mililitro a litro  
        o Longitud 
         De kilometro a metro 
         De metro a kilometro 
        o Tiempo 
         De hora a segundos 
         De segundos a hora 
         Ingresar un valor para convertir. 
         Al final mostrar el valor y la unidad a convertir, y el valor y la unidad a la que se 
        convirtió. Ej: “1 kilometro son 1000 metros” */
        /*static void Main()
        {
            int opcion = 0;
            int valor;
            int resultado;

            do
            {
                opcion = MostrarMenu();

                if (opcion != 0)
                {
                    valor = PedirValor();
                    resultado = Convertir(opcion, valor);
                    MostrarRespuesta(opcion, valor, resultado);
                }

            } while (opcion != 0);

            Console.WriteLine("Saliendo del programa");
        }

        static int MostrarMenu()
        {
            Console.WriteLine("CONVERSOR DE UNIDADES");
            Console.WriteLine("1. Kilogramos a gramos");
            Console.WriteLine("2. Gramos a kilogramos");
            Console.WriteLine("3. Metros a centímetros");
            Console.WriteLine("4. Centímetros a metros");
            Console.WriteLine("5. Litros a mililitros");
            Console.WriteLine("6. Mililitros a litros");
            Console.WriteLine("7. Horas a segundos");
            Console.WriteLine("8. Segundos a horas");
            Console.WriteLine("0. Salir");
            Console.Write("Opción:");
            return int.Parse(Console.ReadLine());
        }

        static int PedirValor()
        {
            Console.Write("Ingrese el valor a convertir: ");
            return int.Parse(Console.ReadLine());
        }

        static int Convertir(int opcion, int valor)
        {
            int resultado = 0;

            if (opcion == 1) resultado = valor * 1000;
            else if (opcion == 2) resultado = valor / 1000;
            else if (opcion == 3) resultado = valor * 100;
            else if (opcion == 4) resultado = valor / 100;
            else if (opcion == 5) resultado = valor * 1000;
            else if (opcion == 6) resultado = valor / 1000;
            else if (opcion == 7) resultado = valor * 3600;
            else if (opcion == 8) resultado = valor / 3600;

            return resultado;
        }

        static void MostrarRespuesta(int opcion, int valor, int resultado)
        {
            if (opcion == 1) Console.WriteLine(valor + " kilogramos son " + resultado + " gramos");
            else if (opcion == 2) Console.WriteLine(valor + " gramos son " + resultado + " kilogramos");
            else if (opcion == 3) Console.WriteLine(valor + " metros son " + resultado + " centímetros");
            else if (opcion == 4) Console.WriteLine(valor + " centímetros son " + resultado + " metros");
            else if (opcion == 5) Console.WriteLine(valor + " litros son " + resultado + " mililitros");
            else if (opcion == 6) Console.WriteLine(valor + " mililitros son " + resultado + " litros");
            else if (opcion == 7) Console.WriteLine(valor + " horas son " + resultado + " segundos");
            else if (opcion == 8) Console.WriteLine(valor + " segundos son " + resultado + " horas");
        }*/


        /*4. Utiliza programación modular para crear un programa que permita: 
             Recorrer una matriz y llenarla con nombres de contactos. 
             Ingresar un nombre y buscarlo en la matriz  
             Si se encuentra el nombre, cambiarlo en la matriz por un nuevo nombre que ingresa 
            el usuario 
             Mostrar por pantalla el nombre encontrado, su posición en la matriz (f,c), y el nuevo 
            nombre ingresado.*/

        /*static void Main()
        {
            string[,] matriz = new string[2, 2];

            LlenarMatriz(matriz);
            MostrarMatriz(matriz);

            Console.Write("Ingrese el nombre que desea buscar: ");
            string nombre = Console.ReadLine();
            
            bool encontrado = BuscarReemplazar(matriz, nombre);
            if (encontrado)
            {
                Console.WriteLine("La matriz fue actualizada");
                MostrarMatriz(matriz);
            }
            else
            {
            Console.WriteLine("El nombre no fue encontrado en la matriz.");
            }
        }
        static void LlenarMatriz(string[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Ingrese el nombre para la posición ({i},{j}): ");
                    matriz[i, j] = Console.ReadLine();
                }
            }
        }
        static void MostrarMatriz(string[,] matriz)
        {
            Console.WriteLine("Matriz:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
        static bool BuscarReemplazar(string[,] matriz, string nombre)
        {
            nombre = nombre.ToLower();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j].ToLower() == nombre)
                    {
                        Console.Write("Nombre encontrado:" + matriz[i, j]);
                        Console.WriteLine($" en la posición ({i},{j})");

                        Console.Write("Ingrese el nuevo nombre para reemplazar: ");
                        string nuevoNombre = Console.ReadLine();

                        matriz[i, j] = nuevoNombre;

                        Console.WriteLine("El nombre ha sido reemplazado por: " + nuevoNombre);
                        return true;
                    }
                }
            }
            return false;
        }*/


        /*5.Crear un programa que implemente el juego de tres en raya (triqui o gato), para dos 
            jugadores. El programa debe: 
             Dibujar el tablero 
             Permitir realizar movimientos. 
             Verificar ganadores*/

        /*static char[,] tablero = new char[3, 3];
        static void Main()
        {
            InicializarTablero();
            char jugador = 'X';
            bool terminado = false;

            while (!terminado)
            {
                MostrarTablero();
                Console.WriteLine("Turno del jugador " + jugador);
                JugarTurno(jugador);


                if (VerificarGanador(jugador))
                {
                    MostrarTablero();
                    Console.WriteLine("Ganó el jugador " + jugador);
                    terminado = true;
                }
                else
                {
                    jugador = (jugador == 'X') ? 'O' : 'X';
                }
            }
        }

        static void InicializarTablero()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    tablero[i, j] = '-';
        }

        static void MostrarTablero()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(tablero[i, j] + " ");
                Console.WriteLine();
            }
        }

        static void JugarTurno(char jugador)
        {
            int fila, columna;
            do
            {
                Console.Write("Ingrese la fila (0-2): ");
                fila = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la columna (0-2): ");
                columna = int.Parse(Console.ReadLine());
            } while (tablero[fila, columna] != '-');


            tablero[fila, columna] = jugador;
        }

        static bool VerificarGanador(char jugador)
        {
            for (int i = 0; i < 3; i++)
            {
                if (tablero[i, 0] == jugador && tablero[i, 1] == jugador && tablero[i, 2] == jugador) return true;
                if (tablero[0, i] == jugador && tablero[1, i] == jugador && tablero[2, i] == jugador) return true;
            }
            if (tablero[0, 0] == jugador && tablero[1, 1] == jugador && tablero[2, 2] == jugador) return true;
            if (tablero[0, 2] == jugador && tablero[1, 1] == jugador && tablero[2, 0] == jugador) return true;
            return false;
        }*/


    }
}
