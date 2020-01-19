using BridgePattern.Formatters;

using System;

namespace BridgePattern.Documents
{
    public abstract class Document
    {
        protected readonly IFormatter _formatter;

        public Document(IFormatter formatter)
        {
            _formatter = formatter;
        }

        public string Title { get; set; }
        public string Author { get; set; }

        public virtual void Print()
        {
            Console.WriteLine(_formatter.Format("Title", Title));
            Console.WriteLine(_formatter.Format("Author", Author));
        }
    }
}
