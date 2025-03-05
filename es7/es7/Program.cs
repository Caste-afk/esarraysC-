namespace es7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.Write("Lunghezza array: ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            Random rnd = new Random();
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1, 50);
                Console.Write($"{array[i]}, ");
            }

            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    temp = array[i];
                }
                else if (i == n - 1)
                {
                    array[i] = temp;
                }
                else
                {
                    array[i - 1] = array[i];
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{array[i]}, ");
            }
        }
    }
}
