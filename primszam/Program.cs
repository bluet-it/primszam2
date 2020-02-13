using System;

namespace primszam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i < n; i++)
            {
                bool k = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        k = false;
                    }
                }
                if (k)
                {
                    Console.WriteLine(i);
                }
            }
            while (true)
            {

            }
        }
    }
}
