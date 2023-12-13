using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssignment.BeveragesList
{
    public class Espresso : Beverage
    {
       public Espresso()
        {
            description = "Espresso";
        }
        public override decimal Cost()
        {
            return 1.99M;
        }
    }
}
