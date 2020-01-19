using BridgePattern.Formatters;

using System;

namespace BridgePattern.Documents
{
    public class Report : Document
    {
        public string Summery { get; set; }
        public Report(IFormatter formatter) : base(formatter)
        {
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(_formatter.Format("Summery", Summery));
        }
    }
}
