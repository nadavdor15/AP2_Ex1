using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_Ex2
{
    public delegate double RationalFunction(double value);

    public class FunctionsContainer
    {
        private Dictionary<string, RationalFunction> functions;

        public RationalFunction this[string key]
        {
            get
            {
                if (functions.ContainsKey(key))
                    return functions[key];
                else
                    return (functions[key] = val => val);
            }

            set
            {
                functions[key] = value;
            }
        }

        public FunctionsContainer()
        {
            functions = new Dictionary<string, RationalFunction>();
        }

        public IList<string> getAllMissions()
        {
            return functions.Keys.ToList<string>();
        }
    }
}
