using System;

namespace RandomTest
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random r1 = new Random(22);
            Random r2 = new Random(22);
            r2 = new Random(444);
            for (int i = 0; i < 4; i++)
                Console.WriteLine(r1.Next());
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
                Console.WriteLine(r2.Next());
            Console.WriteLine();
            Random r3 = new Random(323);
            for (int i = 0; i < 4; i++)
                Console.WriteLine(r3.Next());            
        }
    }
}
