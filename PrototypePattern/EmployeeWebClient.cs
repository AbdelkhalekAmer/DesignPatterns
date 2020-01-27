using Newtonsoft.Json;

using System;
using System.Net;

namespace PrototypePattern
{
    public class EmployeeWebClient : ICloneable<EmployeeWebClient>
    {
        private readonly string _company;
        private readonly Employee[] _employees;
        public EmployeeWebClient(string company)
        {
            _company = company;
            var client = new WebClient();
            _employees = DownloadData(client.DownloadString("http://dummy.restapiexample.com/api/v1/employees"));
        }

        private Employee[] DownloadData(string data)
        {
            var result = JsonConvert.DeserializeObject<EmployeeApiData>(data);
            var employees = result.data;
            return employees;
        }

        public void PrintData()
        {
            Console.WriteLine($"{_company}: has {_employees.Length} employees.");
            foreach (var employee in _employees)
            {
                Console.WriteLine($"> {employee.employee_name}");
            }
        }

        public EmployeeWebClient Clone()
        {
            return MemberwiseClone() as EmployeeWebClient;
        }
    }
}
