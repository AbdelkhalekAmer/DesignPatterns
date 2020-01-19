using BridgePattern.Formatters;

using System;

namespace BridgePattern.Documents
{
    public class Essay : Document
    {
        public string Introduction { get; set; }
        public Essay(IFormatter formatter) : base(formatter)
        {
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(_formatter.Format("Intro", Introduction));
        }
    }
}
