using LinqConsoleApp;

List<Person> people = new List<Person>();

#region Dodanie elementów do kolekcji

Person person = new Person();
person.name = "Adam";
person.surname = "Nowak";
person.age = 15;

people.Add(person);

person = new Person();
person.name = "Ewa";
person.surname = "Kowalska";
person.age = 54;

people.Add(person);

person = new Person();
person.name = "Jan";
person.surname = "Nowakowski";
person.age = 30;

people.Add(person);

person = new Person();
person.name = "Ewa";
person.surname = "Kowalczyk";
person.age = 30;

people.Add(person);

#endregion


/*
select *
from people
*/
Console.WriteLine("Wszystkie osoby:");
foreach (Person p in people)
{
    Console.WriteLine($"Imie: {p.name} Nazwisko: {p.surname} Wiek: {p.age}");
}
Console.WriteLine();

/*
select max(age)
from people
 */

int maxAge = people.Max(p => p.age);
Console.WriteLine($"Najstarsza osoba ma {maxAge} lat");
Console.WriteLine();

double avgAge = people.Average(p => p.age);
Console.WriteLine($"Średnia osób to {avgAge} lat");
Console.WriteLine();

if (people.Any(p => p.age < 18))
{
    Console.WriteLine("Na kolekcji jest osoba niepełnoletnia");
}

if (people.All(p => p.age >= 18))
{
    Console.WriteLine("Wszystkie osoby są pełnoletnie");
}

/*
select *
from people
where age >= 18
*/

List<Person> legalAgePeople = people.Where(p => p.age >= 18).ToList();
Console.WriteLine("Lista osób pełnoletnich:");
foreach (Person p in legalAgePeople)
{
    Console.WriteLine($"Imie: {p.name} Nazwisko: {p.surname} Wiek: {p.age}");
}
Console.WriteLine();

/*
select *
from people
order by name
*/

var sortedByNamePeople = people.OrderBy(p => p.name).ToList();
Console.WriteLine("Lista osób posortowanych według imienia:");
foreach (Person p in sortedByNamePeople)
{
    Console.WriteLine($"Imie: {p.name} Nazwisko: {p.surname} Wiek: {p.age}");
}
Console.WriteLine();

/*
select *
from people
order by name desc, age asc
*/

var sortedByNameAndAgePeople = people.OrderByDescending(p => p.name).ThenBy(p => p.age);
Console.WriteLine("Lista osób posortowanych według imienia i wieku:");
foreach (Person p in sortedByNameAndAgePeople)
{
    Console.WriteLine($"Imie: {p.name} Nazwisko: {p.surname} Wiek: {p.age}");
}
Console.WriteLine();

/*
select name, count(*), max(age), avg(age)
from people
group by name
*/

var groupBysurnamePeople = people.GroupBy(p => p.name);
Console.WriteLine("Lista pogrupowana według imienia:");
foreach (var group in groupBysurnamePeople)
{
    Console.WriteLine($"Imię w grupie {group.Key}");

    Console.WriteLine("Lista osób w grupie:");
    //var x = people.Where(p => p.name == group.Key);
    foreach(Person p in group)
    {
        Console.WriteLine($"Imie: {p.name} Nazwisko: {p.surname} Wiek: {p.age}");
    }
}