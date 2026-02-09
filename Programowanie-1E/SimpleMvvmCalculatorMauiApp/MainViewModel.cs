using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMvvmCalculatorMauiApp
{
    internal class MainViewModel : BindableObject
    {
        public string StrFirstNumber { get; set; }
        public string StrSecondNumber { get; set; }

        private string resultMessage;
        public string ResultMessage
        {
            get { return resultMessage; }
            set { resultMessage = value; OnPropertyChanged(); }
        }

        /*
        private Command calculateCommand;
        public Command CalculateCommand
        {
            get { return calculateCommand; }
            set { calculateCommand = value; OnPropertyChanged(); }
        }
        */

        private Command calculateCommand;
        public Command CalculateCommand
        {
            get 
            {
                if (calculateCommand == null)
                    calculateCommand = new Command(() =>
                    {
                        if (!int.TryParse(StrFirstNumber, out int firstNumber)
                       || !int.TryParse(StrSecondNumber, out int secondNumber))
                            return;

                        int result = firstNumber + secondNumber;

                        ResultMessage = "Wynik to: " + result.ToString();
                    });
                return calculateCommand; 
            }
        }

        public MainViewModel()
        {
            //CalculateCommand = new Command(Button_Clicked);

            /*CalculateCommand = new Command(()=>
            {
                if (!int.TryParse(StrFirstNumber, out int firstNumber)
               || !int.TryParse(StrSecondNumber, out int secondNumber))
                    return;

                int result = firstNumber + secondNumber;

                ResultMessage = "Wynik to: " + result.ToString();
            });*/
        }


        /*
        private void Button_Clicked()
        {
            if (!int.TryParse(StrFirstNumber, out int firstNumber)
                || !int.TryParse(StrSecondNumber, out int secondNumber))
                return;

            int result = firstNumber + secondNumber;

            ResultMessage = "Wynik to: " + result.ToString();
        }
        */
    }
}
