using PatternDecorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Concrete
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark roasted coffee";
        }
        public override decimal Cost()
        {
            return 0.99M;
        }
    }
}
