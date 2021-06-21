using PatternDecorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Concrete
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso coffee";
        }
        public override decimal Cost()
        {
            return 1.99M;
        }
    }
}
