using DiscountCalculator.Rules;

namespace DiscountCalculator;

class Calculator
{
  private static List<IDiscountRule>? s_rules = null;
  private readonly RuleEngine _ruleEngine;

  public Calculator()
  {
    if (s_rules is null)
    {
      var rules = GetType().Assembly.GetTypes()
        .Where(t => typeof(IDiscountRule).IsAssignableFrom(t) && t.IsInterface is false)
        .Select(t => Activator.CreateInstance(t) as IDiscountRule)
        .Where(r => r is not null);

      s_rules = [.. rules];
    }

    _ruleEngine = new RuleEngine(s_rules);
  }

  public decimal CalculateDiscountPercentage(Customer customer) => _ruleEngine.CalculateDiscountPercentage(customer);
}

class RuleEngine
{
  private readonly List<IDiscountRule> _rules = [];

  public RuleEngine(IEnumerable<IDiscountRule> rules)
  {
    _rules.AddRange(rules);
  }

  public decimal CalculateDiscountPercentage(Customer customer)
  {
    var discount = 0m;
    _rules.ForEach(rule => discount = Math.Max(discount, rule.CalculateDiscount(customer, discount)));
    return discount;
  }
}