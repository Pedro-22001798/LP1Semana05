using System;
using System.Text;

namespace UpperUnion
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] newArray = Array.ConvertAll(args,s => s.ToUpper());
            Array.Sort(newArray);

            string joinString = String.Join("-",newArray);

            if(args.Length != 0)
            {
                Console.WriteLine(joinString);
            }
            else if(args.Length == 0)
            {
                Console.WriteLine("NO ARGUMENTS");
            }
        }
    }
}