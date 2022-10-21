using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibJenkinDemo
{
    public class Calci
    {
        public int Add(int i, int j)
        {
            return i + j;
        }
        public int subtract(int i, int j)
        {
            if (j > i)
            {
                return j - i;
            }
            else
            {
                return i - j;
            }
        }
        public int multiply(int i, int j)
        {
            return i * j;
        }
    }

}
