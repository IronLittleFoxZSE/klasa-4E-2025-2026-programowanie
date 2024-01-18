#include <iostream>

struct person
{
	std::string name;
	//std::string secondName;
	std::string surname;
	//short height;
	short age;
	//char sex; //'M' - male; 'F' - female
};

int main()
{
	person firstPerson;

	firstPerson.name = "Jan";
	firstPerson.surname = "Kowalski";
	firstPerson.age = 5;

	std::cout << "Info o osobie:\n";
	std::cout << "Imię: " << firstPerson.name << "\n";
	std::cout << "Nazwisko: " << firstPerson.surname << "\n";
	std::cout << "Wiek: " << firstPerson.age << "\n";

	person secondPerson;
	secondPerson.name = "Paweł";
	secondPerson.surname = "Nowak";
	secondPerson.age = 49;

	std::cout << "Info o osobie:\n";
	std::cout << "Imię: " << secondPerson.name << "\n";
	std::cout << "Nazwisko: " << secondPerson.surname << "\n";
	std::cout << "Wiek: " << secondPerson.age << "\n";
}
