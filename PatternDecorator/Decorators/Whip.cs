using PatternDecorator.Abstract;


namespace PatternDecorator.Decorators
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string Description => beverage.Description + ", whip";
        public override decimal Cost()
        {
            return beverage.Cost() + 0.10M;
        }
    }
}
