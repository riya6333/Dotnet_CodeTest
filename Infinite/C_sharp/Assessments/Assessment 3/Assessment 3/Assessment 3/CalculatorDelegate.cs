using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    class CalculatorDelegate
    {
        public delegate int ArithmeticOperation(int x, int y);
        ArithmeticOperation operation = null;

    }
}
