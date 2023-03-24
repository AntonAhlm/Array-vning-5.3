using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Tal = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int StörstaTal = 0;

            for(int i = 0; i <Tal.Length; i++)
            {
                Console.WriteLine(Tal[i]);
                if (Tal[i]>StörstaTal)
                {
                    StörstaTal = Tal[i];
                }

            }

            Console.WriteLine("Det största talet är " + StörstaTal);


        }
    }
}
