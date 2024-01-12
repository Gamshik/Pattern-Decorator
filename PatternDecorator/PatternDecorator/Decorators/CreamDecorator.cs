using PatternDecorator.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Decorators
{
    public class CreamDecorator : CoffeeDecorator
    {
        public CreamDecorator(Coffee coffee) : base(coffee, coffee.Type + ", со сливками")
        {
        }
        public override double GetCost()
        {
            return coffee.GetCost() + 5;
        }
    }
}
