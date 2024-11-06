using LinqConsoleApp;

List<Person> people = new List<Person>();

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