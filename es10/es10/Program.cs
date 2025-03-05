
namespace es10
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

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1, 11);
                Console.Write($"{array[i]}, ");
            }


            int posizione = -1;
            for (int i = 0; i < n - 2; i++)
            {
                if (array[i] == array[i + 1] && array[i] == array[i + 2])
                {
                    posizione = i;
                    break;
                }
            }

            if (posizione != -1)
                Console.WriteLine($"Prima sequenza di 3 numeri uguali trovata alla posizione {posizione}: {array[posizione]}, {array[posizione + 1]}, {array[posizione + 2]}");
            else
                Console.WriteLine("Nessuna sequenza di 3 numeri uguali trovata.");
        }

    }
}
