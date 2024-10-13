namespace DiscountCalculator.Rules;

class SeniorCustomerRule : IDiscountRule
{
  public decimal CalculateDiscount(Customer customer, decimal currentDiscount = 0)
  {
    if (customer.DateOfBirth < DateTime.Now.AddYears(-65))
    {
      return 0.05m;
    }

    return 0;
  }
}
