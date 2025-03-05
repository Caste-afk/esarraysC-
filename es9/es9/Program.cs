
namespace es9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n;

            do
            {
                Console.Write("Lunghezza array: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

            int[] array = new int[n];
            int[] arraym = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1, 100);
                Console.Write($"{array[i]}, ");
            }

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                    arraym[i] = (array[i] + array[i + 1]) / 2;
                else if (i == n - 1)
                    arraym[i] = (array[i] + array[i - 1]) / 2;
                else
                    arraym[i] = (array[i - 1] + array[i] + array[i + 1]) / 3;
            }


            Console.WriteLine("\nArray media:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arraym[i]}, ");
            }
        }

    }
}
