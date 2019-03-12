using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_Ex2
{
    public class ComposedMission : IMission
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

        private event RationalFunction functions;

        public ComposedMission(string name)
        {
            Name = name;
            Type = "Composed";
        }

        public double Calculate(double value)
        {
            double result = value;
            foreach (RationalFunction func in functions.GetInvocationList())
            {
                result = func(result);
            }
            OnCalculate?.Invoke(this, result);
            return result;
        }

        public ComposedMission Add(RationalFunction function)
        {
            functions += function;
            return this;
        }
    }
}
