namespace CommandPattern.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }

        public override string ToString()
        {
            return $"Employee:\n>>> ID: {Id}\n>>> Name: {Name}\n>>> Job: {Job}\n";
        }

    }
}
