using System;

namespace es6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Inserisci lunghezza array");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

            Random random = new Random();
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(1, 101);
            }

            Console.WriteLine("Array originale:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{array[i]}, ");
            }

            for (int i = 0; i < n - 1; i += 2)
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }

            Console.WriteLine("\nArray modificato:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{array[i]}, ");
            }
        }

    }
}
