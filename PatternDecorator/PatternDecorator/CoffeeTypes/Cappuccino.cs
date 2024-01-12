using PatternDecorator.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Entities
{
    public class Cappuccino : Coffee
    {
        public Cappuccino() : base("Капучино")
        {
        }

        public override double GetCost()
        {
            return 10;
        }
    }
}
