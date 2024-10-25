

//CollectionConsoleApp

//C++
//int tab[10];
//indeksy tej tablicy to 0-9
//tab[3] = 5;
//int x = tab[4];

//c#
using static System.Runtime.InteropServices.JavaScript.JSType;

int[] tab;
tab = new int[10];
//indeksy tej tablicy to 0-9
tab[3] = 5;
int x = tab[4];
int len = tab.Length;

Console.WriteLine("Kolekcja tylu List:");
List<int> numbersCollection = new List<int>();
Console.WriteLine($"Na początku rozmiar kolekcji to {numbersCollection.Count}");
numbersCollection.Add(5);
Console.WriteLine($"Po dodaniu wartości 5 rozmiar to {numbersCollection.Count}");
numbersCollection.Add(8);
numbersCollection.Add(45);
numbersCollection.Add(-5);
numbersCollection.Add(87);
numbersCollection.Add(2);
numbersCollection.Add(18);
numbersCollection.Add(15);
Console.WriteLine($"Po dodaniu kolejnych trzech wartości rozmiar to {numbersCollection.Count}");

numbersCollection[1] = 2;

Console.WriteLine("Elementy kolekcji:");
for (int i = 0; i < numbersCollection.Count; i++)
{
    Console.WriteLine(numbersCollection[i]);
}

numbersCollection.RemoveAt(2);
Console.WriteLine($"Po usunięciu elementu z ineksu 2 rozmiar to {numbersCollection.Count}");

Console.WriteLine("Elementy kolekcji:");
/*for (int i = 0; i < numbersCollection.Count; i++)
{
    Console.WriteLine(numbersCollection[i]);
}*/

foreach (int number in numbersCollection)
{
    Console.WriteLine(number);
    //numbersCollection.Add(-5);  //OPERACJA NIEDOZWOLONA
}

bool IsEven(int n)
{
    return n % 2 == 0;
}

List<int> evenNumbers = new List<int>();
foreach (int number in numbersCollection)
{
    //if (number % 2 == 0)
    if (IsEven(number))
        evenNumbers.Add(number);
}

Console.WriteLine("Parzyste liczby z kolekcji:");
foreach (int number in evenNumbers)
{
    Console.WriteLine(number);
}

bool IsGreat7(int n)
{
    return n > 7;
}

List<int> numberGreat7 = new List<int>();
foreach (int number in numbersCollection)
{
    //if (number > 7)
    if (IsGreat7(number))
        numberGreat7.Add(number);
}

Console.WriteLine("Liczby większe od siedem");
foreach (int number in numberGreat7)
{
    Console.WriteLine(number);
}

void ShowStaticMessage()
{
    Console.WriteLine("Hello world!");
}

void ShowAnotherStaticMessage()
{
    Console.WriteLine("Witaj świecie!");
}

ShowStaticMessage();
ShowAnotherStaticMessage();

Action action;
action = ShowStaticMessage;
action();
action = ShowAnotherStaticMessage;
action();

Console.WriteLine("Przed wywołaniem");
ShowStaticMessage();
Console.WriteLine("Po wywołaniu");

Console.WriteLine("Przed wywołaniem");
ShowAnotherStaticMessage();
Console.WriteLine("Po wywołaniu");

void AnotherMetod(Action action)
{
    Console.WriteLine("Przed wywołaniem");
    action();
    Console.WriteLine("Po wywołaniu");
}

AnotherMetod(ShowStaticMessage);
AnotherMetod(ShowAnotherStaticMessage);

void ShowMessaage(string message)
{
    Console.WriteLine(message);
}

Action<string> secondAction;
secondAction = ShowMessaage;
secondAction("Jakiś tekst"); //ShowMessaage("Jakiś tekst");

void ShowMessaage2(string message, int x)
{
    Console.WriteLine(message);
}

Action<string, int> thirdAction;
thirdAction = ShowMessaage2;
thirdAction("Tekst", 2);

float GetNumber()
{
    return new Random().Next();
}

Func<float> firstFunc;
firstFunc = GetNumber;
float n;
n = firstFunc(); // n = GetNumber();

string GetString(int x, float y)
{
    return "Cokolwiek";
}

Func<int, float, string> secondFunc;
secondFunc = GetString;
secondFunc(2, 5);

void ShowCollection(string message, List<int> collection)
{
    Console.WriteLine(message);
    foreach (int number in collection)
    {
        Console.WriteLine(number);
    }
}

void FilterCollection(List<int> sourceCollection, List<int> destinationCollection, Func<int,bool> func)
{
    foreach (int number in sourceCollection)
    {
        if (func(number))
            destinationCollection.Add(number);
    }
}

numberGreat7 = new List<int>();
FilterCollection(numbersCollection, numberGreat7, IsGreat7);
ShowCollection("Liczby większe od siedem", numberGreat7);
evenNumbers = new List<int>();
FilterCollection(numbersCollection, evenNumbers, IsEven);
ShowCollection("Parzyste liczby z kolekcji:", evenNumbers);

bool IsFrom5To19(int n)
{
    return n > 5 && n < 19;
}

/*void ShowStaticMessage()
{
    Console.WriteLine("Hello world!");
}*/

action = ShowStaticMessage;
action = () => { Console.WriteLine("Hello world!"); };
action();

/*
 * void ShowMessaage(string message)
{
    Console.WriteLine(message);
}
*/

//Action<string> secondAction;
secondAction = ShowMessaage;
secondAction = (string message) => { Console.WriteLine(message);  }; 
secondAction = (message) => { Console.WriteLine(message);  }; 
secondAction = message => { Console.WriteLine(message);  }; 


Func<int, bool> thirdFunc;
thirdFunc = IsFrom5To19;
thirdFunc = 

List<int> numbers = new List<int>();
FilterCollection(numbersCollection, numbers, IsFrom5To19);