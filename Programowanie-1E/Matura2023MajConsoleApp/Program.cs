

StreamReader streamReader = new StreamReader("skrot_przyklad.txt");

string? strNumberFromFile;
List<string> strNumbersFromFile = new List<string>();

while ((strNumberFromFile = streamReader.ReadLine()) != null)
{
    strNumbersFromFile.Add(strNumberFromFile);
}

streamReader.Close();

List<int> numbers = strNumbersFromFile.Select(s => int.Parse(s)).ToList();

int GetOddAbbreviation(int number)
{
    int oddAbbreviation = 0;

    int positionMultiplier = 1;

    while (number != 0)
    {
        int rest = number % 10;
        number /= 10;
        if (rest % 2 != 0)
        {
            oddAbbreviation = rest * positionMultiplier + oddAbbreviation;
            positionMultiplier *= 10;
        }
    }

    return oddAbbreviation;
}

//zadanie 3.2

List<int> numbersWithoutOddAbbreviation = numbers.Where(n => GetOddAbbreviation(n) == 0).ToList();
int max = numbersWithoutOddAbbreviation.Max();

Console.WriteLine("Zadanie 3.2");
Console.WriteLine(numbersWithoutOddAbbreviation.Count);
Console.WriteLine(max);

//zadanie 3.3

streamReader = new StreamReader("skrot2_przyklad.txt");

strNumbersFromFile = new List<string>();

while ((strNumberFromFile = streamReader.ReadLine()) != null)
{
    strNumbersFromFile.Add(strNumberFromFile);
}

streamReader.Close();

numbers = strNumbersFromFile.Select(s => int.Parse(s)).ToList();

int NWD(int a, int b)
{
    if (b == 0)
        return a;
    else
        return NWD(b, a % b);
}

Console.WriteLine("Zadanie 3.3");

List<int> numbersNWD7 = numbers
    .Where(n => NWD(n, GetOddAbbreviation(n)) == 7).ToList();

foreach (int number in numbersNWD7)
{
    Console.WriteLine(number);
}