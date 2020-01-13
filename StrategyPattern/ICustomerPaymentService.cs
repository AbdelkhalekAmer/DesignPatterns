using System;

namespace StrategyPattern
{
    public interface ICustomerPaymentService
    {
        double CalculateDiscount(Func<Customer, double> calculateDiscountStrategy);
    }
}
