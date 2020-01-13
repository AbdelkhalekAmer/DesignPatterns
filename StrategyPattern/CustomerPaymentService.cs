using System;

namespace StrategyPattern
{
    public class CustomerPaymentService : ICustomerPaymentService
    {
        private readonly Customer _customer;

        public CustomerPaymentService()
        {
            _customer = GetCustomerData();
        }

        public double CalculateDiscount(Func<Customer, double> calculateDiscountStrategy)
        {
            return calculateDiscountStrategy(_customer);
        }

        private Customer GetCustomerData()
        {
            var randomNumber = new Random().Next(1, 3);
            switch (randomNumber)
            {
                case 1:
                    return new Customer()
                    {
                        Name = "Customer A",
                        MembershipType = MembershipTypeEnum.Pro
                    };
                case 2:
                    return new Customer()
                    {
                        Name = "Customer B",
                        MembershipType = MembershipTypeEnum.Premium
                    };
                default:
                    throw new Exception("Not Found");
            }
        }
    }
}
