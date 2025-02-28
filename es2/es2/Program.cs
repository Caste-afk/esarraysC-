namespace es2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(Environment.TickCount);
            int n = 0;
            do
            {
                Console.WriteLine("Quanti numeri si vuole avere nell'array");
            } while (!int.TryParse(Console.ReadLine(), out n));

            int[] array = new int[n];
            Console.WriteLine("Array: ");
            for (int j = 0; j < n; j++) 
            {
                array[j] = rnd.Next(1, 101);
                Console.Write($"{array[j]}, ");
            }

            int i = 0;
            while (i < (array.Length/2)-1)
            {
                int temp = array[i];// prendo una cifra x alla posizione i
                int succ = array[i + 1];// prendo il numero che viene dopo
                if (temp > succ) 
                {
                    array[i] = succ;
                    array[i+1] = temp;
                    i = 0;
                }
                else
                {
                    i++;
                }
            }

            i = array.Length/2;
            while (i < array.Length - 1)
            {
                int temp = array[i];// prendo una cifra x alla posizione i
                int succ = array[i + 1];// prendo il numero che viene dopo
                if (temp < succ)
                {
                    array[i] = succ;
                    array[i + 1] = temp;
                    i = array.Length/2;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine("\nArray secondo la codizione:");
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write($"{array[j]}, ");
            }
        }
    }
}