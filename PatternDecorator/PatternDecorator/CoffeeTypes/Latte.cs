using PatternDecorator.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Entities
{
    public class Latte : Coffee
    {
        public Latte() : base("Латте")
        {
        }

        public override double GetCost()
        {
            return 15;
        }
    }
}
