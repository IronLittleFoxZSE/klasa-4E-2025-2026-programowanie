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
	std::cout << "2. Wyświetlenie wszystkich książek\n";

	std::cout << "0. Koniec programu\n";
}

int getOption()
{
	std::cout << "Wybierz opcję:\n";
	int option;
	std::cin >> option;
	return option;
}

void addNewBook(book books[], int &currentNumberOfBooks)
{
	currentNumberOfBooks++;
	std::cout << "Podaj tytuł:\n";
	std::cin >> books[currentNumberOfBooks].title;
	std::cout << "Podaj autora:\n";
	std::cin >> books[currentNumberOfBooks].author;
	std::cout << "Podaj rok publickacji:\n";
	std::cin >> books[currentNumberOfBooks].publicationYear;
	std::cout << "Podaj ilość stron:\n";
	std::cin >> books[currentNumberOfBooks].numberOfPages;
}

void showAllBooks(book books[], int currentNumberOfBooks)
{
	system("cls");
	std::cout << "Wyświetlenie wszystkich pozycji:\n";
	for (int i = 0; i <= currentNumberOfBooks; i++)
	{
		std::cout << "------------------------------------------\n";
		std::cout << "Tytuł: " << books[i].title << "\n";
		std::cout << "Autor: " << books[i].author << "\n";
		std::cout << "Rok wydania: " << books[i].publicationYear << "\n";
		std::cout << "Ilość stron: " << books[i].numberOfPages << "\n";
	}
	system("pause");
}

int main()
{
	setlocale(LC_CTYPE, "polish");
	const int BOOK_SIZE = 100;
	book collectionOfBooks[BOOK_SIZE];
	int currentNumberOfBooks = -1;

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
		case 2:
			showAllBooks(collectionOfBooks, currentNumberOfBooks);
			break;
		}
	}


	/*collectionOfBooks[0].author = "Adam Mickiewicz";
	collectionOfBooks[0].title = "Dziady";
	collectionOfBooks[0].publicationYear = 2003;
	collectionOfBooks[0].numberOfPages = 79;*/



}