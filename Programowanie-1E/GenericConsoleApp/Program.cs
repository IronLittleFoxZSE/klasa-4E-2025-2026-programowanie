/*
void ShowMessage(string value)
{
    Console.WriteLine(value);
}

void ShowMessage(double value)
{
    Console.WriteLine(value);
}

void ShowMessage(char value)
{
    Console.WriteLine(value);
}
*/

void ShowMessage<T>(T value)
{
    Console.WriteLine(value);
}

ShowMessage<string>("Ala ma kota");

ShowMessage<int>(1258);

ShowMessage(125.987);

ShowMessage('a');


//---------------------------------------------------

/*
void Swap(ref int x, ref int y)
{
    int tmp = x; 
    x = y; 
    y = tmp;
}

void Swap(ref string x, ref string y)
{
    string tmp = x;
    x = y;
    y = tmp;
}
*/

void Swap<T>(ref T x, ref T y)
{
    T tmp = x;
    x = y;
    y = tmp;
}

int firstNumber = 5;
int secondNumber = 7;

Swap(ref firstNumber, ref secondNumber);

string firstText = "Ala";
string secondText = "Ola";
Swap(ref firstText, ref secondText);

//-----------------------------------------------------------

OurClass<int> firstObject = new OurClass<int>();
firstObject.first = 5;

OurClass<string> secondObject = new OurClass<string>();
secondObject.first = "Ala";

class OurClass<T>
{
    
    public T first;
}

