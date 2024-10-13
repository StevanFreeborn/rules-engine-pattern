using DiscountCalculator;

var discount = new Calculator().CalculateDiscountPercentage(new()
{
  DateOfBirth = new DateTime(1950, 1, 1),
  DateOfFirstPurchase = new DateTime(2021, 1, 1),
  IsVeteran = true
});

Console.WriteLine($"Discount: {discount:P}");