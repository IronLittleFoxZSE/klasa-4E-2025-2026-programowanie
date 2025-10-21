namespace ConvertersMauiApp
{
    public partial class MainPage : ContentPage
    {
        private string textGrade;
        public string TextGrade
        {
            get { return textGrade; }
            set { textGrade = value; OnPropertyChanged(); }
        }

        private string grade;
        public string Grade
        {
            get { return grade; }
            set
            {
                grade = value;
                switch (grade)
                {
                    case "1":
                        TextGrade = "Niedostateczny";
                        break;
                    case "2":
                        TextGrade = "Dopuszczający";
                        break;
                    case "3":
                        TextGrade = "Dostateczny";
                        break;
                    case "4":
                        TextGrade = "Dobry";
                        break;
                    case "5":
                        TextGrade = "Bardzo dobry";
                        break;
                    case "6":
                        TextGrade = "Celujący";
                        break;
                    default:
                        TextGrade = "Nie ma takiej oceny";
                        break;
                }
            }
        }



        public MainPage()
        {
            InitializeComponent();
            Grade = "1";
        }
    }
}
