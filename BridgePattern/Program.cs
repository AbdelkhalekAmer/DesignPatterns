using BridgePattern.Documents;
using BridgePattern.Formatters;

using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var standardFormatter = new StandardFormatter();
            var reversedFormatter = new ReversedFormatter();

            var documents = new Document[]
            {
                new Report(standardFormatter)
                {
                    Title = "Report A",
                    Author = "Author A",
                    Summery = "A new report is generated and everything is normal."
                },
                new Essay(reversedFormatter)
                {
                    Title = "Essay A",
                    Author = "Author C",
                    Introduction = "Everything is working."
                },
                new Report(standardFormatter)
                {
                    Title = "Report c",
                    Author = "Author B",
                    Summery = "A new report is generated and everything is Ok."
                }
            };

            foreach (var document in documents)
            {
                Console.WriteLine("=======================================");
                document.Print();
                Console.WriteLine("=======================================");
            }

        }
    }
}
