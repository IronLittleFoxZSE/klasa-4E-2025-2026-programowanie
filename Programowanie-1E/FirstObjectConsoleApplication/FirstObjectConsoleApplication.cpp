#include <iostream>

class Person
{
private:
	std::string name;
	//std::string secondName;
	std::string surname;
	//short height;
	short age;
	//char sex; //'M' - male; 'F' - female

public:
	void ShowInfo()
	{
		std::cout << "Info o osobie:\n";
		std::cout << "Imię: " << name << "\n";
		std::cout << "Nazwisko: " << surname << "\n";
		std::cout << "Wiek: " << age << "\n";
	}

	bool IsLegalAge()
	{
		return age >= 18;
	}

	void SetAge(short a)
	{
		if (a > 0 && a < 130)
			age = a;
		else
			std::cout << "Błędna wartość\n";
	}

	short GetAge()
	{
		return age;
	}
};

int main()
{
	Person firstPerson;
	//firstPerson.name = "Jan";
	//firstPerson.surname = "Kowalski";
	//firstPerson.age = 5000;
	firstPerson.SetAge(500);
	std::cout << "Wiek: " << firstPerson.GetAge() << "\n";

	firstPerson.ShowInfo();

	if (firstPerson.IsLegalAge())
		std::cout << "Jesteś pełnoletni\n";

	Person secondPerson;
	//secondPerson.name = "Paweł";
	//secondPerson.surname = "Nowak";
	//secondPerson.age = 49;

	secondPerson.ShowInfo();
	if (secondPerson.IsLegalAge())
		std::cout << "Jesteś pełnoletni\n";
}

