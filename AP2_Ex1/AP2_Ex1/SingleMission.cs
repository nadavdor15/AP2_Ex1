using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_Ex2
{
    public class SingleMission : IMission
    {
        public string Name
        {
            get;

            private set;
        }

        public string Type
        {
            get;

            private set;
        }

        public event EventHandler<double> OnCalculate;

        private RationalFunction function;

        public SingleMission(RationalFunction function, string name)
        {
            this.function = function;
            Name = name;
            Type = "Single";
        }

        public double Calculate(double value)
        {
            double result = function(value);
            OnCalculate?.Invoke(this, result);
            return result;
        }
    }
}
