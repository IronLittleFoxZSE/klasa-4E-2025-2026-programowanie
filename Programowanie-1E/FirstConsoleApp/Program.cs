// See https://aka.ms/new-console-template for more information
/*
Komentarz wielolinijkowy
 */

Console.WriteLine("Hello, World!");

string name = "Jan";
string surname = "Kowalski";
string message;
message = "Witaj " + name + " " + surname + " w tym programie.";
message = $"Witaj {name} {surname} w tym programie";
Console.WriteLine(message);

int number;
number = 5;
Console.WriteLine($"Number = {number}");
passingParameters_v1(number);
Console.WriteLine($"Number = {number}");
passingParameters_v2(ref number);
Console.WriteLine($"Number = {number}");
number = 5;
passingParameters_v3(out number);
Console.WriteLine($"Number = {number}");


void passingParameters_v1(int p)    //przekazywanie przez wartość
{
    p++;
    Console.WriteLine($"passingParameters_v1 p= {p}");
}

void passingParameters_v2(ref int p)    //przekazywanie przez referencję
{
    p++;
    Console.WriteLine($"passingParameters_v2 p= {p}");
}

void passingParameters_v3(out int p)    //przekazywanie przez referencję
{
    p = 9;
    p++;
    Console.WriteLine($"passingParameters_v3 p= {p}");
}


string strNumber = "125";
//strNumber = Console.ReadLine();
int firstNumber;

//firstNumber = int.Parse(strNumber);

if (int.TryParse(strNumber,) == false)
{

}

