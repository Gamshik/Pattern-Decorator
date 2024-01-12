using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Bases
{
    public abstract class CoffeeDecorator : Coffee
    {
        protected Coffee coffee;
        public CoffeeDecorator(Coffee coffee, string name) : base(name)
        {
            this.coffee = coffee;
        }
    }
}
