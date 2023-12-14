#include <iostream>

struct book
{
	std::string title;
	std::string author;
	short publicationYear;
	unsigned short numberOfPages;
};

void menu()
{
	system("cls");
	std::cout << "BIBLIOTEKA\n";
	std::cout << "1. Dodanie nowej książki.\n";

	std::cout << "0. Koniec programu\n";
}

int getOption()
{
	std::cout << "Wybierz opcję:\n";
	int option;
	std::cin >> option;
	return option;
}

int main()
{
	const int BOOK_SIZE = 100;
	book collectionOfBooks[BOOK_SIZE];
	int currentNumberOfBooks = 0;

	while (true)
	{
		menu();
		int choosenOption = getOption();

		if (choosenOption == 0)
			break;

		switch (choosenOption)
		{
		case 1:
			addNewBook(collectionOfBooks, currentNumberOfBooks);
			break;
		}
	}


	/*collectionOfBooks[0].author = "Adam Mickiewicz";
	collectionOfBooks[0].title = "Dziady";
	collectionOfBooks[0].publicationYear = 2003;
	collectionOfBooks[0].numberOfPages = 79;*/



}