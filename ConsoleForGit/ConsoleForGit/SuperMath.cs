using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForGit
{
    public class SuperMath
    {
        public int Sum(List<int> values)
        {
            return values.Sum();
        }

        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }


        public int Add(string valueStr1, string valueStr2)
        {
            int value1 = ValidateInput(valueStr1);
            int value2 = ValidateInput(valueStr2);

            return value1 + value2;
        }

        private int ValidateInput(string valueStr1)
        {
            if(string.IsNullOrEmpty(valueStr1))
            {
                throw new ArgumentNullException("value");
            }

            if(int.TryParse(valueStr1, out int value)) { 
                return value;
            }
            else
            {
                throw new ArgumentException("Invalid value");
            }
        }
    }
}
