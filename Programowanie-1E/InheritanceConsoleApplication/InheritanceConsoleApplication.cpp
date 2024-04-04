// InheritanceConsoleApplication.cpp 

#include <iostream>

class C
{
protected:
	int number;
	std::string name;
public:
	C()
	{

	}

	int GetNumber()
	{
		return number;
	}
};

class A : public C
{
private:
	//int number;
	bool isEmpty;
public:
	A()
	{
		number = 5;
		isEmpty = false;
		name = "A";
	}

	/*int GetNumber()
	{
		return number;
	}*/

	void ShowInfo()
	{
		std::cout << "Informacja o obiekcie " << name << "\n";
		std::cout << "Number = " << number << "\n";
		std::cout << "IsEmpty = " << isEmpty << "\n";
	}
};

class B : public C
{
private:
	//int number;
	std::string text;
public:
	B()
	{
		number = 5;
		text = "Ala ma kota";
		name = "B";
	}

	/*int GetNumber()
	{
		return number;
	}*/

	void ShowInfo()
	{
		std::cout << "Informacja o obiekcie " << name << "\n";
		std::cout << "Number = " << number << "\n";
		std::cout << "Text = " << text << "\n";
	}
};

int main()
{
	A a;
	//a.ShowInfo();

	B b;
	//b.ShowInfo();

	C c;
	//c.
}
