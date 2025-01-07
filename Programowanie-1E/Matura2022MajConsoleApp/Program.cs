

//Matura2022MajConsoleApp

StreamReader streamReader = new StreamReader("przyklad.txt");

string? strNumberFromFile;
List<string> strNumbersFromFile = new List<string>();

while( (strNumberFromFile = streamReader.ReadLine()) != null)
{
    strNumbersFromFile.Add(strNumberFromFile);
}

streamReader.Close();

//zadanie 4.1

byte counter = 0;
string? firtFindNumber = null;
foreach (string strNumber in strNumbersFromFile)
{
    /*
    int number = Convert.ToInt32(strNumber);
    int lastDigit = number % 10;
    int firstDigit;
    do
    {
        firstDigit = number % 10;
    } while (number / 10 != 0);
    */

    char firstDigit = strNumber[0];
    char lastDigit = strNumber[strNumber.Length -1];

    if (firstDigit == lastDigit)
    {
        counter++;
        if (firtFindNumber == null)
            firtFindNumber = strNumber;
    }
}

Console.WriteLine($"Zadanie 4.1: {counter} {firtFindNumber}");

//zadanie 4.2
int maxNumber = 1;
int maxNumberCounter = 0;
foreach (string strNumber in strNumbersFromFile)
{
    int number = Convert.ToInt32(strNumber);

    //Console.WriteLine($"Rozkład liczby {number}:");
    int divisor = 2;
    int couter = 0;
    while(number != 1)
    {
        if (number % divisor == 0)
        {
            number = number / divisor;
            //Console.Write($"{divisor} ");
            couter++;
        }
        else
            divisor++;
    }
    if (couter > maxNumberCounter)
    {
        maxNumberCounter = couter;
        maxNumber = Convert.ToInt32(strNumber);
    }
    //Console.WriteLine();
}
Console.WriteLine($"Liczba z znajwiększą ilością czynników pierwszych: {maxNumber} {maxNumberCounter}");
