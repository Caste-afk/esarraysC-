using System.Data;
using static System.Console;
namespace es1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(Environment.TickCount);
            int[] array = new int[100];
            int counter = 0;
            while (counter < array.Length) 
            {
                array[counter] = rnd.Next(1, 21);
                Write($"{array[counter]}, ");
                counter++;
            }

            counter = 1;
            int piufreq=0;
            int npiufrequente=0;
            for (int i =0; i< array.Length; i++)// controllo per ogni numero
            { 
                for (int j = 0; j < array.Length; j++) //controllo che il numero x sia uguale in altre posizioni
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                }
                if (counter > piufreq)
                {
                    piufreq = counter;
                    npiufrequente = array[i];
                }
                counter =1;
            }
            WriteLine($"\nNumero più frequente: {npiufrequente}; Numero comparse: {piufreq}");
        }
    }
}