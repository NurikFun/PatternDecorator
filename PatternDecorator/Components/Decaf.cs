using PatternDecorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Concrete
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf coffee";
        }
        public override decimal Cost()
        {
            return 1.05M;
        }
    }
}
