namespace es5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n;
            do
            {
                Console.WriteLine("Inserisci lunghezza array");
            } while (!int.TryParse(Console.ReadLine(), out n));

            int[] array = new int[n];
            for (int i=0; i<array.Length; i++)
            {
                array[i] = rnd.Next(0, 10);
                Console.Write($"{array[i]}, ");
            }
            for (int i =0; i<array.Length; i++)
            {
                if (array[i] != array[array.Length - 1])
                {
                    Console.WriteLine("Array non palindromo");
                    return;
                }
            }
            Console.WriteLine("\nArray palindromo");
        }
    }
}
