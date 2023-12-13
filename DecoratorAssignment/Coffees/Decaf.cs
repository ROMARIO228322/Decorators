using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssignment.BeveragesList
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf Coffee";
        }
        public override decimal Cost()
        {
            return 1.05M;
        }
    }
}
