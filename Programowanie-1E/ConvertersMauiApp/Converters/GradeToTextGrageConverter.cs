using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertersMauiApp.Converters
{
    public class GradeToTextGrageConverter : IValueConverter
    {
        //od źródła (Entry.Text) do miejsca docelowego (Label.Text)
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null
                || value is not string) 
                throw new Exception("Błędna wartość");

            string grade = (string)value;

            string textGrade = grade switch
            {
                "1" => "Niedostateczny",
                "2" => "Dopuszczający",
                "3" => "Dostateczny",
                "4" => "Dobry",
                "5" => "Bardzo dobry",
                "6" => "Celujący",
                _ => "Błędne dane"
            };

            return textGrade;
        }

        //od miejsca docelowego (Label.Text) do źródła (Entry.Text)
        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
