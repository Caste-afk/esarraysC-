namespace es8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Random rnd = new Random();
            do
            {
                Console.Write("Lunghezza array: ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1, 100);
                Console.Write($"{array[i]}, ");
            }   
            Console.WriteLine("\n");
            for (int i = 0; i < n-1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    Console.Write($"{array[i]}, ");
                }
                else
                {
                    Console.Write($"{array[i]}");
                    Console.Write("\n");
                }
            }
        }
    }
}
