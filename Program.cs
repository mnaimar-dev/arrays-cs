using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Introduciendo Números en un Array
            Random randomNumbers = new Random();
            int[] array_2 = new int[10];

            // ⬇️ Introduce números al array ⬇️
            for (int i = 0; i < array_2.Length; i++)
            {
                Console.WriteLine("Introduce un Número: ");
                array_2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("#########");

            // ⬇️ Recorre e Imprime cada posición del array ⬇️
            for (int i = 0; i < array_2.Length; i++)
            {
                Console.Write("Posición " + i + ": " + array_2[i]);
            }

            // Introduciendo Random Numbers en un Array ---> Next(maxNumber);
            Random numeroAleatorio = new Random();

            int[] array_1 = new int[] { 1, 2, 3, 4 };

            int suma = 0;
            int counter = 0;

            for (int i = 0; i < array_1.Length; i++)
            {
                suma += array_1[i];
                counter += 1;
            }

            double resultado = (suma / counter);
            Console.WriteLine(resultado);
        }
    }
}
