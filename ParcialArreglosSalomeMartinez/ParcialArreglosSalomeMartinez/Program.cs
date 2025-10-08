namespace ParcialArreglosSalomeMartinez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Sistema de gestión de gastos departamentales
            Desarrolle un programa de gestión contable que permita registrar, almacenar y analizar los gastos anuales por concepto y por departamento dentro de una organización.
            Departamentos:
            Marketing
            Contabilidad
            Recursos_Humanos
            Distribución
            Ingeniería
            Investigación

            Conceptos de gasto:
            Salarios
            Suministros
            Mobiliario
            Equipamiento
            Otros

            Requisitos funcionales del programa:
            Estructura de datos:
            * Utilice una matriz bidimensional de 6 filas por 5 columnas para almacenar los valores de gastos.
            Cada fila representa un departamento y cada columna un tipo de gasto.
            * Los índices deben corresponder en orden al listado anterior (por ejemplo, fila 0 → Marketing, columna 0 → Salarios).
            Ingreso de datos:
            *Solicite al usuario ingresar los valores de gastos para cada combinación de departamento y concepto.
            *Validar que cada valor ingresado sea un número decimal positivo. No se permiten valores negativos.
            Visualización de la matriz:
            *Mostrar la matriz completa con encabezados de filas y columnas claros (nombre de departamento y nombre del concepto de gasto).
            *Presentar los valores en formato tabular.
            Cálculos requeridos:
            a) Suma de gastos por departamento:
            Calcular y mostrar el gasto total de cada uno de los 6 departamentos (sumar por fila).
            b) Suma de gastos por concepto:
            Calcular y mostrar el gasto total de cada uno de los 5 conceptos (sumar por columna).
            c) Gasto total del año:
            Calcular y mostrar la suma total de todos los valores en la matriz.
            d) Vector de gastos "Otros":
            Crear un vector (arreglo unidimensional) que contenga, para cada departamento, el gasto registrado en el concepto "Otros".
            Mostrar el vector en pantalla indicando el nombre del departamento y su valor correspondiente.
            e) Mayor gasto registrado:
            *Determinar el valor más alto dentro de la matriz.
            Indicar en pantalla:
            *El valor del gasto
            *El departamento al que pertenece
            *El concepto de gasto correspondiente*/
            string[] departamentos =
            {
                "Marketing",
                "Contabilidad",
                "Recursos Humanos",
                "Distribución",
                "Ingeniería",
                "Investigación"
            };
            string[] conceptos =
            {
                "Salarios",
                "Suministros",
                "Mobiliario",
                "Equipamiento",
                "Otros"
            };


            //Estructura de datos:
            float[,] matriz = new float[6, 5];
            for (int i = 0; i < matriz.GetLength(0); i++) 
            {
                for (int j = 0; j < matriz.GetLength(1); j++) 
                {
                    Console.WriteLine($"Ingrese los valores de gasto para {departamentos[i]} en {conceptos[j]}:");
                    matriz[i, j] = float.Parse(Console.ReadLine());

                    if (matriz [i, j] < 0f) 
                    {
                        Console.WriteLine("Error: El valor ingresado no puede ser negativo. Por favor, ingrese un número decimal positivo.");
                    }
                }
            }

            for (int j = 0; j < conceptos.Length; j++)
            {
                Console.Write($"{conceptos[j]}\t");
            }
            Console.WriteLine();

            for (int i = 0; i < departamentos.Length; i++)
            {
                Console.Write($"{departamentos[i]}\t");
                for (int j = 0; j < conceptos.Length; j++)
                {
                    Console.Write($"{matriz[i, j]}\t");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < matriz.GetLength(0); i++) 
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} |");
                }
                Console.WriteLine();
            }

            //Cálculos requeridos:
            float[] sumaFilas = new float[matriz.GetLength(0)];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    sumaFilas[i] += matriz[i, j];
                }
            }
            Console.WriteLine();
            Console.WriteLine("El gasto total de cada uno de los 6 departamentos es:");
            for (int i = 0; i < sumaFilas.Length; i++)
            {
                Console.Write($"{sumaFilas[i]} | ");
            }


            float[] sumaColumnas = new float[matriz.GetLength(1)];
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    sumaColumnas[i] += matriz[j, i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("El gasto total de cada uno de los 5 conceptos es:");
            for (int i = 0; i < sumaColumnas.Length; i++)
            {
                Console.Write($"{sumaColumnas[i]} | ");
            }


            float sumaMatriz = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    sumaMatriz += matriz[i, j];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"El gasto total es: {sumaMatriz}");


            float [] vectorOtros = new float[matriz.GetLength(0)];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                vectorOtros[i] = matriz[i, 4];
            }
            Console.WriteLine();
            Console.WriteLine("El vector de gastos 'Otros' es:");
            for (int i = 0; i < vectorOtros.Length; i++)
            {
                Console.WriteLine($"{departamentos[i]}: {vectorOtros[i]}");
            }
            Console.WriteLine();

            float mayorGasto = 0;
            int filaMayor = 0;
            int columnaMayor = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] > mayorGasto)
                    {
                        mayorGasto = matriz[i, j];
                        filaMayor = i;
                        columnaMayor = j;
                    }
                }
                Console.WriteLine($"El mayor gasto registrado es: {mayorGasto}, en el departamento de {departamentos[filaMayor]}, en el concepto de {conceptos[columnaMayor]}");
            }
        }
    }
}
