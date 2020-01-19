using System;
using System.Linq;

namespace BridgePattern.Formatters
{
    public class ReversedFormatter : IFormatter
    {
        public string Format(string field, string data)
        {
            return $"{field}: {new string(data.Reverse().ToArray())}";
        }
    }
}
