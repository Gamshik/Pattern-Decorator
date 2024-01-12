using PatternDecorator.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Decorators
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(Coffee coffee) : base(coffee, coffee.Type + ", с молоком")
        {
            
        }
        public override double GetCost()
        {
            return coffee.GetCost() + 2;
        }
    }
}
