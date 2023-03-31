using System;

namespace RandomDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Olá! Quantos dados quer lançar?");
            int numDices = Convert.ToInt32(Console.ReadLine());

            Random dice = new Random();
            int sumDices = 0;

            for(int i = 0; i < numDices; i++)
            {
                sumDices += dice.Next(1,7);
            }

            Console.WriteLine($"A soma dos dados é {sumDices}");
        }
    }
}