namespace es3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n;
            do
            {
                Console.WriteLine("Inserisci un numero per la lunghezza dell'array");
            } while (!int.TryParse(Console.ReadLine(), out n));

            int[] array = new int[n];
            for (int i =0;  i < n; i++)
            {
                array[i] = rnd.Next(1, 50);
                Console.Write($"{array[i]}, ");
            }

            int[] array2;
            if (array.Length%2 == 0)
            {
                array2 = new int[array.Length/2];
            }
            else
            {
                array2 = new int[array.Length / 2 + 1];
            }


            int j = 0;

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array[j] + array[j + 1];
                j = j+2;
            }
            Console.WriteLine("\n");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"{array2[i]}, ");
            }
        }
    }
}