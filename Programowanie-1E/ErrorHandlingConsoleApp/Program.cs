//ErrorHandlingConsoleApp

int firstNumber, secondNumber, thirdNumber = 5;
string message;

Console.WriteLine("Podaj pierwszą liczbę:");
firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj drugą liczbę:");
secondNumber = int.Parse(Console.ReadLine());

int result = 0;




//wersja 1
Console.WriteLine("Wersja 1:");
if (secondNumber != 0)
{
    result = firstNumber / secondNumber;
    Console.WriteLine($"Wynik dzielenia: {result}");
}
else
    Console.WriteLine("Nie można dzilić prze zero!!!");









//wersja 2 - złamana zasada DRY dla IF - sprawdzamy te same warunki

//Komentarz dokumentujący
//Co robi funkcja, jakie parametry przyjmuje i co zwraca
//Opisać błedy

//Funkcja wykonuje dzielenie dwóch liczb
//Dane wejściowe:
//a - pierwsza liczba
//b - druga liczba
//Dane wyjściowe: wynik dzielenia a/b
//Błędy:
//* druga liczba nie może być równa zero
int Div(int a, int b)
{
    int r;
    r = a / b;
    return r;
}

Console.WriteLine("Wersja 2:");
if (secondNumber != 0)
{
    result = Div(firstNumber, secondNumber);
    Console.WriteLine($"Wynik dzielenia: {result}");
}
else
    Console.WriteLine("Nie można dzilić prze zero!!!");

/*
...
*/
//...
thirdNumber = thirdNumber - 5;
if (thirdNumber != 0)
    Console.WriteLine($"Wynik dzilenia {Div(5, thirdNumber)}");

//wersja 3 - złamana zasada DRY dla IF - sprawdzamy te same warunki

//Komentarz dokumentujący
//Co robi funkcja, jakie parametry przyjmuje i co zwraca
//Opisać błedy

//Funkcja wykonuje dzielenie dwóch liczb
//Dane wejściowe:
//a - pierwsza liczba
//b - druga liczba
//Dane wyjściowe:
//* return - informacja czy udało się podzielić
//* r - wynik dzielenia a/b
//Błędy:
//* druga liczba nie może być równa zero
bool Div2(int a, int b, out int r)
{
    if (b != 0)
    {
        r = a / b;
        return true;
    }

    r = 0;
    return false;
}

Console.WriteLine("Wersja 3:");
if (Div2(firstNumber, secondNumber, out result) /*== true*/)
{
    Console.WriteLine($"Wynik dzielenia: {result}");
}
else
    Console.WriteLine("Nie można dzilić prze zero!!!");

/*
...
*/
//...
thirdNumber = 0;
if (Div2(5, thirdNumber, out result))
    Console.WriteLine($"Wynik dzilenia {result}");


//wersja 4
bool Operations(int a, int b, char sign, out int r, out string message)
{
    message = "";
    switch (sign)
    {
        case '+':
            r = a + b;
            return true;
        case '-':
            r = a - b;
            return true;
        case '*':
            r = a * b;
            return true;
        case '/':
            if (b != 0)
            {
                r = a / b;
                return true;
            }
            else
            {
                r = 0;
                message = "Nie można dzielić prze zero!!!";
                return false;
            }
        default:
            r = 0;
            message = "Nie ma takiej operacji";
            return false;
    }
}
Console.WriteLine("Wersja 4:");
if (Operations(firstNumber, secondNumber, '?', out result, out message))
    Console.WriteLine($"Wynik operacji {result}");
else
    Console.WriteLine(message);


Console.WriteLine("Wersja 5:");
bool isOk;

isOk = Operations(firstNumber, secondNumber, '?', out result, out message);
if (isOk)
    Console.WriteLine($"Wynik operacji {result}");

if (!isOk && message == "Nie można dzilić prze zero!!!")
    Console.WriteLine(message);

if (!isOk && message == "Nie ma takiej operacji")
{
    //zapisanie jako log do pliku
}


//wersja 6
Console.WriteLine("Wersja 6:");

try
{
    result = firstNumber / secondNumber;
    Console.WriteLine($"Wynik dzielenia: {result}");
}
catch (Exception ex)
{
    //Console.WriteLine("Nie można dzielić prze zero!!!");
    Console.WriteLine(ex.Message);
}

//wersja 7

int DivV7(int a, int b)
{
    int r;
    r = a / b;
    return r;
}

Console.WriteLine("Wersja 7:");
try
{
    result = DivV7(firstNumber, secondNumber);
    result = DivV7(firstNumber, secondNumber + 1);
    Console.WriteLine($"Wynik dzielenia: {result}");
}
catch (Exception ex)
{
    //Console.WriteLine("Nie można dzilić prze zero!!!");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

//wersja 8
int OperationsV8(int a, int b, char sign)
{
    int r;
    message = "";
    switch (sign)
    {
        case '+':
            r = a + b;
            return r;
        case '-':
            r = a - b;
            return r;
        case '*':
            r = a * b;
            return r;
        case '/':
            r = a / b;
            return r;
        default:
            Exception e = new Exception("Nie ma takiej operacji");
            throw e;
    }
}
Console.WriteLine("Wersja 8:");
try
{
    result = OperationsV8(firstNumber, secondNumber, '?');
    Console.WriteLine($"Wynik operacji {result}");
}
catch (Exception ex)
{
    Console.WriteLine(message);
}

//wersja 9
int OperationsV9(int a, int b, char sign)
{
    int r;
    message = "";
    switch (sign)
    {
        case '+':
            r = a + b;
            return r;
        case '-':
            r = a - b;
            return r;
        case '*':
            r = a * b;
            return r;
        case '/':
            r = a / b;
            return r;
        default:
            Exception e = new Exception("Nie ma takiej operacji");
            throw e;
    }
}
Console.WriteLine("Wersja 9:");
try
{
    result = OperationsV9(firstNumber, 0, '?');
    Console.WriteLine($"Wynik operacji {result}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(message);
}