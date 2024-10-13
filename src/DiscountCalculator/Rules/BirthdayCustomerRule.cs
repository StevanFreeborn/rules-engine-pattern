namespace DiscountCalculator.Rules;

class BirthdayCustomerRule : IDiscountRule
{
  public decimal CalculateDiscount(Customer customer, decimal currentDiscount)
  {
    var isBirthday = customer.DateOfBirth.Month == DateTime.Now.Month && customer.DateOfBirth.Day == DateTime.Now.Day;

    if (isBirthday)
    {
      return currentDiscount + 0.10m;
    }

    return currentDiscount;
  }
}
