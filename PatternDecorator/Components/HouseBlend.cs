using PatternDecorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Concrete
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House blend coffee";
        }
        public override decimal Cost()
        {
            return 0.89M;
        }

    }
}
