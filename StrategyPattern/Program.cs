using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate random customer in the service and get discount based on delegate passed by the client code.
            Console.WriteLine(new CustomerPaymentService().CalculateDiscount((customer) => customer.MembershipType == MembershipTypeEnum.Pro ? 25 : 0));
            Console.WriteLine(new CustomerPaymentService().CalculateDiscount((customer) => customer.MembershipType == MembershipTypeEnum.Premium ? 40 : 0));
        }
    }
}
