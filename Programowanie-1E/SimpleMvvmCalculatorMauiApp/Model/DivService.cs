using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMvvmCalculatorMauiApp.Model
{
    class DivService: ArithmeticService
    {
        public override string Calculate(string strFirstNumber, string strSecondNumber)
        {
            if (!int.TryParse(strFirstNumber, out int firstNumber)
                       || !int.TryParse(strSecondNumber, out int secondNumber))
                return "B³¹d przy konwersji liczb";

            if (secondNumber == 0)
                return "Dzielenie przez zero!!!";

            int result = firstNumber / secondNumber;

            return "Wynik to: " + result.ToString();
        }
    }
}
