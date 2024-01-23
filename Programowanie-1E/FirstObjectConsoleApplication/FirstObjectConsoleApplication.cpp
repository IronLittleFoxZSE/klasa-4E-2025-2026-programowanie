#include <iostream>

class person
{
public:
	std::string name;
	//std::string secondName;
	std::string surname;
	//short height;
	short age;
	//char sex; //'M' - male; 'F' - female

	void showInfo()
	{
		std::cout << "Info o osobie:\n";
		std::cout << "Imię: " << name << "\n";
		std::cout << "Nazwisko: " << surname << "\n";
		std::cout << "Wiek: " << age << "\n";
	}

	bool isLegalAge()
	{
		return age >= 18;
	}
};

int main()
{
	person firstPerson;
	firstPerson.name = "Jan";
	firstPerson.surname = "Kowalski";
	firstPerson.age = 5;

	firstPerson.showInfo();

	if (firstPerson.isLegalAge())
		std::cout << "Jesteś pełnoletni\n";

	person secondPerson;
	secondPerson.name = "Paweł";
	secondPerson.surname = "Nowak";
	secondPerson.age = 49;

	secondPerson.showInfo();
	if (secondPerson.isLegalAge())
		std::cout << "Jesteś pełnoletni\n";
}
