using System;
using System.Diagnostics;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer1 = Stopwatch.StartNew();

            var employeeWebClient1 = new EmployeeWebClient("Integrant Inc.");
            employeeWebClient1.PrintData();

            timer1.Stop();
            var timespan1 = timer1.Elapsed;

            var timer2 = Stopwatch.StartNew();

            var employeeWebClient2 = employeeWebClient1.Clone();
            employeeWebClient2.PrintData();

            timer2.Stop();
            var timespan2 = timer2.Elapsed;

            Console.WriteLine($"{timespan1.TotalMilliseconds} ms");
            Console.WriteLine($"{timespan2.TotalMilliseconds} ms");
        }
    }
}
