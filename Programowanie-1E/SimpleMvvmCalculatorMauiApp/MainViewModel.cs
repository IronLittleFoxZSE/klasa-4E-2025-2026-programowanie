using SimpleMvvmCalculatorMauiApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMvvmCalculatorMauiApp
{
    internal class MainViewModel : BindableObject
    {
        public string StrFirstNumber
        {
            get { return dataRepository.strFirstNumber; }
            set { dataRepository.strFirstNumber = value; }
        }

        public string StrSecondNumber
        {
            get { return dataRepository.strSecondNumber; }
            set { dataRepository.strSecondNumber = value; }
        }

        public string ResultMessage
        {
            get { return dataRepository.resultMessage; }
            set { dataRepository.resultMessage = value; OnPropertyChanged(); }
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
                        ResultMessage = service.Calculate(StrFirstNumber, StrSecondNumber);
                    });
                return calculateCommand; 
            }
        }

        private bool whichServices;
        public bool WhichSerwices
        {
            get { return whichServices; }
            set 
            { 
                whichServices = value;
                if (whichServices)
                    service = new DivService();
                else
                    service = new SumService();
                    //service = new ArithmeticService();
            }
        }


        private ArithmeticService service;
        private DataRepository dataRepository;

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

            //service = new SumService();
            //service = new DivService();
            WhichSerwices = true;
            dataRepository = new DataRepository();

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
