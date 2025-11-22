using System;
using System.Diagnostics.CodeAnalysis;

namespace ejercicio_arrays_DDR_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alan Daniel Garcia Mendez / 2025-1403
            int[] array = new int[8];
            int suma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Escribe un numero en la posición #" + (i + 1));
                int num = Convert.ToInt32(Console.ReadLine());
                array[i] = num;
                suma = suma + num;
            }

            Console.WriteLine("Mostrando datos del Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine($"La suma de todos los numeros introducidos es igual a: {suma}");
            Console.ReadLine();
        }
    }
}
