namespace DiscountCalculator.Rules;

class LoyalCustomerRule : IDiscountRule
{
  public decimal CalculateDiscount(Customer customer, decimal currentDiscount = 0)
  {
    if (customer.DateOfFirstPurchase.HasValue)
    {
      if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-15))
      {
        return 0.15m;
      }

      if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-10))
      {
        return 0.12m;
      }

      if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-5))
      {
        return 0.10m;
      }

      if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-2) && customer.IsVeteran is false)
      {
        return 0.08m;
      }

      if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-1) && customer.IsVeteran is false)
      {
        return 0.05m;
      }
    }

    return 0;
  }
}
