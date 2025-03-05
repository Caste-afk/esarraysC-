namespace es4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("Inserisci la lunghezza dell'array");
            }while(!int.TryParse(Console.ReadLine(), out n));

            Random rnd = new Random();
            int[] array = new int[n];

            int casuale = rnd.Next(0, n);

            Console.WriteLine(casuale);
            for (int i = 0; i < n; i++)
            {
                if (i == casuale)
                {
                    array[i] = 0;
                }
                else
                {
                    array [i] = i;
                }
            }
            int err = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] + array[i+1] != i + (i + 1))
                {
                    err = array[i + 1];
                }
            }
            Console.WriteLine($"{err}, mancante");
        }
    }
}
