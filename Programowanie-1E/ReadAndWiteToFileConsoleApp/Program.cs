

//ReadAndWriteToFileConsoleApp

//Zapis do pliku

string name;
int age;
Console.WriteLine("Podaj imie");
name = Console.ReadLine();
Console.WriteLine("Podaj wiek");
age = int.Parse(Console.ReadLine());

StreamWriter streamWriter = new StreamWriter("c:\\plik3E.txt", true);

streamWriter.WriteLine(name);
streamWriter.Flush();
streamWriter.WriteLine(age);

streamWriter.Close();

StreamReader streamReader = new StreamReader("c:\\plik3E.txt");

name = streamReader.ReadLine();
age = int.Parse(streamReader.ReadLine());

Console.WriteLine($"Odczytano z pliku {name} {age}");

streamReader.Close();