using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Bases
{
    public abstract class Coffee
    {
        public string Type { get; protected set; }
        public Coffee(string type)
        {
            Type = type;
        }
        public abstract double GetCost();

        public override string ToString()
        {
            return $"Type - {Type}; Cost - {GetCost()}";
        }
    }
}
