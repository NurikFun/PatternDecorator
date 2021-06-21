using PatternDecorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Decorators
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string Description => beverage.Description + ", mocha";

        public override decimal Cost()
        {
            return beverage.Cost() + 0.20M;
        }
    }
}
