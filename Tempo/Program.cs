using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();

            Thread.Sleep(500);

            crono2.Start();

            Thread.Sleep(300);

            crono1.Stop();
            crono2.Stop();

            TimeSpan tD = crono1.Elapsed;
            TimeSpan tD2 = crono2.Elapsed;

            string tempoDecorrido = String.Format("{0:0.00}",tD.TotalSeconds);
            string tempoDecorrido2 = String.Format("{0:0.00}",tD2.TotalSeconds);

            Console.WriteLine($"Tempo decorrido no Crono1 = {tempoDecorrido}");
            Console.WriteLine($"Tempo decorrido no Crono2 = {tempoDecorrido2}");
        }
    }
}