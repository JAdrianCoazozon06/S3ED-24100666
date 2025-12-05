using System;

namespace BurbujaAscendente
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamaño;
            int[] arreglo;

            Console.Write("Ingrese el tamaño del arreglo: ");
            tamaño = int.Parse(Console.ReadLine());

            arreglo = new int[tamaño];

            // Llenar arreglo
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write("Ingrese el valor en la posición [" + i + "]: ");
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("----- MENÚ -----");
                Console.WriteLine("1. Ordenar arreglo (Burbuja Ascendente)");
                Console.WriteLine("2. Mostrar arreglo");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        OrdenamientoBurbujaAscendente(arreglo);
                        Console.WriteLine("Arreglo ordenado correctamente.");
                        Console.ReadKey();
                        break;

                    case 2:
                        MostrarArreglo(arreglo);
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 3);
        }

        // MÉTODO SEGÚN TU DIAGRAMA
        static void OrdenamientoBurbujaAscendente(int[] Arreglo)
        {
            int i = 0, j = 0, Temporal = 0;
            int Longitud = Arreglo.Length;

            for (i = 0; i < Longitud - 1; i++)
            {
                for (j = Longitud - 1; j > i; j--)
                {
                    if (Arreglo[j] < Arreglo[j - 1])
                    {
                        Temporal = Arreglo[j];
                        Arreglo[j] = Arreglo[j - 1];
                        Arreglo[j - 1] = Temporal;
                    }
                }
            }
        }

        // MÉTODO PARA MOSTRAR
        static void MostrarArreglo(int[] arreglo)
        {
            Console.WriteLine("Contenido del arreglo:");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();
        }
    }
}