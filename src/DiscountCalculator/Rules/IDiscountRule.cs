namespace DiscountCalculator.Rules;

interface IDiscountRule
{
  decimal CalculateDiscount(Customer customer, decimal currentDiscount);
}
