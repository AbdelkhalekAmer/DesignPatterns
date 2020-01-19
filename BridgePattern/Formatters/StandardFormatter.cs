namespace BridgePattern.Formatters
{
    public class StandardFormatter : IFormatter
    {
        public string Format(string field, string data)
        {
            return $"{field}: {data}";
        }
    }
}
