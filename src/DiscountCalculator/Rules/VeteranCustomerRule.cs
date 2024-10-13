namespace DiscountCalculator.Rules;

class VeteranCustomerRule : IDiscountRule
{
  public decimal CalculateDiscount(Customer customer, decimal currentDiscount = 0)
  {
    if (customer.IsVeteran)
    {
      return 0.10m;
    }

    return 0;
  }
}
