

//PeopleConsoleApp


using PeopleRepositoryClassLibrary;
using PeopleRepositoryClassLibrary.Models;

PeopleRepository peopleRepository = new PeopleRepository();

List<Person> people = peopleRepository.GetAllPeople();

Console.WriteLine("Lista wszystkich osób posortowanych po imieniu i nazwisku");
foreach (Person person in people)
{
    Console.WriteLine($"{person.Id} {person.Name} {person.Surname} lat {person.Age}");
    if (person.Address != null)
    {
        Console.WriteLine($"\t\tOsoba mieszka w {person.Address.City} ");
    }
}

people.Last().Age = 15;

//peopleRepository.AddNewPerson("Janek", "Nieznany", 99);


peopleRepository.UpdateName(1, "Marek");