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

            StringBuilder sb = new StringBuilder();

            sb.AppendJoin("-",newArray);

            if(args.Length != 0)
            {
                Console.WriteLine(sb);
            }
            else if(args.Length == 0)
            {
                Console.WriteLine("NO ARGUMENTS");
            }
        }
    }
}