using PatternDecorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Decorators
{
    public class Milk : CondimentDecorator
    {
        Beverage beverage;
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string Description {
            get { return beverage.Description + ", milk"; }
        }

        public override decimal Cost()
        {
            return beverage.Cost() + 0.10M;
        }
    }
}
