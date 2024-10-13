namespace DiscountCalculator.Rules;

class FirstTimeCustomerRule : IDiscountRule
{
  public decimal CalculateDiscount(Customer customer, decimal currentDiscount = 0)
  {
    if (customer.DateOfFirstPurchase.HasValue is false)
    {
      return 0.15m;
    }

    return 0;
  }
}
