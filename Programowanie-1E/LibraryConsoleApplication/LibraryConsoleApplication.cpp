#include <iostream>

struct book
{
    std::string title;
    std::string author;
    short publicationYear;
    unsigned short numberOfPages;
};


int main()
{
    const int BOOK_SIZE = 101;
    book collectionOfBooks[BOOK_SIZE];

    int size;
    std::cin >> size;
    book* colOfBooks = new book[size];
    colOfBooks[0].title = "Lalka";

    collectionOfBooks[0].author = "Adam Mickiewicz";
    collectionOfBooks[0].title = "Dziady";
    collectionOfBooks[0].publicationYear = 2003;
    collectionOfBooks[0].numberOfPages = 79;



}