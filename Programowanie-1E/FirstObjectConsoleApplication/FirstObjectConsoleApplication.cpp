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
	Person()
	{
		name = "Jan";
		surname = "Kowalski";
		age = 25;
	}

	Person(std::string n, std::string s, short a)
	{
		name = n;
		surname = s;
		age = a;
	}
	
	~Person()
	{
		std::cout << "Teraz działa destruktor: imię " << name << "\n";
	}

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
	setlocale(LC_CTYPE, "polish");

	Person firstPerson;
	//firstPerson.name = "Jan";
	//firstPerson.surname = "Kowalski";
	//firstPerson.age = 50;
	//firstPerson.SetAge(50);
	//std::cout << "Wiek: " << firstPerson.GetAge() << "\n";

	firstPerson.ShowInfo();

	if (firstPerson.IsLegalAge())
		std::cout << "Jesteś pełnoletni\n";

	Person secondPerson("Paweł", "Nowak", 49);
	//secondPerson.name = "Paweł";
	//secondPerson.surname = "Nowak";
	//secondPerson.age = 49;

	secondPerson.ShowInfo();
	if (secondPerson.IsLegalAge())
		std::cout << "Jesteś pełnoletni\n";
}

