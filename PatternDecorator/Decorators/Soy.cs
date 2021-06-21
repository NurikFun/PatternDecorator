using PatternDecorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Decorators
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string Description => beverage.Description + ", soy";
        public override decimal Cost()
        {
            return beverage.Cost() + 0.15M;
        }

    }
}
