using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMvvmCalculatorMauiApp.Model
{
    abstract class ArithmeticService
    {
        public abstract string Calculate(string strFirstNumber, string strSecondNumber);
    }
}
