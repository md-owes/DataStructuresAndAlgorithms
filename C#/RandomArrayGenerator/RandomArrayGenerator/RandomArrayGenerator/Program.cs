using System;
using System.IO;

namespace RandomArrayGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt16(File.ReadAllText("config.txt"));
            int[] arr = new int[size];
            Random rand = new Random();
            for (int i = 0, j = 0; i < size; i++)
            {

                int r = rand.Next(1, 99);
                if (!Array.Exists(arr, s => s == r))
                {
                    arr[j] = r;
                    j++;
                }
            }

            Array.ForEach(arr, u => Console.Write(u + " "));
            Console.ReadKey();
        }
    }
}
