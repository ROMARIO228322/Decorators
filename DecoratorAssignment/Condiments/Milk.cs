using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssignment.CondimentsList
{
    public class Milk : CondimentsDecorator
    {
        Beverage beverage;
        public Milk( Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override decimal Cost()
        {
            return 0.30M+ beverage.Cost();
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }
    }
}
